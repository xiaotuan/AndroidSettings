<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AndroidSettingsForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        tcAndroidSettings = New TabControl()
        tpProjectInfo = New TabPage()
        GbChiperOptions = New GroupBox()
        CbChiperModel = New ComboBox()
        CbChiperMaker = New ComboBox()
        LbChiperModel = New Label()
        LbChiperMaker = New Label()
        GbGoOptions = New GroupBox()
        RbOneGbGo = New RadioButton()
        RbTwoGbGo = New RadioButton()
        RbNotGo = New RadioButton()
        GbGmsOptions = New GroupBox()
        RbNotGms = New RadioButton()
        RbGms = New RadioButton()
        GBProject = New GroupBox()
        CbProjectPath = New ComboBox()
        TbCustomName = New TextBox()
        TbMssiName = New TextBox()
        TbDriveName = New TextBox()
        TbPublicName = New TextBox()
        CbAndroidVersin = New ComboBox()
        LbAndroidVersion = New Label()
        Label4 = New Label()
        LbDriveName = New Label()
        LbMssiName = New Label()
        LbPublicName = New Label()
        BtSelectProjectPath = New Button()
        LbProjectPath = New Label()
        CBProjectId = New ComboBox()
        LbProjectId = New Label()
        tpProperty = New TabPage()
        lbProductManufacturerState = New Label()
        lbProductDeviceState = New Label()
        lbProductBrandState = New Label()
        lbProductModelState = New Label()
        lbProductNameState = New Label()
        btPropertySetting = New Button()
        tbProductManufacturer = New TextBox()
        lbProductManufacturer = New Label()
        tbProductDevice = New TextBox()
        lbProductDevice = New Label()
        tbProductBrand = New TextBox()
        lbProductBrand = New Label()
        tbProductModel = New TextBox()
        lbProductModel = New Label()
        tbProductName = New TextBox()
        lbProductName = New Label()
        tpVersion = New TabPage()
        lbVersionState = New Label()
        btVersion = New Button()
        tbVersion = New TextBox()
        lbVersion = New Label()
        tpFingerprint = New TabPage()
        btFingerprintSet = New Button()
        btRandom = New Button()
        lbFingerprintState = New Label()
        tbFingerprint = New TextBox()
        lbFingerprint = New Label()
        tpWifi = New TabPage()
        btWifiSetting = New Button()
        lbWifiScreenCastState = New Label()
        lbWifiHotspotNameState = New Label()
        lbWifiStatusState = New Label()
        tbWifiScreenCast = New TextBox()
        tbWifiHotspotName = New TextBox()
        lbWifiScreenCast = New Label()
        lbWifiHotspotName = New Label()
        rbWifiClose = New RadioButton()
        rbWifiOpen = New RadioButton()
        lbWifiStatus = New Label()
        tpBluetooth = New TabPage()
        btBluetoothSetting = New Button()
        tbBluetoothName = New TextBox()
        rbBluetoothClose = New RadioButton()
        rbBluetoothOpen = New RadioButton()
        lbBluetoothNameState = New Label()
        lbBluetoothName = New Label()
        lbBluetoothStatusState = New Label()
        lbBluetoothStatus = New Label()
        tpLanguage = New TabPage()
        btLanguageSetting = New Button()
        cbLanguage = New ComboBox()
        lbLanguageState = New Label()
        Label1 = New Label()
        tpTimezone = New TabPage()
        rbTimezoneClose = New RadioButton()
        rbTimezoneOpen = New RadioButton()
        lbAutoTimezone = New Label()
        cbTimezone = New ComboBox()
        lbAutoTimezoneState = New Label()
        lbTimezoneState = New Label()
        lbTimezone = New Label()
        btTimezoneSetting = New Button()
        tpLogo = New TabPage()
        btLogoSetting = New Button()
        bLogo = New Button()
        tbLogo = New TextBox()
        lbLogoState = New Label()
        lbLogo = New Label()
        tpWallpaper = New TabPage()
        btWallpaperSetting = New Button()
        btInserWallpaper = New Button()
        btWallpaper = New Button()
        tbInsertWallpaper = New TextBox()
        lbInsertWallpaperState = New Label()
        tbWallpaper = New TextBox()
        lbInsertWallpaper = New Label()
        lbWallpaperState = New Label()
        lbWallpaper = New Label()
        tpSample = New TabPage()
        btSampleName = New Button()
        btSample = New Button()
        tbSampleName = New TextBox()
        btSampleSetting = New Button()
        rbSampleClose = New RadioButton()
        rbSampleOpen = New RadioButton()
        Label3 = New Label()
        lbSampleNameState = New Label()
        lbSampleState = New Label()
        lbSample = New Label()
        tpScreenBrightness = New TabPage()
        btBrightnessAllSet = New Button()
        btMinBrightness = New Button()
        btMaxBrightness = New Button()
        btDefaultBrightness = New Button()
        lbMinBrightnessStatus = New Label()
        lbMaxBrightnessStatus = New Label()
        lbDefaultBrightnessStatus = New Label()
        tbMinBrightness = New TextBox()
        lbMinBrightness = New Label()
        tbMaxBrightness = New TextBox()
        lbMaxBrightness = New Label()
        tbDefaultBrightness = New TextBox()
        lbDefaultBrightness = New Label()
        tpVolume = New TabPage()
        cbOtherVolume = New ComboBox()
        cbNotifyVolume = New ComboBox()
        cbAlarmVolume = New ComboBox()
        cbMusicVolume = New ComboBox()
        cbRingVolume = New ComboBox()
        cbCallVolume = New ComboBox()
        btVolumeAllSet = New Button()
        btOtherVolume = New Button()
        btNotifyVolume = New Button()
        btAlarmVolume = New Button()
        btMusicVolume = New Button()
        btRingVolume = New Button()
        btCallVolume = New Button()
        lbOtherVolumeStatus = New Label()
        lbNotifyVolumeStatus = New Label()
        lbAlarmVolumeStatus = New Label()
        lbMusicVolumeStatus = New Label()
        lbRingVolumeStatus = New Label()
        lbCallVolumeStatus = New Label()
        lbOtherVolume = New Label()
        lbNotifyVolume = New Label()
        lbAlarmVolume = New Label()
        lbMusicVolume = New Label()
        lbRingVolume = New Label()
        lbCallVolume = New Label()
        tpTee = New TabPage()
        lbTeeArrayStatus = New Label()
        lbTeeCertStatus = New Label()
        btTeeAllSet = New Button()
        btTeeArray = New Button()
        btnTeeSelectArray = New Button()
        btnTeeSelectCert = New Button()
        btTeeCert = New Button()
        tbTeeArray = New TextBox()
        lbTeeArray = New Label()
        tbTeeCert = New TextBox()
        lbTeeCert = New Label()
        lbTeeStatus = New Label()
        btTee = New Button()
        rbTeeClose = New RadioButton()
        rbTeeOpen = New RadioButton()
        lbTee = New Label()
        tpGoogleCustom = New TabPage()
        lbEmailSignatureStatus = New Label()
        lbHomePageStatus = New Label()
        btGoogleCustom = New Button()
        btEmailSignature = New Button()
        btHomePage = New Button()
        tbEmailSignature = New TextBox()
        lbEmailSignature = New Label()
        tbHomePage = New TextBox()
        lbHomePage = New Label()
        tpAnimation = New TabPage()
        lbAnimTip = New Label()
        lbShutdownAnimStatus = New Label()
        lbShutdownRingStatus = New Label()
        lbBootAnimStatus = New Label()
        lbBootRingStatus = New Label()
        btAnimSet = New Button()
        btShutdownAnim = New Button()
        btShutdownRing = New Button()
        btBootAnim = New Button()
        btBootRing = New Button()
        btSelectShutdownAnim = New Button()
        btSelectShutdownRing = New Button()
        btSelectBootAnim = New Button()
        btSelectBootRing = New Button()
        tbShutdownAnim = New TextBox()
        lbShutdownAnim = New Label()
        tbShutdownRing = New TextBox()
        lbShutdownRing = New Label()
        tbBootAnim = New TextBox()
        lbBootAnim = New Label()
        tbBootRing = New TextBox()
        lbBootRing = New Label()
        tpSystemSettings = New TabPage()
        cbDisableScreenlock = New ComboBox()
        cbAutoBrightness = New ComboBox()
        cbAutoTime = New ComboBox()
        cb24TimeFormat = New ComboBox()
        cbGps = New ComboBox()
        cbAutoRotation = New ComboBox()
        Label7 = New Label()
        lb24TimeFormatStatus = New Label()
        lbGpsStatus = New Label()
        lbAutoRotationStatus = New Label()
        btSystemConfig = New Button()
        bt24TimeFormat = New Button()
        btGps = New Button()
        btAutoRotation = New Button()
        lbDisableScreenlockStatus = New Label()
        lbAutoBrightnessStatus = New Label()
        lbAutoTimeStatus = New Label()
        lbScreenOffTimeStatus = New Label()
        btDisableScreenlock = New Button()
        btAutoBrightness = New Button()
        btAutoTime = New Button()
        btnScreenOffTime = New Button()
        lb24TimeFormat = New Label()
        lbGps = New Label()
        lbDisableScreenlock = New Label()
        lbAutoRotation = New Label()
        lbAutoBrightness = New Label()
        tbScreenOffTime = New TextBox()
        lbAutoTime = New Label()
        lbScreenOffTime = New Label()
        FbdSelectPath = New FolderBrowserDialog()
        ofdSelectFile = New OpenFileDialog()
        tcAndroidSettings.SuspendLayout()
        tpProjectInfo.SuspendLayout()
        GbChiperOptions.SuspendLayout()
        GbGoOptions.SuspendLayout()
        GbGmsOptions.SuspendLayout()
        GBProject.SuspendLayout()
        tpProperty.SuspendLayout()
        tpVersion.SuspendLayout()
        tpFingerprint.SuspendLayout()
        tpWifi.SuspendLayout()
        tpBluetooth.SuspendLayout()
        tpLanguage.SuspendLayout()
        tpTimezone.SuspendLayout()
        tpLogo.SuspendLayout()
        tpWallpaper.SuspendLayout()
        tpSample.SuspendLayout()
        tpScreenBrightness.SuspendLayout()
        tpVolume.SuspendLayout()
        tpTee.SuspendLayout()
        tpGoogleCustom.SuspendLayout()
        tpAnimation.SuspendLayout()
        tpSystemSettings.SuspendLayout()
        SuspendLayout()
        ' 
        ' tcAndroidSettings
        ' 
        tcAndroidSettings.Controls.Add(tpProjectInfo)
        tcAndroidSettings.Controls.Add(tpProperty)
        tcAndroidSettings.Controls.Add(tpVersion)
        tcAndroidSettings.Controls.Add(tpFingerprint)
        tcAndroidSettings.Controls.Add(tpWifi)
        tcAndroidSettings.Controls.Add(tpBluetooth)
        tcAndroidSettings.Controls.Add(tpLanguage)
        tcAndroidSettings.Controls.Add(tpTimezone)
        tcAndroidSettings.Controls.Add(tpLogo)
        tcAndroidSettings.Controls.Add(tpWallpaper)
        tcAndroidSettings.Controls.Add(tpSample)
        tcAndroidSettings.Controls.Add(tpScreenBrightness)
        tcAndroidSettings.Controls.Add(tpVolume)
        tcAndroidSettings.Controls.Add(tpTee)
        tcAndroidSettings.Controls.Add(tpGoogleCustom)
        tcAndroidSettings.Controls.Add(tpAnimation)
        tcAndroidSettings.Controls.Add(tpSystemSettings)
        tcAndroidSettings.ItemSize = New Size(80, 22)
        tcAndroidSettings.Location = New Point(12, 12)
        tcAndroidSettings.Multiline = True
        tcAndroidSettings.Name = "tcAndroidSettings"
        tcAndroidSettings.SelectedIndex = 0
        tcAndroidSettings.Size = New Size(823, 501)
        tcAndroidSettings.SizeMode = TabSizeMode.Fixed
        tcAndroidSettings.TabIndex = 0
        ' 
        ' tpProjectInfo
        ' 
        tpProjectInfo.Controls.Add(GbChiperOptions)
        tpProjectInfo.Controls.Add(GbGoOptions)
        tpProjectInfo.Controls.Add(GbGmsOptions)
        tpProjectInfo.Controls.Add(GBProject)
        tpProjectInfo.Location = New Point(4, 48)
        tpProjectInfo.Name = "tpProjectInfo"
        tpProjectInfo.Padding = New Padding(3)
        tpProjectInfo.Size = New Size(815, 449)
        tpProjectInfo.TabIndex = 0
        tpProjectInfo.Text = "工程信息"
        tpProjectInfo.UseVisualStyleBackColor = True
        ' 
        ' GbChiperOptions
        ' 
        GbChiperOptions.Controls.Add(CbChiperModel)
        GbChiperOptions.Controls.Add(CbChiperMaker)
        GbChiperOptions.Controls.Add(LbChiperModel)
        GbChiperOptions.Controls.Add(LbChiperMaker)
        GbChiperOptions.Location = New Point(6, 347)
        GbChiperOptions.Name = "GbChiperOptions"
        GbChiperOptions.Size = New Size(803, 97)
        GbChiperOptions.TabIndex = 2
        GbChiperOptions.TabStop = False
        GbChiperOptions.Text = "芯片选项"
        ' 
        ' CbChiperModel
        ' 
        CbChiperModel.FormattingEnabled = True
        CbChiperModel.Items.AddRange(New Object() {"MT6761", "MT6739", "MT8183"})
        CbChiperModel.Location = New Point(80, 57)
        CbChiperModel.Name = "CbChiperModel"
        CbChiperModel.Size = New Size(212, 25)
        CbChiperModel.TabIndex = 1
        CbChiperModel.Text = "MT6761"
        ' 
        ' CbChiperMaker
        ' 
        CbChiperMaker.FormattingEnabled = True
        CbChiperMaker.Items.AddRange(New Object() {"MTK"})
        CbChiperMaker.Location = New Point(80, 21)
        CbChiperMaker.Name = "CbChiperMaker"
        CbChiperMaker.Size = New Size(212, 25)
        CbChiperMaker.TabIndex = 1
        CbChiperMaker.Text = "MTK"
        ' 
        ' LbChiperModel
        ' 
        LbChiperModel.AutoSize = True
        LbChiperModel.Location = New Point(6, 60)
        LbChiperModel.Name = "LbChiperModel"
        LbChiperModel.Size = New Size(68, 17)
        LbChiperModel.TabIndex = 0
        LbChiperModel.Text = "芯片型号："
        ' 
        ' LbChiperMaker
        ' 
        LbChiperMaker.AutoSize = True
        LbChiperMaker.Location = New Point(6, 24)
        LbChiperMaker.Name = "LbChiperMaker"
        LbChiperMaker.Size = New Size(68, 17)
        LbChiperMaker.TabIndex = 0
        LbChiperMaker.Text = "芯片厂商："
        ' 
        ' GbGoOptions
        ' 
        GbGoOptions.Controls.Add(RbOneGbGo)
        GbGoOptions.Controls.Add(RbTwoGbGo)
        GbGoOptions.Controls.Add(RbNotGo)
        GbGoOptions.Location = New Point(6, 287)
        GbGoOptions.Name = "GbGoOptions"
        GbGoOptions.Size = New Size(803, 54)
        GbGoOptions.TabIndex = 1
        GbGoOptions.TabStop = False
        GbGoOptions.Text = "Go 选项"
        ' 
        ' RbOneGbGo
        ' 
        RbOneGbGo.AutoSize = True
        RbOneGbGo.Location = New Point(373, 22)
        RbOneGbGo.Name = "RbOneGbGo"
        RbOneGbGo.Size = New Size(73, 21)
        RbOneGbGo.TabIndex = 1
        RbOneGbGo.Text = "1GB GO"
        RbOneGbGo.UseVisualStyleBackColor = True
        ' 
        ' RbTwoGbGo
        ' 
        RbTwoGbGo.AutoSize = True
        RbTwoGbGo.Checked = True
        RbTwoGbGo.Location = New Point(703, 22)
        RbTwoGbGo.Name = "RbTwoGbGo"
        RbTwoGbGo.Size = New Size(73, 21)
        RbTwoGbGo.TabIndex = 1
        RbTwoGbGo.TabStop = True
        RbTwoGbGo.Text = "2GB GO"
        RbTwoGbGo.UseVisualStyleBackColor = True
        ' 
        ' RbNotGo
        ' 
        RbNotGo.AutoSize = True
        RbNotGo.Location = New Point(6, 22)
        RbNotGo.Name = "RbNotGo"
        RbNotGo.Size = New Size(61, 21)
        RbNotGo.TabIndex = 0
        RbNotGo.Text = "非 GO"
        RbNotGo.UseVisualStyleBackColor = True
        ' 
        ' GbGmsOptions
        ' 
        GbGmsOptions.Controls.Add(RbNotGms)
        GbGmsOptions.Controls.Add(RbGms)
        GbGmsOptions.Location = New Point(6, 227)
        GbGmsOptions.Name = "GbGmsOptions"
        GbGmsOptions.Size = New Size(803, 54)
        GbGmsOptions.TabIndex = 1
        GbGmsOptions.TabStop = False
        GbGmsOptions.Text = "GMS 选项"
        ' 
        ' RbNotGms
        ' 
        RbNotGms.AutoSize = True
        RbNotGms.Location = New Point(6, 22)
        RbNotGms.Name = "RbNotGms"
        RbNotGms.Size = New Size(70, 21)
        RbNotGms.TabIndex = 1
        RbNotGms.Text = "非 GMS"
        RbNotGms.UseVisualStyleBackColor = True
        ' 
        ' RbGms
        ' 
        RbGms.AutoSize = True
        RbGms.Checked = True
        RbGms.Location = New Point(373, 22)
        RbGms.Name = "RbGms"
        RbGms.Size = New Size(54, 21)
        RbGms.TabIndex = 0
        RbGms.TabStop = True
        RbGms.Text = "GMS"
        RbGms.UseVisualStyleBackColor = True
        ' 
        ' GBProject
        ' 
        GBProject.Controls.Add(CbProjectPath)
        GBProject.Controls.Add(TbCustomName)
        GBProject.Controls.Add(TbMssiName)
        GBProject.Controls.Add(TbDriveName)
        GBProject.Controls.Add(TbPublicName)
        GBProject.Controls.Add(CbAndroidVersin)
        GBProject.Controls.Add(LbAndroidVersion)
        GBProject.Controls.Add(Label4)
        GBProject.Controls.Add(LbDriveName)
        GBProject.Controls.Add(LbMssiName)
        GBProject.Controls.Add(LbPublicName)
        GBProject.Controls.Add(BtSelectProjectPath)
        GBProject.Controls.Add(LbProjectPath)
        GBProject.Controls.Add(CBProjectId)
        GBProject.Controls.Add(LbProjectId)
        GBProject.Location = New Point(6, 6)
        GBProject.Name = "GBProject"
        GBProject.Size = New Size(803, 215)
        GBProject.TabIndex = 0
        GBProject.TabStop = False
        GBProject.Text = "项目信息选项"
        ' 
        ' CbProjectPath
        ' 
        CbProjectPath.FormattingEnabled = True
        CbProjectPath.Location = New Point(104, 98)
        CbProjectPath.Name = "CbProjectPath"
        CbProjectPath.Size = New Size(612, 25)
        CbProjectPath.TabIndex = 16
        ' 
        ' TbCustomName
        ' 
        TbCustomName.Location = New Point(513, 173)
        TbCustomName.Name = "TbCustomName"
        TbCustomName.Size = New Size(284, 23)
        TbCustomName.TabIndex = 15
        ' 
        ' TbMssiName
        ' 
        TbMssiName.Location = New Point(513, 137)
        TbMssiName.Name = "TbMssiName"
        TbMssiName.Size = New Size(284, 23)
        TbMssiName.TabIndex = 15
        ' 
        ' TbDriveName
        ' 
        TbDriveName.Location = New Point(104, 173)
        TbDriveName.Name = "TbDriveName"
        TbDriveName.Size = New Size(293, 23)
        TbDriveName.TabIndex = 15
        ' 
        ' TbPublicName
        ' 
        TbPublicName.Location = New Point(104, 137)
        TbPublicName.Name = "TbPublicName"
        TbPublicName.Size = New Size(293, 23)
        TbPublicName.TabIndex = 15
        ' 
        ' CbAndroidVersin
        ' 
        CbAndroidVersin.FormattingEnabled = True
        CbAndroidVersin.Items.AddRange(New Object() {"Android 11", "Android 12", "Android 13"})
        CbAndroidVersin.Location = New Point(104, 62)
        CbAndroidVersin.Name = "CbAndroidVersin"
        CbAndroidVersin.Size = New Size(293, 25)
        CbAndroidVersin.TabIndex = 14
        CbAndroidVersin.Text = "Android 13"
        ' 
        ' LbAndroidVersion
        ' 
        LbAndroidVersion.AutoSize = True
        LbAndroidVersion.Location = New Point(6, 65)
        LbAndroidVersion.Name = "LbAndroidVersion"
        LbAndroidVersion.Size = New Size(95, 17)
        LbAndroidVersion.TabIndex = 13
        LbAndroidVersion.Text = "Android 版本："
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(403, 176)
        Label4.Name = "Label4"
        Label4.Size = New Size(104, 17)
        Label4.TabIndex = 11
        Label4.Text = "客制化目录名称："
        ' 
        ' LbDriveName
        ' 
        LbDriveName.AutoSize = True
        LbDriveName.Location = New Point(6, 176)
        LbDriveName.Name = "LbDriveName"
        LbDriveName.Size = New Size(92, 17)
        LbDriveName.TabIndex = 9
        LbDriveName.Text = "驱动目录名称："
        ' 
        ' LbMssiName
        ' 
        LbMssiName.AutoSize = True
        LbMssiName.Location = New Point(403, 142)
        LbMssiName.Name = "LbMssiName"
        LbMssiName.Size = New Size(75, 17)
        LbMssiName.TabIndex = 7
        LbMssiName.Text = "Mssi 名称："
        ' 
        ' LbPublicName
        ' 
        LbPublicName.AutoSize = True
        LbPublicName.Location = New Point(6, 140)
        LbPublicName.Name = "LbPublicName"
        LbPublicName.Size = New Size(68, 17)
        LbPublicName.TabIndex = 5
        LbPublicName.Text = "公版名称："
        ' 
        ' BtSelectProjectPath
        ' 
        BtSelectProjectPath.Location = New Point(722, 98)
        BtSelectProjectPath.Name = "BtSelectProjectPath"
        BtSelectProjectPath.Size = New Size(75, 23)
        BtSelectProjectPath.TabIndex = 4
        BtSelectProjectPath.Text = "选择..."
        BtSelectProjectPath.UseVisualStyleBackColor = True
        ' 
        ' LbProjectPath
        ' 
        LbProjectPath.AutoSize = True
        LbProjectPath.Location = New Point(6, 101)
        LbProjectPath.Name = "LbProjectPath"
        LbProjectPath.Size = New Size(68, 17)
        LbProjectPath.TabIndex = 2
        LbProjectPath.Text = "工程路径："
        ' 
        ' CBProjectId
        ' 
        CBProjectId.FormattingEnabled = True
        CBProjectId.Location = New Point(104, 26)
        CBProjectId.Name = "CBProjectId"
        CBProjectId.Size = New Size(293, 25)
        CBProjectId.TabIndex = 1
        ' 
        ' LbProjectId
        ' 
        LbProjectId.AutoSize = True
        LbProjectId.Location = New Point(6, 29)
        LbProjectId.Name = "LbProjectId"
        LbProjectId.Size = New Size(56, 17)
        LbProjectId.TabIndex = 0
        LbProjectId.Text = "禅道号："
        ' 
        ' tpProperty
        ' 
        tpProperty.Controls.Add(lbProductManufacturerState)
        tpProperty.Controls.Add(lbProductDeviceState)
        tpProperty.Controls.Add(lbProductBrandState)
        tpProperty.Controls.Add(lbProductModelState)
        tpProperty.Controls.Add(lbProductNameState)
        tpProperty.Controls.Add(btPropertySetting)
        tpProperty.Controls.Add(tbProductManufacturer)
        tpProperty.Controls.Add(lbProductManufacturer)
        tpProperty.Controls.Add(tbProductDevice)
        tpProperty.Controls.Add(lbProductDevice)
        tpProperty.Controls.Add(tbProductBrand)
        tpProperty.Controls.Add(lbProductBrand)
        tpProperty.Controls.Add(tbProductModel)
        tpProperty.Controls.Add(lbProductModel)
        tpProperty.Controls.Add(tbProductName)
        tpProperty.Controls.Add(lbProductName)
        tpProperty.Location = New Point(4, 48)
        tpProperty.Name = "tpProperty"
        tpProperty.Size = New Size(815, 449)
        tpProperty.TabIndex = 3
        tpProperty.Text = "系统属性"
        tpProperty.UseVisualStyleBackColor = True
        ' 
        ' lbProductManufacturerState
        ' 
        lbProductManufacturerState.AutoSize = True
        lbProductManufacturerState.Location = New Point(756, 158)
        lbProductManufacturerState.Name = "lbProductManufacturerState"
        lbProductManufacturerState.Size = New Size(37, 17)
        lbProductManufacturerState.TabIndex = 3
        lbProductManufacturerState.Text = "PASS"
        ' 
        ' lbProductDeviceState
        ' 
        lbProductDeviceState.AutoSize = True
        lbProductDeviceState.Location = New Point(756, 123)
        lbProductDeviceState.Name = "lbProductDeviceState"
        lbProductDeviceState.Size = New Size(37, 17)
        lbProductDeviceState.TabIndex = 3
        lbProductDeviceState.Text = "PASS"
        ' 
        ' lbProductBrandState
        ' 
        lbProductBrandState.AutoSize = True
        lbProductBrandState.Location = New Point(756, 88)
        lbProductBrandState.Name = "lbProductBrandState"
        lbProductBrandState.Size = New Size(37, 17)
        lbProductBrandState.TabIndex = 3
        lbProductBrandState.Text = "PASS"
        ' 
        ' lbProductModelState
        ' 
        lbProductModelState.AutoSize = True
        lbProductModelState.Location = New Point(756, 51)
        lbProductModelState.Name = "lbProductModelState"
        lbProductModelState.Size = New Size(37, 17)
        lbProductModelState.TabIndex = 3
        lbProductModelState.Text = "PASS"
        ' 
        ' lbProductNameState
        ' 
        lbProductNameState.AutoSize = True
        lbProductNameState.Location = New Point(756, 15)
        lbProductNameState.Name = "lbProductNameState"
        lbProductNameState.Size = New Size(37, 17)
        lbProductNameState.TabIndex = 3
        lbProductNameState.Text = "PASS"
        ' 
        ' btPropertySetting
        ' 
        btPropertySetting.Location = New Point(13, 211)
        btPropertySetting.Name = "btPropertySetting"
        btPropertySetting.Size = New Size(75, 23)
        btPropertySetting.TabIndex = 2
        btPropertySetting.Text = "设置"
        btPropertySetting.UseVisualStyleBackColor = True
        ' 
        ' tbProductManufacturer
        ' 
        tbProductManufacturer.Location = New Point(257, 158)
        tbProductManufacturer.Name = "tbProductManufacturer"
        tbProductManufacturer.Size = New Size(493, 23)
        tbProductManufacturer.TabIndex = 1
        ' 
        ' lbProductManufacturer
        ' 
        lbProductManufacturer.AutoSize = True
        lbProductManufacturer.Location = New Point(13, 158)
        lbProductManufacturer.Name = "lbProductManufacturer"
        lbProductManufacturer.Size = New Size(238, 17)
        lbProductManufacturer.TabIndex = 0
        lbProductManufacturer.Text = "设备制造商（ro.product.manufacturer)："
        ' 
        ' tbProductDevice
        ' 
        tbProductDevice.Location = New Point(257, 120)
        tbProductDevice.Name = "tbProductDevice"
        tbProductDevice.Size = New Size(493, 23)
        tbProductDevice.TabIndex = 1
        ' 
        ' lbProductDevice
        ' 
        lbProductDevice.AutoSize = True
        lbProductDevice.Location = New Point(13, 123)
        lbProductDevice.Name = "lbProductDevice"
        lbProductDevice.Size = New Size(186, 17)
        lbProductDevice.TabIndex = 0
        lbProductDevice.Text = "设备名称（ro.product.device)："
        ' 
        ' tbProductBrand
        ' 
        tbProductBrand.Location = New Point(257, 85)
        tbProductBrand.Name = "tbProductBrand"
        tbProductBrand.Size = New Size(493, 23)
        tbProductBrand.TabIndex = 1
        ' 
        ' lbProductBrand
        ' 
        lbProductBrand.AutoSize = True
        lbProductBrand.Location = New Point(13, 88)
        lbProductBrand.Name = "lbProductBrand"
        lbProductBrand.Size = New Size(184, 17)
        lbProductBrand.TabIndex = 0
        lbProductBrand.Text = "设备品牌（ro.product.brand)："
        ' 
        ' tbProductModel
        ' 
        tbProductModel.Location = New Point(257, 48)
        tbProductModel.Name = "tbProductModel"
        tbProductModel.Size = New Size(493, 23)
        tbProductModel.TabIndex = 1
        ' 
        ' lbProductModel
        ' 
        lbProductModel.AutoSize = True
        lbProductModel.Location = New Point(13, 51)
        lbProductModel.Name = "lbProductModel"
        lbProductModel.Size = New Size(186, 17)
        lbProductModel.TabIndex = 0
        lbProductModel.Text = "产品型号（ro.product.model)："
        ' 
        ' tbProductName
        ' 
        tbProductName.Location = New Point(257, 12)
        tbProductName.Name = "tbProductName"
        tbProductName.Size = New Size(493, 23)
        tbProductName.TabIndex = 1
        ' 
        ' lbProductName
        ' 
        lbProductName.AutoSize = True
        lbProductName.Location = New Point(13, 15)
        lbProductName.Name = "lbProductName"
        lbProductName.Size = New Size(181, 17)
        lbProductName.TabIndex = 0
        lbProductName.Text = "产品名称（ro.product.name)："
        ' 
        ' tpVersion
        ' 
        tpVersion.Controls.Add(lbVersionState)
        tpVersion.Controls.Add(btVersion)
        tpVersion.Controls.Add(tbVersion)
        tpVersion.Controls.Add(lbVersion)
        tpVersion.Font = New Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        tpVersion.Location = New Point(4, 48)
        tpVersion.Name = "tpVersion"
        tpVersion.Padding = New Padding(3)
        tpVersion.Size = New Size(815, 449)
        tpVersion.TabIndex = 1
        tpVersion.Text = "版本号"
        tpVersion.UseVisualStyleBackColor = True
        ' 
        ' lbVersionState
        ' 
        lbVersionState.AutoSize = True
        lbVersionState.BackColor = Color.Transparent
        lbVersionState.Font = New Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        lbVersionState.ForeColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        lbVersionState.Location = New Point(772, 41)
        lbVersionState.Name = "lbVersionState"
        lbVersionState.Size = New Size(37, 17)
        lbVersionState.TabIndex = 3
        lbVersionState.Text = "PASS"
        lbVersionState.Visible = False
        ' 
        ' btVersion
        ' 
        btVersion.Location = New Point(6, 75)
        btVersion.Name = "btVersion"
        btVersion.Size = New Size(75, 23)
        btVersion.TabIndex = 2
        btVersion.Text = "设置"
        btVersion.UseVisualStyleBackColor = True
        ' 
        ' tbVersion
        ' 
        tbVersion.Location = New Point(6, 33)
        tbVersion.Name = "tbVersion"
        tbVersion.Size = New Size(760, 23)
        tbVersion.TabIndex = 1
        ' 
        ' lbVersion
        ' 
        lbVersion.AutoSize = True
        lbVersion.Location = New Point(6, 13)
        lbVersion.Name = "lbVersion"
        lbVersion.Size = New Size(355, 17)
        lbVersion.TabIndex = 0
        lbVersion.Text = "版本号：（例如：UMIDIGI_G3 Tab_V1.0_`date +%Y%m%d`）"
        ' 
        ' tpFingerprint
        ' 
        tpFingerprint.Controls.Add(btFingerprintSet)
        tpFingerprint.Controls.Add(btRandom)
        tpFingerprint.Controls.Add(lbFingerprintState)
        tpFingerprint.Controls.Add(tbFingerprint)
        tpFingerprint.Controls.Add(lbFingerprint)
        tpFingerprint.Location = New Point(4, 48)
        tpFingerprint.Name = "tpFingerprint"
        tpFingerprint.Size = New Size(815, 449)
        tpFingerprint.TabIndex = 2
        tpFingerprint.Text = "Fingerprint"
        tpFingerprint.UseVisualStyleBackColor = True
        ' 
        ' btFingerprintSet
        ' 
        btFingerprintSet.Location = New Point(6, 76)
        btFingerprintSet.Name = "btFingerprintSet"
        btFingerprintSet.Size = New Size(75, 23)
        btFingerprintSet.TabIndex = 4
        btFingerprintSet.Text = "设置"
        btFingerprintSet.UseVisualStyleBackColor = True
        ' 
        ' btRandom
        ' 
        btRandom.Location = New Point(685, 35)
        btRandom.Name = "btRandom"
        btRandom.Size = New Size(75, 23)
        btRandom.TabIndex = 3
        btRandom.Text = "随机生成"
        btRandom.UseVisualStyleBackColor = True
        ' 
        ' lbFingerprintState
        ' 
        lbFingerprintState.AutoSize = True
        lbFingerprintState.ForeColor = Color.Green
        lbFingerprintState.Location = New Point(766, 38)
        lbFingerprintState.Name = "lbFingerprintState"
        lbFingerprintState.Size = New Size(37, 17)
        lbFingerprintState.TabIndex = 2
        lbFingerprintState.Text = "PASS"
        ' 
        ' tbFingerprint
        ' 
        tbFingerprint.Location = New Point(6, 35)
        tbFingerprint.Name = "tbFingerprint"
        tbFingerprint.Size = New Size(673, 23)
        tbFingerprint.TabIndex = 1
        ' 
        ' lbFingerprint
        ' 
        lbFingerprint.AutoSize = True
        lbFingerprint.Location = New Point(6, 13)
        lbFingerprint.Name = "lbFingerprint"
        lbFingerprint.Size = New Size(83, 17)
        lbFingerprint.TabIndex = 0
        lbFingerprint.Text = "Fingerprint："
        ' 
        ' tpWifi
        ' 
        tpWifi.Controls.Add(btWifiSetting)
        tpWifi.Controls.Add(lbWifiScreenCastState)
        tpWifi.Controls.Add(lbWifiHotspotNameState)
        tpWifi.Controls.Add(lbWifiStatusState)
        tpWifi.Controls.Add(tbWifiScreenCast)
        tpWifi.Controls.Add(tbWifiHotspotName)
        tpWifi.Controls.Add(lbWifiScreenCast)
        tpWifi.Controls.Add(lbWifiHotspotName)
        tpWifi.Controls.Add(rbWifiClose)
        tpWifi.Controls.Add(rbWifiOpen)
        tpWifi.Controls.Add(lbWifiStatus)
        tpWifi.Location = New Point(4, 48)
        tpWifi.Name = "tpWifi"
        tpWifi.Size = New Size(815, 449)
        tpWifi.TabIndex = 4
        tpWifi.Text = "WiFi"
        tpWifi.UseVisualStyleBackColor = True
        ' 
        ' btWifiSetting
        ' 
        btWifiSetting.Location = New Point(14, 149)
        btWifiSetting.Name = "btWifiSetting"
        btWifiSetting.Size = New Size(75, 23)
        btWifiSetting.TabIndex = 5
        btWifiSetting.Text = "设置"
        btWifiSetting.UseVisualStyleBackColor = True
        ' 
        ' lbWifiScreenCastState
        ' 
        lbWifiScreenCastState.AutoSize = True
        lbWifiScreenCastState.Location = New Point(757, 100)
        lbWifiScreenCastState.Name = "lbWifiScreenCastState"
        lbWifiScreenCastState.Size = New Size(37, 17)
        lbWifiScreenCastState.TabIndex = 4
        lbWifiScreenCastState.Text = "PASS"
        ' 
        ' lbWifiHotspotNameState
        ' 
        lbWifiHotspotNameState.AutoSize = True
        lbWifiHotspotNameState.Location = New Point(757, 59)
        lbWifiHotspotNameState.Name = "lbWifiHotspotNameState"
        lbWifiHotspotNameState.Size = New Size(37, 17)
        lbWifiHotspotNameState.TabIndex = 4
        lbWifiHotspotNameState.Text = "PASS"
        ' 
        ' lbWifiStatusState
        ' 
        lbWifiStatusState.AutoSize = True
        lbWifiStatusState.Location = New Point(757, 22)
        lbWifiStatusState.Name = "lbWifiStatusState"
        lbWifiStatusState.Size = New Size(37, 17)
        lbWifiStatusState.TabIndex = 4
        lbWifiStatusState.Text = "PASS"
        ' 
        ' tbWifiScreenCast
        ' 
        tbWifiScreenCast.Location = New Point(116, 97)
        tbWifiScreenCast.Name = "tbWifiScreenCast"
        tbWifiScreenCast.Size = New Size(619, 23)
        tbWifiScreenCast.TabIndex = 3
        ' 
        ' tbWifiHotspotName
        ' 
        tbWifiHotspotName.Location = New Point(116, 56)
        tbWifiHotspotName.Name = "tbWifiHotspotName"
        tbWifiHotspotName.Size = New Size(619, 23)
        tbWifiHotspotName.TabIndex = 3
        ' 
        ' lbWifiScreenCast
        ' 
        lbWifiScreenCast.AutoSize = True
        lbWifiScreenCast.Location = New Point(14, 100)
        lbWifiScreenCast.Name = "lbWifiScreenCast"
        lbWifiScreenCast.Size = New Size(96, 17)
        lbWifiScreenCast.TabIndex = 2
        lbWifiScreenCast.Text = "WiFi 投屏名称："
        ' 
        ' lbWifiHotspotName
        ' 
        lbWifiHotspotName.AutoSize = True
        lbWifiHotspotName.Location = New Point(14, 59)
        lbWifiHotspotName.Name = "lbWifiHotspotName"
        lbWifiHotspotName.Size = New Size(96, 17)
        lbWifiHotspotName.TabIndex = 2
        lbWifiHotspotName.Text = "WiFi 热点名称："
        ' 
        ' rbWifiClose
        ' 
        rbWifiClose.AutoSize = True
        rbWifiClose.Checked = True
        rbWifiClose.Location = New Point(204, 18)
        rbWifiClose.Name = "rbWifiClose"
        rbWifiClose.Size = New Size(50, 21)
        rbWifiClose.TabIndex = 1
        rbWifiClose.TabStop = True
        rbWifiClose.Text = "关闭"
        rbWifiClose.UseVisualStyleBackColor = True
        ' 
        ' rbWifiOpen
        ' 
        rbWifiOpen.AutoSize = True
        rbWifiOpen.Location = New Point(116, 18)
        rbWifiOpen.Name = "rbWifiOpen"
        rbWifiOpen.Size = New Size(50, 21)
        rbWifiOpen.TabIndex = 1
        rbWifiOpen.TabStop = True
        rbWifiOpen.Text = "打开"
        rbWifiOpen.UseVisualStyleBackColor = True
        ' 
        ' lbWifiStatus
        ' 
        lbWifiStatus.AutoSize = True
        lbWifiStatus.Location = New Point(14, 20)
        lbWifiStatus.Name = "lbWifiStatus"
        lbWifiStatus.Size = New Size(96, 17)
        lbWifiStatus.TabIndex = 0
        lbWifiStatus.Text = "WiFi 默认状态："
        ' 
        ' tpBluetooth
        ' 
        tpBluetooth.Controls.Add(btBluetoothSetting)
        tpBluetooth.Controls.Add(tbBluetoothName)
        tpBluetooth.Controls.Add(rbBluetoothClose)
        tpBluetooth.Controls.Add(rbBluetoothOpen)
        tpBluetooth.Controls.Add(lbBluetoothNameState)
        tpBluetooth.Controls.Add(lbBluetoothName)
        tpBluetooth.Controls.Add(lbBluetoothStatusState)
        tpBluetooth.Controls.Add(lbBluetoothStatus)
        tpBluetooth.Location = New Point(4, 48)
        tpBluetooth.Name = "tpBluetooth"
        tpBluetooth.Size = New Size(815, 449)
        tpBluetooth.TabIndex = 5
        tpBluetooth.Text = "蓝牙"
        tpBluetooth.UseVisualStyleBackColor = True
        ' 
        ' btBluetoothSetting
        ' 
        btBluetoothSetting.Location = New Point(20, 111)
        btBluetoothSetting.Name = "btBluetoothSetting"
        btBluetoothSetting.Size = New Size(75, 23)
        btBluetoothSetting.TabIndex = 3
        btBluetoothSetting.Text = "设置"
        btBluetoothSetting.UseVisualStyleBackColor = True
        ' 
        ' tbBluetoothName
        ' 
        tbBluetoothName.Location = New Point(94, 59)
        tbBluetoothName.Name = "tbBluetoothName"
        tbBluetoothName.Size = New Size(644, 23)
        tbBluetoothName.TabIndex = 2
        ' 
        ' rbBluetoothClose
        ' 
        rbBluetoothClose.AutoSize = True
        rbBluetoothClose.Checked = True
        rbBluetoothClose.Location = New Point(243, 21)
        rbBluetoothClose.Name = "rbBluetoothClose"
        rbBluetoothClose.Size = New Size(50, 21)
        rbBluetoothClose.TabIndex = 1
        rbBluetoothClose.TabStop = True
        rbBluetoothClose.Text = "关闭"
        rbBluetoothClose.UseVisualStyleBackColor = True
        ' 
        ' rbBluetoothOpen
        ' 
        rbBluetoothOpen.AutoSize = True
        rbBluetoothOpen.Location = New Point(118, 21)
        rbBluetoothOpen.Name = "rbBluetoothOpen"
        rbBluetoothOpen.Size = New Size(50, 21)
        rbBluetoothOpen.TabIndex = 1
        rbBluetoothOpen.Text = "打开"
        rbBluetoothOpen.UseVisualStyleBackColor = True
        ' 
        ' lbBluetoothNameState
        ' 
        lbBluetoothNameState.AutoSize = True
        lbBluetoothNameState.Location = New Point(759, 62)
        lbBluetoothNameState.Name = "lbBluetoothNameState"
        lbBluetoothNameState.Size = New Size(37, 17)
        lbBluetoothNameState.TabIndex = 0
        lbBluetoothNameState.Text = "PASS"
        ' 
        ' lbBluetoothName
        ' 
        lbBluetoothName.AutoSize = True
        lbBluetoothName.Location = New Point(20, 65)
        lbBluetoothName.Name = "lbBluetoothName"
        lbBluetoothName.Size = New Size(68, 17)
        lbBluetoothName.TabIndex = 0
        lbBluetoothName.Text = "蓝牙名称："
        ' 
        ' lbBluetoothStatusState
        ' 
        lbBluetoothStatusState.AutoSize = True
        lbBluetoothStatusState.Location = New Point(759, 23)
        lbBluetoothStatusState.Name = "lbBluetoothStatusState"
        lbBluetoothStatusState.Size = New Size(37, 17)
        lbBluetoothStatusState.TabIndex = 0
        lbBluetoothStatusState.Text = "PASS"
        ' 
        ' lbBluetoothStatus
        ' 
        lbBluetoothStatus.AutoSize = True
        lbBluetoothStatus.Location = New Point(20, 23)
        lbBluetoothStatus.Name = "lbBluetoothStatus"
        lbBluetoothStatus.Size = New Size(92, 17)
        lbBluetoothStatus.TabIndex = 0
        lbBluetoothStatus.Text = "蓝牙默认状态："
        ' 
        ' tpLanguage
        ' 
        tpLanguage.Controls.Add(btLanguageSetting)
        tpLanguage.Controls.Add(cbLanguage)
        tpLanguage.Controls.Add(lbLanguageState)
        tpLanguage.Controls.Add(Label1)
        tpLanguage.Location = New Point(4, 48)
        tpLanguage.Name = "tpLanguage"
        tpLanguage.Size = New Size(815, 449)
        tpLanguage.TabIndex = 6
        tpLanguage.Text = "语言"
        tpLanguage.UseVisualStyleBackColor = True
        ' 
        ' btLanguageSetting
        ' 
        btLanguageSetting.Location = New Point(13, 67)
        btLanguageSetting.Name = "btLanguageSetting"
        btLanguageSetting.Size = New Size(75, 23)
        btLanguageSetting.TabIndex = 4
        btLanguageSetting.Text = "设置"
        btLanguageSetting.UseVisualStyleBackColor = True
        ' 
        ' cbLanguage
        ' 
        cbLanguage.FormattingEnabled = True
        cbLanguage.Location = New Point(63, 16)
        cbLanguage.Name = "cbLanguage"
        cbLanguage.Size = New Size(667, 25)
        cbLanguage.TabIndex = 2
        ' 
        ' lbLanguageState
        ' 
        lbLanguageState.AutoSize = True
        lbLanguageState.Location = New Point(752, 19)
        lbLanguageState.Name = "lbLanguageState"
        lbLanguageState.Size = New Size(37, 17)
        lbLanguageState.TabIndex = 0
        lbLanguageState.Text = "PASS"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(13, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(44, 17)
        Label1.TabIndex = 0
        Label1.Text = "语言："
        ' 
        ' tpTimezone
        ' 
        tpTimezone.Controls.Add(rbTimezoneClose)
        tpTimezone.Controls.Add(rbTimezoneOpen)
        tpTimezone.Controls.Add(lbAutoTimezone)
        tpTimezone.Controls.Add(cbTimezone)
        tpTimezone.Controls.Add(lbAutoTimezoneState)
        tpTimezone.Controls.Add(lbTimezoneState)
        tpTimezone.Controls.Add(lbTimezone)
        tpTimezone.Controls.Add(btTimezoneSetting)
        tpTimezone.Location = New Point(4, 48)
        tpTimezone.Name = "tpTimezone"
        tpTimezone.Size = New Size(815, 449)
        tpTimezone.TabIndex = 7
        tpTimezone.Text = "时区"
        tpTimezone.UseVisualStyleBackColor = True
        ' 
        ' rbTimezoneClose
        ' 
        rbTimezoneClose.AutoSize = True
        rbTimezoneClose.Location = New Point(220, 16)
        rbTimezoneClose.Name = "rbTimezoneClose"
        rbTimezoneClose.Size = New Size(50, 21)
        rbTimezoneClose.TabIndex = 10
        rbTimezoneClose.TabStop = True
        rbTimezoneClose.Text = "关闭"
        rbTimezoneClose.UseVisualStyleBackColor = True
        ' 
        ' rbTimezoneOpen
        ' 
        rbTimezoneOpen.AutoSize = True
        rbTimezoneOpen.Location = New Point(109, 16)
        rbTimezoneOpen.Name = "rbTimezoneOpen"
        rbTimezoneOpen.Size = New Size(50, 21)
        rbTimezoneOpen.TabIndex = 10
        rbTimezoneOpen.TabStop = True
        rbTimezoneOpen.Text = "开启"
        rbTimezoneOpen.UseVisualStyleBackColor = True
        ' 
        ' lbAutoTimezone
        ' 
        lbAutoTimezone.AutoSize = True
        lbAutoTimezone.Location = New Point(11, 18)
        lbAutoTimezone.Name = "lbAutoTimezone"
        lbAutoTimezone.Size = New Size(92, 17)
        lbAutoTimezone.TabIndex = 9
        lbAutoTimezone.Text = "自动更新时区："
        ' 
        ' cbTimezone
        ' 
        cbTimezone.FormattingEnabled = True
        cbTimezone.Location = New Point(61, 54)
        cbTimezone.Name = "cbTimezone"
        cbTimezone.Size = New Size(667, 25)
        cbTimezone.TabIndex = 8
        ' 
        ' lbAutoTimezoneState
        ' 
        lbAutoTimezoneState.AutoSize = True
        lbAutoTimezoneState.Location = New Point(750, 20)
        lbAutoTimezoneState.Name = "lbAutoTimezoneState"
        lbAutoTimezoneState.Size = New Size(37, 17)
        lbAutoTimezoneState.TabIndex = 6
        lbAutoTimezoneState.Text = "PASS"
        ' 
        ' lbTimezoneState
        ' 
        lbTimezoneState.AutoSize = True
        lbTimezoneState.Location = New Point(750, 57)
        lbTimezoneState.Name = "lbTimezoneState"
        lbTimezoneState.Size = New Size(37, 17)
        lbTimezoneState.TabIndex = 6
        lbTimezoneState.Text = "PASS"
        ' 
        ' lbTimezone
        ' 
        lbTimezone.AutoSize = True
        lbTimezone.Location = New Point(11, 57)
        lbTimezone.Name = "lbTimezone"
        lbTimezone.Size = New Size(44, 17)
        lbTimezone.TabIndex = 7
        lbTimezone.Text = "时区："
        ' 
        ' btTimezoneSetting
        ' 
        btTimezoneSetting.Location = New Point(11, 108)
        btTimezoneSetting.Name = "btTimezoneSetting"
        btTimezoneSetting.Size = New Size(75, 23)
        btTimezoneSetting.TabIndex = 5
        btTimezoneSetting.Text = "设置"
        btTimezoneSetting.UseVisualStyleBackColor = True
        ' 
        ' tpLogo
        ' 
        tpLogo.Controls.Add(btLogoSetting)
        tpLogo.Controls.Add(bLogo)
        tpLogo.Controls.Add(tbLogo)
        tpLogo.Controls.Add(lbLogoState)
        tpLogo.Controls.Add(lbLogo)
        tpLogo.Location = New Point(4, 48)
        tpLogo.Name = "tpLogo"
        tpLogo.Size = New Size(815, 449)
        tpLogo.TabIndex = 8
        tpLogo.Text = "LOGO"
        tpLogo.UseVisualStyleBackColor = True
        ' 
        ' btLogoSetting
        ' 
        btLogoSetting.Location = New Point(18, 65)
        btLogoSetting.Name = "btLogoSetting"
        btLogoSetting.Size = New Size(75, 23)
        btLogoSetting.TabIndex = 2
        btLogoSetting.Text = "设置"
        btLogoSetting.UseVisualStyleBackColor = True
        ' 
        ' bLogo
        ' 
        bLogo.Location = New Point(654, 17)
        bLogo.Name = "bLogo"
        bLogo.Size = New Size(75, 23)
        bLogo.TabIndex = 2
        bLogo.Text = "选择图片"
        bLogo.UseVisualStyleBackColor = True
        ' 
        ' tbLogo
        ' 
        tbLogo.Location = New Point(102, 17)
        tbLogo.Name = "tbLogo"
        tbLogo.Size = New Size(546, 23)
        tbLogo.TabIndex = 1
        ' 
        ' lbLogoState
        ' 
        lbLogoState.AutoSize = True
        lbLogoState.Location = New Point(753, 20)
        lbLogoState.Name = "lbLogoState"
        lbLogoState.Size = New Size(37, 17)
        lbLogoState.TabIndex = 0
        lbLogoState.Text = "PASS"
        ' 
        ' lbLogo
        ' 
        lbLogo.AutoSize = True
        lbLogo.Location = New Point(18, 20)
        lbLogo.Name = "lbLogo"
        lbLogo.Size = New Size(78, 17)
        lbLogo.TabIndex = 0
        lbLogo.Text = "Logo 图片："
        ' 
        ' tpWallpaper
        ' 
        tpWallpaper.Controls.Add(btWallpaperSetting)
        tpWallpaper.Controls.Add(btInserWallpaper)
        tpWallpaper.Controls.Add(btWallpaper)
        tpWallpaper.Controls.Add(tbInsertWallpaper)
        tpWallpaper.Controls.Add(lbInsertWallpaperState)
        tpWallpaper.Controls.Add(tbWallpaper)
        tpWallpaper.Controls.Add(lbInsertWallpaper)
        tpWallpaper.Controls.Add(lbWallpaperState)
        tpWallpaper.Controls.Add(lbWallpaper)
        tpWallpaper.Location = New Point(4, 48)
        tpWallpaper.Name = "tpWallpaper"
        tpWallpaper.Size = New Size(815, 449)
        tpWallpaper.TabIndex = 9
        tpWallpaper.Text = "壁纸"
        tpWallpaper.UseVisualStyleBackColor = True
        ' 
        ' btWallpaperSetting
        ' 
        btWallpaperSetting.Location = New Point(17, 103)
        btWallpaperSetting.Name = "btWallpaperSetting"
        btWallpaperSetting.Size = New Size(75, 23)
        btWallpaperSetting.TabIndex = 6
        btWallpaperSetting.Text = "设置"
        btWallpaperSetting.UseVisualStyleBackColor = True
        ' 
        ' btInserWallpaper
        ' 
        btInserWallpaper.Location = New Point(647, 53)
        btInserWallpaper.Name = "btInserWallpaper"
        btInserWallpaper.Size = New Size(81, 23)
        btInserWallpaper.TabIndex = 7
        btInserWallpaper.Text = "选择内置壁纸"
        btInserWallpaper.UseVisualStyleBackColor = True
        ' 
        ' btWallpaper
        ' 
        btWallpaper.Location = New Point(647, 14)
        btWallpaper.Name = "btWallpaper"
        btWallpaper.Size = New Size(81, 23)
        btWallpaper.TabIndex = 7
        btWallpaper.Text = "选择图片"
        btWallpaper.UseVisualStyleBackColor = True
        ' 
        ' tbInsertWallpaper
        ' 
        tbInsertWallpaper.Location = New Point(101, 53)
        tbInsertWallpaper.Name = "tbInsertWallpaper"
        tbInsertWallpaper.Size = New Size(540, 23)
        tbInsertWallpaper.TabIndex = 5
        ' 
        ' lbInsertWallpaperState
        ' 
        lbInsertWallpaperState.AutoSize = True
        lbInsertWallpaperState.Location = New Point(752, 56)
        lbInsertWallpaperState.Name = "lbInsertWallpaperState"
        lbInsertWallpaperState.Size = New Size(37, 17)
        lbInsertWallpaperState.TabIndex = 3
        lbInsertWallpaperState.Text = "PASS"
        ' 
        ' tbWallpaper
        ' 
        tbWallpaper.Location = New Point(101, 14)
        tbWallpaper.Name = "tbWallpaper"
        tbWallpaper.Size = New Size(540, 23)
        tbWallpaper.TabIndex = 5
        ' 
        ' lbInsertWallpaper
        ' 
        lbInsertWallpaper.AutoSize = True
        lbInsertWallpaper.Location = New Point(17, 56)
        lbInsertWallpaper.Name = "lbInsertWallpaper"
        lbInsertWallpaper.Size = New Size(68, 17)
        lbInsertWallpaper.TabIndex = 4
        lbInsertWallpaper.Text = "内置壁纸："
        ' 
        ' lbWallpaperState
        ' 
        lbWallpaperState.AutoSize = True
        lbWallpaperState.Location = New Point(752, 17)
        lbWallpaperState.Name = "lbWallpaperState"
        lbWallpaperState.Size = New Size(37, 17)
        lbWallpaperState.TabIndex = 3
        lbWallpaperState.Text = "PASS"
        ' 
        ' lbWallpaper
        ' 
        lbWallpaper.AutoSize = True
        lbWallpaper.Location = New Point(17, 17)
        lbWallpaper.Name = "lbWallpaper"
        lbWallpaper.Size = New Size(44, 17)
        lbWallpaper.TabIndex = 4
        lbWallpaper.Text = "壁纸："
        ' 
        ' tpSample
        ' 
        tpSample.Controls.Add(btSampleName)
        tpSample.Controls.Add(btSample)
        tpSample.Controls.Add(tbSampleName)
        tpSample.Controls.Add(btSampleSetting)
        tpSample.Controls.Add(rbSampleClose)
        tpSample.Controls.Add(rbSampleOpen)
        tpSample.Controls.Add(Label3)
        tpSample.Controls.Add(lbSampleNameState)
        tpSample.Controls.Add(lbSampleState)
        tpSample.Controls.Add(lbSample)
        tpSample.Location = New Point(4, 48)
        tpSample.Name = "tpSample"
        tpSample.Size = New Size(815, 449)
        tpSample.TabIndex = 10
        tpSample.Text = "送样"
        tpSample.UseVisualStyleBackColor = True
        ' 
        ' btSampleName
        ' 
        btSampleName.Location = New Point(660, 64)
        btSampleName.Name = "btSampleName"
        btSampleName.Size = New Size(75, 23)
        btSampleName.TabIndex = 4
        btSampleName.Text = "设置"
        btSampleName.UseVisualStyleBackColor = True
        ' 
        ' btSample
        ' 
        btSample.Location = New Point(660, 19)
        btSample.Name = "btSample"
        btSample.Size = New Size(75, 23)
        btSample.TabIndex = 4
        btSample.Text = "设置"
        btSample.UseVisualStyleBackColor = True
        ' 
        ' tbSampleName
        ' 
        tbSampleName.Location = New Point(97, 64)
        tbSampleName.Name = "tbSampleName"
        tbSampleName.Size = New Size(549, 23)
        tbSampleName.TabIndex = 3
        ' 
        ' btSampleSetting
        ' 
        btSampleSetting.Location = New Point(23, 119)
        btSampleSetting.Name = "btSampleSetting"
        btSampleSetting.Size = New Size(75, 23)
        btSampleSetting.TabIndex = 2
        btSampleSetting.Text = "全部设置"
        btSampleSetting.UseVisualStyleBackColor = True
        ' 
        ' rbSampleClose
        ' 
        rbSampleClose.AutoSize = True
        rbSampleClose.Checked = True
        rbSampleClose.Location = New Point(205, 20)
        rbSampleClose.Name = "rbSampleClose"
        rbSampleClose.Size = New Size(50, 21)
        rbSampleClose.TabIndex = 1
        rbSampleClose.TabStop = True
        rbSampleClose.Text = "关闭"
        rbSampleClose.UseVisualStyleBackColor = True
        ' 
        ' rbSampleOpen
        ' 
        rbSampleOpen.AutoSize = True
        rbSampleOpen.Location = New Point(97, 20)
        rbSampleOpen.Name = "rbSampleOpen"
        rbSampleOpen.Size = New Size(50, 21)
        rbSampleOpen.TabIndex = 1
        rbSampleOpen.Text = "开启"
        rbSampleOpen.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(23, 67)
        Label3.Name = "Label3"
        Label3.Size = New Size(68, 17)
        Label3.TabIndex = 0
        Label3.Text = "设备名称："
        ' 
        ' lbSampleNameState
        ' 
        lbSampleNameState.AutoSize = True
        lbSampleNameState.Location = New Point(758, 67)
        lbSampleNameState.Name = "lbSampleNameState"
        lbSampleNameState.Size = New Size(37, 17)
        lbSampleNameState.TabIndex = 0
        lbSampleNameState.Text = "PASS"
        ' 
        ' lbSampleState
        ' 
        lbSampleState.AutoSize = True
        lbSampleState.Location = New Point(758, 22)
        lbSampleState.Name = "lbSampleState"
        lbSampleState.Size = New Size(37, 17)
        lbSampleState.TabIndex = 0
        lbSampleState.Text = "PASS"
        ' 
        ' lbSample
        ' 
        lbSample.AutoSize = True
        lbSample.Location = New Point(23, 20)
        lbSample.Name = "lbSample"
        lbSample.Size = New Size(68, 17)
        lbSample.TabIndex = 0
        lbSample.Text = "送样功能："
        ' 
        ' tpScreenBrightness
        ' 
        tpScreenBrightness.Controls.Add(btBrightnessAllSet)
        tpScreenBrightness.Controls.Add(btMinBrightness)
        tpScreenBrightness.Controls.Add(btMaxBrightness)
        tpScreenBrightness.Controls.Add(btDefaultBrightness)
        tpScreenBrightness.Controls.Add(lbMinBrightnessStatus)
        tpScreenBrightness.Controls.Add(lbMaxBrightnessStatus)
        tpScreenBrightness.Controls.Add(lbDefaultBrightnessStatus)
        tpScreenBrightness.Controls.Add(tbMinBrightness)
        tpScreenBrightness.Controls.Add(lbMinBrightness)
        tpScreenBrightness.Controls.Add(tbMaxBrightness)
        tpScreenBrightness.Controls.Add(lbMaxBrightness)
        tpScreenBrightness.Controls.Add(tbDefaultBrightness)
        tpScreenBrightness.Controls.Add(lbDefaultBrightness)
        tpScreenBrightness.Location = New Point(4, 48)
        tpScreenBrightness.Name = "tpScreenBrightness"
        tpScreenBrightness.Size = New Size(815, 449)
        tpScreenBrightness.TabIndex = 11
        tpScreenBrightness.Text = "屏幕亮度"
        tpScreenBrightness.UseVisualStyleBackColor = True
        ' 
        ' btBrightnessAllSet
        ' 
        btBrightnessAllSet.Location = New Point(15, 144)
        btBrightnessAllSet.Name = "btBrightnessAllSet"
        btBrightnessAllSet.Size = New Size(75, 23)
        btBrightnessAllSet.TabIndex = 2
        btBrightnessAllSet.Text = "全部设置"
        btBrightnessAllSet.UseVisualStyleBackColor = True
        ' 
        ' btMinBrightness
        ' 
        btMinBrightness.Location = New Point(657, 92)
        btMinBrightness.Name = "btMinBrightness"
        btMinBrightness.Size = New Size(75, 23)
        btMinBrightness.TabIndex = 2
        btMinBrightness.Text = "设置"
        btMinBrightness.UseVisualStyleBackColor = True
        ' 
        ' btMaxBrightness
        ' 
        btMaxBrightness.Location = New Point(657, 53)
        btMaxBrightness.Name = "btMaxBrightness"
        btMaxBrightness.Size = New Size(75, 23)
        btMaxBrightness.TabIndex = 2
        btMaxBrightness.Text = "设置"
        btMaxBrightness.UseVisualStyleBackColor = True
        ' 
        ' btDefaultBrightness
        ' 
        btDefaultBrightness.Location = New Point(657, 13)
        btDefaultBrightness.Name = "btDefaultBrightness"
        btDefaultBrightness.Size = New Size(75, 23)
        btDefaultBrightness.TabIndex = 2
        btDefaultBrightness.Text = "设置"
        btDefaultBrightness.UseVisualStyleBackColor = True
        ' 
        ' lbMinBrightnessStatus
        ' 
        lbMinBrightnessStatus.AutoSize = True
        lbMinBrightnessStatus.Location = New Point(757, 95)
        lbMinBrightnessStatus.Name = "lbMinBrightnessStatus"
        lbMinBrightnessStatus.Size = New Size(37, 17)
        lbMinBrightnessStatus.TabIndex = 0
        lbMinBrightnessStatus.Text = "PASS"
        ' 
        ' lbMaxBrightnessStatus
        ' 
        lbMaxBrightnessStatus.AutoSize = True
        lbMaxBrightnessStatus.Location = New Point(757, 56)
        lbMaxBrightnessStatus.Name = "lbMaxBrightnessStatus"
        lbMaxBrightnessStatus.Size = New Size(37, 17)
        lbMaxBrightnessStatus.TabIndex = 0
        lbMaxBrightnessStatus.Text = "PASS"
        ' 
        ' lbDefaultBrightnessStatus
        ' 
        lbDefaultBrightnessStatus.AutoSize = True
        lbDefaultBrightnessStatus.Location = New Point(757, 16)
        lbDefaultBrightnessStatus.Name = "lbDefaultBrightnessStatus"
        lbDefaultBrightnessStatus.Size = New Size(37, 17)
        lbDefaultBrightnessStatus.TabIndex = 0
        lbDefaultBrightnessStatus.Text = "PASS"
        ' 
        ' tbMinBrightness
        ' 
        tbMinBrightness.Location = New Point(89, 92)
        tbMinBrightness.Name = "tbMinBrightness"
        tbMinBrightness.Size = New Size(562, 23)
        tbMinBrightness.TabIndex = 1
        ' 
        ' lbMinBrightness
        ' 
        lbMinBrightness.AutoSize = True
        lbMinBrightness.Location = New Point(15, 95)
        lbMinBrightness.Name = "lbMinBrightness"
        lbMinBrightness.Size = New Size(68, 17)
        lbMinBrightness.TabIndex = 0
        lbMinBrightness.Text = "最小亮度："
        ' 
        ' tbMaxBrightness
        ' 
        tbMaxBrightness.Location = New Point(89, 53)
        tbMaxBrightness.Name = "tbMaxBrightness"
        tbMaxBrightness.Size = New Size(562, 23)
        tbMaxBrightness.TabIndex = 1
        ' 
        ' lbMaxBrightness
        ' 
        lbMaxBrightness.AutoSize = True
        lbMaxBrightness.Location = New Point(15, 56)
        lbMaxBrightness.Name = "lbMaxBrightness"
        lbMaxBrightness.Size = New Size(68, 17)
        lbMaxBrightness.TabIndex = 0
        lbMaxBrightness.Text = "最大亮度："
        ' 
        ' tbDefaultBrightness
        ' 
        tbDefaultBrightness.Location = New Point(89, 13)
        tbDefaultBrightness.Name = "tbDefaultBrightness"
        tbDefaultBrightness.Size = New Size(562, 23)
        tbDefaultBrightness.TabIndex = 1
        ' 
        ' lbDefaultBrightness
        ' 
        lbDefaultBrightness.AutoSize = True
        lbDefaultBrightness.Location = New Point(15, 16)
        lbDefaultBrightness.Name = "lbDefaultBrightness"
        lbDefaultBrightness.Size = New Size(68, 17)
        lbDefaultBrightness.TabIndex = 0
        lbDefaultBrightness.Text = "默认亮度："
        ' 
        ' tpVolume
        ' 
        tpVolume.Controls.Add(cbOtherVolume)
        tpVolume.Controls.Add(cbNotifyVolume)
        tpVolume.Controls.Add(cbAlarmVolume)
        tpVolume.Controls.Add(cbMusicVolume)
        tpVolume.Controls.Add(cbRingVolume)
        tpVolume.Controls.Add(cbCallVolume)
        tpVolume.Controls.Add(btVolumeAllSet)
        tpVolume.Controls.Add(btOtherVolume)
        tpVolume.Controls.Add(btNotifyVolume)
        tpVolume.Controls.Add(btAlarmVolume)
        tpVolume.Controls.Add(btMusicVolume)
        tpVolume.Controls.Add(btRingVolume)
        tpVolume.Controls.Add(btCallVolume)
        tpVolume.Controls.Add(lbOtherVolumeStatus)
        tpVolume.Controls.Add(lbNotifyVolumeStatus)
        tpVolume.Controls.Add(lbAlarmVolumeStatus)
        tpVolume.Controls.Add(lbMusicVolumeStatus)
        tpVolume.Controls.Add(lbRingVolumeStatus)
        tpVolume.Controls.Add(lbCallVolumeStatus)
        tpVolume.Controls.Add(lbOtherVolume)
        tpVolume.Controls.Add(lbNotifyVolume)
        tpVolume.Controls.Add(lbAlarmVolume)
        tpVolume.Controls.Add(lbMusicVolume)
        tpVolume.Controls.Add(lbRingVolume)
        tpVolume.Controls.Add(lbCallVolume)
        tpVolume.Location = New Point(4, 48)
        tpVolume.Name = "tpVolume"
        tpVolume.Size = New Size(815, 449)
        tpVolume.TabIndex = 12
        tpVolume.Text = "系统音量"
        tpVolume.UseVisualStyleBackColor = True
        ' 
        ' cbOtherVolume
        ' 
        cbOtherVolume.FormattingEnabled = True
        cbOtherVolume.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"})
        cbOtherVolume.Location = New Point(113, 206)
        cbOtherVolume.Name = "cbOtherVolume"
        cbOtherVolume.Size = New Size(546, 25)
        cbOtherVolume.TabIndex = 3
        ' 
        ' cbNotifyVolume
        ' 
        cbNotifyVolume.FormattingEnabled = True
        cbNotifyVolume.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"})
        cbNotifyVolume.Location = New Point(113, 168)
        cbNotifyVolume.Name = "cbNotifyVolume"
        cbNotifyVolume.Size = New Size(546, 25)
        cbNotifyVolume.TabIndex = 3
        ' 
        ' cbAlarmVolume
        ' 
        cbAlarmVolume.FormattingEnabled = True
        cbAlarmVolume.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"})
        cbAlarmVolume.Location = New Point(113, 132)
        cbAlarmVolume.Name = "cbAlarmVolume"
        cbAlarmVolume.Size = New Size(546, 25)
        cbAlarmVolume.TabIndex = 3
        ' 
        ' cbMusicVolume
        ' 
        cbMusicVolume.FormattingEnabled = True
        cbMusicVolume.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"})
        cbMusicVolume.Location = New Point(113, 95)
        cbMusicVolume.Name = "cbMusicVolume"
        cbMusicVolume.Size = New Size(546, 25)
        cbMusicVolume.TabIndex = 3
        ' 
        ' cbRingVolume
        ' 
        cbRingVolume.FormattingEnabled = True
        cbRingVolume.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"})
        cbRingVolume.Location = New Point(113, 58)
        cbRingVolume.Name = "cbRingVolume"
        cbRingVolume.Size = New Size(546, 25)
        cbRingVolume.TabIndex = 3
        ' 
        ' cbCallVolume
        ' 
        cbCallVolume.FormattingEnabled = True
        cbCallVolume.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7"})
        cbCallVolume.Location = New Point(113, 20)
        cbCallVolume.Name = "cbCallVolume"
        cbCallVolume.Size = New Size(546, 25)
        cbCallVolume.TabIndex = 3
        ' 
        ' btVolumeAllSet
        ' 
        btVolumeAllSet.Location = New Point(15, 263)
        btVolumeAllSet.Name = "btVolumeAllSet"
        btVolumeAllSet.Size = New Size(75, 23)
        btVolumeAllSet.TabIndex = 2
        btVolumeAllSet.Text = "全部设置"
        btVolumeAllSet.UseVisualStyleBackColor = True
        ' 
        ' btOtherVolume
        ' 
        btOtherVolume.Location = New Point(665, 206)
        btOtherVolume.Name = "btOtherVolume"
        btOtherVolume.Size = New Size(75, 23)
        btOtherVolume.TabIndex = 2
        btOtherVolume.Text = "设置"
        btOtherVolume.UseVisualStyleBackColor = True
        ' 
        ' btNotifyVolume
        ' 
        btNotifyVolume.Location = New Point(665, 168)
        btNotifyVolume.Name = "btNotifyVolume"
        btNotifyVolume.Size = New Size(75, 23)
        btNotifyVolume.TabIndex = 2
        btNotifyVolume.Text = "设置"
        btNotifyVolume.UseVisualStyleBackColor = True
        ' 
        ' btAlarmVolume
        ' 
        btAlarmVolume.Location = New Point(665, 132)
        btAlarmVolume.Name = "btAlarmVolume"
        btAlarmVolume.Size = New Size(75, 23)
        btAlarmVolume.TabIndex = 2
        btAlarmVolume.Text = "设置"
        btAlarmVolume.UseVisualStyleBackColor = True
        ' 
        ' btMusicVolume
        ' 
        btMusicVolume.Location = New Point(665, 95)
        btMusicVolume.Name = "btMusicVolume"
        btMusicVolume.Size = New Size(75, 23)
        btMusicVolume.TabIndex = 2
        btMusicVolume.Text = "设置"
        btMusicVolume.UseVisualStyleBackColor = True
        ' 
        ' btRingVolume
        ' 
        btRingVolume.Location = New Point(665, 58)
        btRingVolume.Name = "btRingVolume"
        btRingVolume.Size = New Size(75, 23)
        btRingVolume.TabIndex = 2
        btRingVolume.Text = "设置"
        btRingVolume.UseVisualStyleBackColor = True
        ' 
        ' btCallVolume
        ' 
        btCallVolume.Location = New Point(665, 20)
        btCallVolume.Name = "btCallVolume"
        btCallVolume.Size = New Size(75, 23)
        btCallVolume.TabIndex = 2
        btCallVolume.Text = "设置"
        btCallVolume.UseVisualStyleBackColor = True
        ' 
        ' lbOtherVolumeStatus
        ' 
        lbOtherVolumeStatus.AutoSize = True
        lbOtherVolumeStatus.Location = New Point(762, 209)
        lbOtherVolumeStatus.Name = "lbOtherVolumeStatus"
        lbOtherVolumeStatus.Size = New Size(37, 17)
        lbOtherVolumeStatus.TabIndex = 0
        lbOtherVolumeStatus.Text = "PASS"
        ' 
        ' lbNotifyVolumeStatus
        ' 
        lbNotifyVolumeStatus.AutoSize = True
        lbNotifyVolumeStatus.Location = New Point(762, 171)
        lbNotifyVolumeStatus.Name = "lbNotifyVolumeStatus"
        lbNotifyVolumeStatus.Size = New Size(37, 17)
        lbNotifyVolumeStatus.TabIndex = 0
        lbNotifyVolumeStatus.Text = "PASS"
        ' 
        ' lbAlarmVolumeStatus
        ' 
        lbAlarmVolumeStatus.AutoSize = True
        lbAlarmVolumeStatus.Location = New Point(762, 135)
        lbAlarmVolumeStatus.Name = "lbAlarmVolumeStatus"
        lbAlarmVolumeStatus.Size = New Size(37, 17)
        lbAlarmVolumeStatus.TabIndex = 0
        lbAlarmVolumeStatus.Text = "PASS"
        ' 
        ' lbMusicVolumeStatus
        ' 
        lbMusicVolumeStatus.AutoSize = True
        lbMusicVolumeStatus.Location = New Point(762, 98)
        lbMusicVolumeStatus.Name = "lbMusicVolumeStatus"
        lbMusicVolumeStatus.Size = New Size(37, 17)
        lbMusicVolumeStatus.TabIndex = 0
        lbMusicVolumeStatus.Text = "PASS"
        ' 
        ' lbRingVolumeStatus
        ' 
        lbRingVolumeStatus.AutoSize = True
        lbRingVolumeStatus.Location = New Point(762, 61)
        lbRingVolumeStatus.Name = "lbRingVolumeStatus"
        lbRingVolumeStatus.Size = New Size(37, 17)
        lbRingVolumeStatus.TabIndex = 0
        lbRingVolumeStatus.Text = "PASS"
        ' 
        ' lbCallVolumeStatus
        ' 
        lbCallVolumeStatus.AutoSize = True
        lbCallVolumeStatus.Location = New Point(762, 23)
        lbCallVolumeStatus.Name = "lbCallVolumeStatus"
        lbCallVolumeStatus.Size = New Size(37, 17)
        lbCallVolumeStatus.TabIndex = 0
        lbCallVolumeStatus.Text = "PASS"
        ' 
        ' lbOtherVolume
        ' 
        lbOtherVolume.AutoSize = True
        lbOtherVolume.Location = New Point(15, 209)
        lbOtherVolume.Name = "lbOtherVolume"
        lbOtherVolume.Size = New Size(92, 17)
        lbOtherVolume.TabIndex = 0
        lbOtherVolume.Text = "其他默认音量："
        ' 
        ' lbNotifyVolume
        ' 
        lbNotifyVolume.AutoSize = True
        lbNotifyVolume.Location = New Point(15, 171)
        lbNotifyVolume.Name = "lbNotifyVolume"
        lbNotifyVolume.Size = New Size(92, 17)
        lbNotifyVolume.TabIndex = 0
        lbNotifyVolume.Text = "通知默认音量："
        ' 
        ' lbAlarmVolume
        ' 
        lbAlarmVolume.AutoSize = True
        lbAlarmVolume.Location = New Point(15, 135)
        lbAlarmVolume.Name = "lbAlarmVolume"
        lbAlarmVolume.Size = New Size(92, 17)
        lbAlarmVolume.TabIndex = 0
        lbAlarmVolume.Text = "闹钟默认音量："
        ' 
        ' lbMusicVolume
        ' 
        lbMusicVolume.AutoSize = True
        lbMusicVolume.Location = New Point(15, 98)
        lbMusicVolume.Name = "lbMusicVolume"
        lbMusicVolume.Size = New Size(92, 17)
        lbMusicVolume.TabIndex = 0
        lbMusicVolume.Text = "音乐默认音量："
        ' 
        ' lbRingVolume
        ' 
        lbRingVolume.AutoSize = True
        lbRingVolume.Location = New Point(15, 61)
        lbRingVolume.Name = "lbRingVolume"
        lbRingVolume.Size = New Size(92, 17)
        lbRingVolume.TabIndex = 0
        lbRingVolume.Text = "铃声默认音量："
        ' 
        ' lbCallVolume
        ' 
        lbCallVolume.AutoSize = True
        lbCallVolume.Location = New Point(15, 23)
        lbCallVolume.Name = "lbCallVolume"
        lbCallVolume.Size = New Size(92, 17)
        lbCallVolume.TabIndex = 0
        lbCallVolume.Text = "通话默认音量："
        ' 
        ' tpTee
        ' 
        tpTee.Controls.Add(lbTeeArrayStatus)
        tpTee.Controls.Add(lbTeeCertStatus)
        tpTee.Controls.Add(btTeeAllSet)
        tpTee.Controls.Add(btTeeArray)
        tpTee.Controls.Add(btnTeeSelectArray)
        tpTee.Controls.Add(btnTeeSelectCert)
        tpTee.Controls.Add(btTeeCert)
        tpTee.Controls.Add(tbTeeArray)
        tpTee.Controls.Add(lbTeeArray)
        tpTee.Controls.Add(tbTeeCert)
        tpTee.Controls.Add(lbTeeCert)
        tpTee.Controls.Add(lbTeeStatus)
        tpTee.Controls.Add(btTee)
        tpTee.Controls.Add(rbTeeClose)
        tpTee.Controls.Add(rbTeeOpen)
        tpTee.Controls.Add(lbTee)
        tpTee.Location = New Point(4, 48)
        tpTee.Name = "tpTee"
        tpTee.Size = New Size(815, 449)
        tpTee.TabIndex = 13
        tpTee.Text = "TEE"
        tpTee.UseVisualStyleBackColor = True
        ' 
        ' lbTeeArrayStatus
        ' 
        lbTeeArrayStatus.AutoSize = True
        lbTeeArrayStatus.Location = New Point(753, 104)
        lbTeeArrayStatus.Name = "lbTeeArrayStatus"
        lbTeeArrayStatus.Size = New Size(37, 17)
        lbTeeArrayStatus.TabIndex = 8
        lbTeeArrayStatus.Text = "PASS"
        ' 
        ' lbTeeCertStatus
        ' 
        lbTeeCertStatus.AutoSize = True
        lbTeeCertStatus.Location = New Point(753, 58)
        lbTeeCertStatus.Name = "lbTeeCertStatus"
        lbTeeCertStatus.Size = New Size(37, 17)
        lbTeeCertStatus.TabIndex = 8
        lbTeeCertStatus.Text = "PASS"
        ' 
        ' btTeeAllSet
        ' 
        btTeeAllSet.Location = New Point(15, 157)
        btTeeAllSet.Name = "btTeeAllSet"
        btTeeAllSet.Size = New Size(75, 23)
        btTeeAllSet.TabIndex = 7
        btTeeAllSet.Text = "全部设置"
        btTeeAllSet.UseVisualStyleBackColor = True
        ' 
        ' btTeeArray
        ' 
        btTeeArray.Location = New Point(656, 101)
        btTeeArray.Name = "btTeeArray"
        btTeeArray.Size = New Size(75, 23)
        btTeeArray.TabIndex = 6
        btTeeArray.Text = "设置"
        btTeeArray.UseVisualStyleBackColor = True
        ' 
        ' btnTeeSelectArray
        ' 
        btnTeeSelectArray.Location = New Point(575, 101)
        btnTeeSelectArray.Name = "btnTeeSelectArray"
        btnTeeSelectArray.Size = New Size(75, 23)
        btnTeeSelectArray.TabIndex = 7
        btnTeeSelectArray.Text = "选择···"
        btnTeeSelectArray.UseVisualStyleBackColor = True
        ' 
        ' btnTeeSelectCert
        ' 
        btnTeeSelectCert.Location = New Point(575, 55)
        btnTeeSelectCert.Name = "btnTeeSelectCert"
        btnTeeSelectCert.Size = New Size(75, 23)
        btnTeeSelectCert.TabIndex = 7
        btnTeeSelectCert.Text = "选择···"
        btnTeeSelectCert.UseVisualStyleBackColor = True
        ' 
        ' btTeeCert
        ' 
        btTeeCert.Location = New Point(656, 55)
        btTeeCert.Name = "btTeeCert"
        btTeeCert.Size = New Size(75, 23)
        btTeeCert.TabIndex = 7
        btTeeCert.Text = "设置"
        btTeeCert.UseVisualStyleBackColor = True
        ' 
        ' tbTeeArray
        ' 
        tbTeeArray.Location = New Point(117, 101)
        tbTeeArray.Name = "tbTeeArray"
        tbTeeArray.Size = New Size(452, 23)
        tbTeeArray.TabIndex = 5
        ' 
        ' lbTeeArray
        ' 
        lbTeeArray.AutoSize = True
        lbTeeArray.Location = New Point(15, 104)
        lbTeeArray.Name = "lbTeeArray"
        lbTeeArray.Size = New Size(87, 17)
        lbTeeArray.TabIndex = 4
        lbTeeArray.Text = "array.c 文件："
        ' 
        ' tbTeeCert
        ' 
        tbTeeCert.Location = New Point(117, 55)
        tbTeeCert.Name = "tbTeeCert"
        tbTeeCert.Size = New Size(452, 23)
        tbTeeCert.TabIndex = 5
        ' 
        ' lbTeeCert
        ' 
        lbTeeCert.AutoSize = True
        lbTeeCert.Location = New Point(15, 58)
        lbTeeCert.Name = "lbTeeCert"
        lbTeeCert.Size = New Size(92, 17)
        lbTeeCert.TabIndex = 4
        lbTeeCert.Text = "cert.dat 文件："
        ' 
        ' lbTeeStatus
        ' 
        lbTeeStatus.AutoSize = True
        lbTeeStatus.Location = New Point(753, 19)
        lbTeeStatus.Name = "lbTeeStatus"
        lbTeeStatus.Size = New Size(37, 17)
        lbTeeStatus.TabIndex = 3
        lbTeeStatus.Text = "PASS"
        ' 
        ' btTee
        ' 
        btTee.Location = New Point(656, 16)
        btTee.Name = "btTee"
        btTee.Size = New Size(75, 23)
        btTee.TabIndex = 2
        btTee.Text = "设置"
        btTee.UseVisualStyleBackColor = True
        ' 
        ' rbTeeClose
        ' 
        rbTeeClose.AutoSize = True
        rbTeeClose.Checked = True
        rbTeeClose.Location = New Point(190, 17)
        rbTeeClose.Name = "rbTeeClose"
        rbTeeClose.Size = New Size(50, 21)
        rbTeeClose.TabIndex = 1
        rbTeeClose.TabStop = True
        rbTeeClose.Text = "关闭"
        rbTeeClose.UseVisualStyleBackColor = True
        ' 
        ' rbTeeOpen
        ' 
        rbTeeOpen.AutoSize = True
        rbTeeOpen.Location = New Point(117, 17)
        rbTeeOpen.Name = "rbTeeOpen"
        rbTeeOpen.Size = New Size(50, 21)
        rbTeeOpen.TabIndex = 1
        rbTeeOpen.Text = "打开"
        rbTeeOpen.UseVisualStyleBackColor = True
        ' 
        ' lbTee
        ' 
        lbTee.AutoSize = True
        lbTee.Location = New Point(15, 19)
        lbTee.Name = "lbTee"
        lbTee.Size = New Size(69, 17)
        lbTee.TabIndex = 0
        lbTee.Text = "TEE 状态："
        ' 
        ' tpGoogleCustom
        ' 
        tpGoogleCustom.Controls.Add(lbEmailSignatureStatus)
        tpGoogleCustom.Controls.Add(lbHomePageStatus)
        tpGoogleCustom.Controls.Add(btGoogleCustom)
        tpGoogleCustom.Controls.Add(btEmailSignature)
        tpGoogleCustom.Controls.Add(btHomePage)
        tpGoogleCustom.Controls.Add(tbEmailSignature)
        tpGoogleCustom.Controls.Add(lbEmailSignature)
        tpGoogleCustom.Controls.Add(tbHomePage)
        tpGoogleCustom.Controls.Add(lbHomePage)
        tpGoogleCustom.Location = New Point(4, 48)
        tpGoogleCustom.Name = "tpGoogleCustom"
        tpGoogleCustom.Size = New Size(815, 449)
        tpGoogleCustom.TabIndex = 14
        tpGoogleCustom.Text = "谷歌客制化"
        tpGoogleCustom.UseVisualStyleBackColor = True
        ' 
        ' lbEmailSignatureStatus
        ' 
        lbEmailSignatureStatus.AutoSize = True
        lbEmailSignatureStatus.Location = New Point(761, 49)
        lbEmailSignatureStatus.Name = "lbEmailSignatureStatus"
        lbEmailSignatureStatus.Size = New Size(37, 17)
        lbEmailSignatureStatus.TabIndex = 3
        lbEmailSignatureStatus.Text = "PASS"
        ' 
        ' lbHomePageStatus
        ' 
        lbHomePageStatus.AutoSize = True
        lbHomePageStatus.Location = New Point(761, 16)
        lbHomePageStatus.Name = "lbHomePageStatus"
        lbHomePageStatus.Size = New Size(37, 17)
        lbHomePageStatus.TabIndex = 3
        lbHomePageStatus.Text = "PASS"
        ' 
        ' btGoogleCustom
        ' 
        btGoogleCustom.Location = New Point(17, 92)
        btGoogleCustom.Name = "btGoogleCustom"
        btGoogleCustom.Size = New Size(75, 23)
        btGoogleCustom.TabIndex = 2
        btGoogleCustom.Text = "全部设置"
        btGoogleCustom.UseVisualStyleBackColor = True
        ' 
        ' btEmailSignature
        ' 
        btEmailSignature.Location = New Point(665, 46)
        btEmailSignature.Name = "btEmailSignature"
        btEmailSignature.Size = New Size(75, 23)
        btEmailSignature.TabIndex = 2
        btEmailSignature.Text = "设置"
        btEmailSignature.UseVisualStyleBackColor = True
        ' 
        ' btHomePage
        ' 
        btHomePage.Location = New Point(665, 13)
        btHomePage.Name = "btHomePage"
        btHomePage.Size = New Size(75, 23)
        btHomePage.TabIndex = 2
        btHomePage.Text = "设置"
        btHomePage.UseVisualStyleBackColor = True
        ' 
        ' tbEmailSignature
        ' 
        tbEmailSignature.Location = New Point(91, 46)
        tbEmailSignature.Name = "tbEmailSignature"
        tbEmailSignature.Size = New Size(566, 23)
        tbEmailSignature.TabIndex = 1
        ' 
        ' lbEmailSignature
        ' 
        lbEmailSignature.AutoSize = True
        lbEmailSignature.Location = New Point(17, 49)
        lbEmailSignature.Name = "lbEmailSignature"
        lbEmailSignature.Size = New Size(68, 17)
        lbEmailSignature.TabIndex = 0
        lbEmailSignature.Text = "邮箱签名："
        ' 
        ' tbHomePage
        ' 
        tbHomePage.Location = New Point(91, 13)
        tbHomePage.Name = "tbHomePage"
        tbHomePage.Size = New Size(566, 23)
        tbHomePage.TabIndex = 1
        ' 
        ' lbHomePage
        ' 
        lbHomePage.AutoSize = True
        lbHomePage.Location = New Point(17, 16)
        lbHomePage.Name = "lbHomePage"
        lbHomePage.Size = New Size(68, 17)
        lbHomePage.TabIndex = 0
        lbHomePage.Text = "默认网址："
        ' 
        ' tpAnimation
        ' 
        tpAnimation.Controls.Add(lbAnimTip)
        tpAnimation.Controls.Add(lbShutdownAnimStatus)
        tpAnimation.Controls.Add(lbShutdownRingStatus)
        tpAnimation.Controls.Add(lbBootAnimStatus)
        tpAnimation.Controls.Add(lbBootRingStatus)
        tpAnimation.Controls.Add(btAnimSet)
        tpAnimation.Controls.Add(btShutdownAnim)
        tpAnimation.Controls.Add(btShutdownRing)
        tpAnimation.Controls.Add(btBootAnim)
        tpAnimation.Controls.Add(btBootRing)
        tpAnimation.Controls.Add(btSelectShutdownAnim)
        tpAnimation.Controls.Add(btSelectShutdownRing)
        tpAnimation.Controls.Add(btSelectBootAnim)
        tpAnimation.Controls.Add(btSelectBootRing)
        tpAnimation.Controls.Add(tbShutdownAnim)
        tpAnimation.Controls.Add(lbShutdownAnim)
        tpAnimation.Controls.Add(tbShutdownRing)
        tpAnimation.Controls.Add(lbShutdownRing)
        tpAnimation.Controls.Add(tbBootAnim)
        tpAnimation.Controls.Add(lbBootAnim)
        tpAnimation.Controls.Add(tbBootRing)
        tpAnimation.Controls.Add(lbBootRing)
        tpAnimation.Font = New Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        tpAnimation.Location = New Point(4, 48)
        tpAnimation.Name = "tpAnimation"
        tpAnimation.Size = New Size(815, 449)
        tpAnimation.TabIndex = 15
        tpAnimation.Text = "开关机动画"
        tpAnimation.UseVisualStyleBackColor = True
        ' 
        ' lbAnimTip
        ' 
        lbAnimTip.AutoSize = True
        lbAnimTip.Font = New Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        lbAnimTip.ForeColor = Color.Red
        lbAnimTip.Location = New Point(17, 229)
        lbAnimTip.Name = "lbAnimTip"
        lbAnimTip.Size = New Size(780, 17)
        lbAnimTip.TabIndex = 5
        lbAnimTip.Text = "提示：设置关机动画或铃声还需要修改代码，请参照启昌智能 511 项目 b48d32c58bb44d75c1291c82c73097965ca476ce 修改提交进行修改。"
        ' 
        ' lbShutdownAnimStatus
        ' 
        lbShutdownAnimStatus.AutoSize = True
        lbShutdownAnimStatus.Location = New Point(762, 139)
        lbShutdownAnimStatus.Name = "lbShutdownAnimStatus"
        lbShutdownAnimStatus.Size = New Size(37, 17)
        lbShutdownAnimStatus.TabIndex = 4
        lbShutdownAnimStatus.Text = "PASS"
        ' 
        ' lbShutdownRingStatus
        ' 
        lbShutdownRingStatus.AutoSize = True
        lbShutdownRingStatus.Location = New Point(762, 98)
        lbShutdownRingStatus.Name = "lbShutdownRingStatus"
        lbShutdownRingStatus.Size = New Size(37, 17)
        lbShutdownRingStatus.TabIndex = 4
        lbShutdownRingStatus.Text = "PASS"
        ' 
        ' lbBootAnimStatus
        ' 
        lbBootAnimStatus.AutoSize = True
        lbBootAnimStatus.Location = New Point(762, 57)
        lbBootAnimStatus.Name = "lbBootAnimStatus"
        lbBootAnimStatus.Size = New Size(37, 17)
        lbBootAnimStatus.TabIndex = 4
        lbBootAnimStatus.Text = "PASS"
        ' 
        ' lbBootRingStatus
        ' 
        lbBootRingStatus.AutoSize = True
        lbBootRingStatus.Location = New Point(762, 17)
        lbBootRingStatus.Name = "lbBootRingStatus"
        lbBootRingStatus.Size = New Size(37, 17)
        lbBootRingStatus.TabIndex = 4
        lbBootRingStatus.Text = "PASS"
        ' 
        ' btAnimSet
        ' 
        btAnimSet.Location = New Point(17, 186)
        btAnimSet.Name = "btAnimSet"
        btAnimSet.Size = New Size(75, 23)
        btAnimSet.TabIndex = 3
        btAnimSet.Text = "全部设置"
        btAnimSet.UseVisualStyleBackColor = True
        ' 
        ' btShutdownAnim
        ' 
        btShutdownAnim.Location = New Point(671, 136)
        btShutdownAnim.Name = "btShutdownAnim"
        btShutdownAnim.Size = New Size(75, 23)
        btShutdownAnim.TabIndex = 3
        btShutdownAnim.Text = "设置"
        btShutdownAnim.UseVisualStyleBackColor = True
        ' 
        ' btShutdownRing
        ' 
        btShutdownRing.Location = New Point(671, 95)
        btShutdownRing.Name = "btShutdownRing"
        btShutdownRing.Size = New Size(75, 23)
        btShutdownRing.TabIndex = 3
        btShutdownRing.Text = "设置"
        btShutdownRing.UseVisualStyleBackColor = True
        ' 
        ' btBootAnim
        ' 
        btBootAnim.Location = New Point(671, 54)
        btBootAnim.Name = "btBootAnim"
        btBootAnim.Size = New Size(75, 23)
        btBootAnim.TabIndex = 3
        btBootAnim.Text = "设置"
        btBootAnim.UseVisualStyleBackColor = True
        ' 
        ' btBootRing
        ' 
        btBootRing.Location = New Point(671, 14)
        btBootRing.Name = "btBootRing"
        btBootRing.Size = New Size(75, 23)
        btBootRing.TabIndex = 3
        btBootRing.Text = "设置"
        btBootRing.UseVisualStyleBackColor = True
        ' 
        ' btSelectShutdownAnim
        ' 
        btSelectShutdownAnim.Location = New Point(590, 136)
        btSelectShutdownAnim.Name = "btSelectShutdownAnim"
        btSelectShutdownAnim.Size = New Size(75, 23)
        btSelectShutdownAnim.TabIndex = 2
        btSelectShutdownAnim.Text = "选择动画"
        btSelectShutdownAnim.UseVisualStyleBackColor = True
        ' 
        ' btSelectShutdownRing
        ' 
        btSelectShutdownRing.Location = New Point(590, 95)
        btSelectShutdownRing.Name = "btSelectShutdownRing"
        btSelectShutdownRing.Size = New Size(75, 23)
        btSelectShutdownRing.TabIndex = 2
        btSelectShutdownRing.Text = "选择铃声"
        btSelectShutdownRing.UseVisualStyleBackColor = True
        ' 
        ' btSelectBootAnim
        ' 
        btSelectBootAnim.Location = New Point(590, 54)
        btSelectBootAnim.Name = "btSelectBootAnim"
        btSelectBootAnim.Size = New Size(75, 23)
        btSelectBootAnim.TabIndex = 2
        btSelectBootAnim.Text = "选择动画"
        btSelectBootAnim.UseVisualStyleBackColor = True
        ' 
        ' btSelectBootRing
        ' 
        btSelectBootRing.Location = New Point(590, 14)
        btSelectBootRing.Name = "btSelectBootRing"
        btSelectBootRing.Size = New Size(75, 23)
        btSelectBootRing.TabIndex = 2
        btSelectBootRing.Text = "选择铃声"
        btSelectBootRing.UseVisualStyleBackColor = True
        ' 
        ' tbShutdownAnim
        ' 
        tbShutdownAnim.Location = New Point(91, 136)
        tbShutdownAnim.Name = "tbShutdownAnim"
        tbShutdownAnim.Size = New Size(493, 23)
        tbShutdownAnim.TabIndex = 1
        ' 
        ' lbShutdownAnim
        ' 
        lbShutdownAnim.AutoSize = True
        lbShutdownAnim.Location = New Point(17, 139)
        lbShutdownAnim.Name = "lbShutdownAnim"
        lbShutdownAnim.Size = New Size(68, 17)
        lbShutdownAnim.TabIndex = 0
        lbShutdownAnim.Text = "关机动画："
        ' 
        ' tbShutdownRing
        ' 
        tbShutdownRing.Location = New Point(91, 95)
        tbShutdownRing.Name = "tbShutdownRing"
        tbShutdownRing.Size = New Size(493, 23)
        tbShutdownRing.TabIndex = 1
        ' 
        ' lbShutdownRing
        ' 
        lbShutdownRing.AutoSize = True
        lbShutdownRing.Location = New Point(17, 98)
        lbShutdownRing.Name = "lbShutdownRing"
        lbShutdownRing.Size = New Size(68, 17)
        lbShutdownRing.TabIndex = 0
        lbShutdownRing.Text = "关机铃声："
        ' 
        ' tbBootAnim
        ' 
        tbBootAnim.Location = New Point(91, 54)
        tbBootAnim.Name = "tbBootAnim"
        tbBootAnim.Size = New Size(493, 23)
        tbBootAnim.TabIndex = 1
        ' 
        ' lbBootAnim
        ' 
        lbBootAnim.AutoSize = True
        lbBootAnim.Location = New Point(17, 57)
        lbBootAnim.Name = "lbBootAnim"
        lbBootAnim.Size = New Size(68, 17)
        lbBootAnim.TabIndex = 0
        lbBootAnim.Text = "开机动画："
        ' 
        ' tbBootRing
        ' 
        tbBootRing.Location = New Point(91, 14)
        tbBootRing.Name = "tbBootRing"
        tbBootRing.Size = New Size(493, 23)
        tbBootRing.TabIndex = 1
        ' 
        ' lbBootRing
        ' 
        lbBootRing.AutoSize = True
        lbBootRing.Location = New Point(17, 17)
        lbBootRing.Name = "lbBootRing"
        lbBootRing.Size = New Size(68, 17)
        lbBootRing.TabIndex = 0
        lbBootRing.Text = "开机铃声："
        ' 
        ' tpSystemSettings
        ' 
        tpSystemSettings.Controls.Add(cbDisableScreenlock)
        tpSystemSettings.Controls.Add(cbAutoBrightness)
        tpSystemSettings.Controls.Add(cbAutoTime)
        tpSystemSettings.Controls.Add(cb24TimeFormat)
        tpSystemSettings.Controls.Add(cbGps)
        tpSystemSettings.Controls.Add(cbAutoRotation)
        tpSystemSettings.Controls.Add(Label7)
        tpSystemSettings.Controls.Add(lb24TimeFormatStatus)
        tpSystemSettings.Controls.Add(lbGpsStatus)
        tpSystemSettings.Controls.Add(lbAutoRotationStatus)
        tpSystemSettings.Controls.Add(btSystemConfig)
        tpSystemSettings.Controls.Add(bt24TimeFormat)
        tpSystemSettings.Controls.Add(btGps)
        tpSystemSettings.Controls.Add(btAutoRotation)
        tpSystemSettings.Controls.Add(lbDisableScreenlockStatus)
        tpSystemSettings.Controls.Add(lbAutoBrightnessStatus)
        tpSystemSettings.Controls.Add(lbAutoTimeStatus)
        tpSystemSettings.Controls.Add(lbScreenOffTimeStatus)
        tpSystemSettings.Controls.Add(btDisableScreenlock)
        tpSystemSettings.Controls.Add(btAutoBrightness)
        tpSystemSettings.Controls.Add(btAutoTime)
        tpSystemSettings.Controls.Add(btnScreenOffTime)
        tpSystemSettings.Controls.Add(lb24TimeFormat)
        tpSystemSettings.Controls.Add(lbGps)
        tpSystemSettings.Controls.Add(lbDisableScreenlock)
        tpSystemSettings.Controls.Add(lbAutoRotation)
        tpSystemSettings.Controls.Add(lbAutoBrightness)
        tpSystemSettings.Controls.Add(tbScreenOffTime)
        tpSystemSettings.Controls.Add(lbAutoTime)
        tpSystemSettings.Controls.Add(lbScreenOffTime)
        tpSystemSettings.Location = New Point(4, 48)
        tpSystemSettings.Name = "tpSystemSettings"
        tpSystemSettings.Size = New Size(815, 449)
        tpSystemSettings.TabIndex = 17
        tpSystemSettings.Text = "系统配置"
        tpSystemSettings.UseVisualStyleBackColor = True
        ' 
        ' cbDisableScreenlock
        ' 
        cbDisableScreenlock.FormattingEnabled = True
        cbDisableScreenlock.Items.AddRange(New Object() {"打开", "关闭"})
        cbDisableScreenlock.Location = New Point(93, 137)
        cbDisableScreenlock.Name = "cbDisableScreenlock"
        cbDisableScreenlock.Size = New Size(174, 25)
        cbDisableScreenlock.TabIndex = 4
        cbDisableScreenlock.Text = "关闭"
        ' 
        ' cbAutoBrightness
        ' 
        cbAutoBrightness.FormattingEnabled = True
        cbAutoBrightness.Items.AddRange(New Object() {"打开", "关闭"})
        cbAutoBrightness.Location = New Point(92, 95)
        cbAutoBrightness.Name = "cbAutoBrightness"
        cbAutoBrightness.Size = New Size(174, 25)
        cbAutoBrightness.TabIndex = 4
        cbAutoBrightness.Text = "关闭"
        ' 
        ' cbAutoTime
        ' 
        cbAutoTime.FormattingEnabled = True
        cbAutoTime.Items.AddRange(New Object() {"打开", "关闭"})
        cbAutoTime.Location = New Point(93, 54)
        cbAutoTime.Name = "cbAutoTime"
        cbAutoTime.Size = New Size(174, 25)
        cbAutoTime.TabIndex = 4
        cbAutoTime.Text = "关闭"
        ' 
        ' cb24TimeFormat
        ' 
        cb24TimeFormat.FormattingEnabled = True
        cb24TimeFormat.Items.AddRange(New Object() {"打开", "关闭"})
        cb24TimeFormat.Location = New Point(491, 97)
        cb24TimeFormat.Name = "cb24TimeFormat"
        cb24TimeFormat.Size = New Size(169, 25)
        cb24TimeFormat.TabIndex = 4
        cb24TimeFormat.Text = "关闭"
        ' 
        ' cbGps
        ' 
        cbGps.FormattingEnabled = True
        cbGps.Items.AddRange(New Object() {"打开", "关闭"})
        cbGps.Location = New Point(491, 55)
        cbGps.Name = "cbGps"
        cbGps.Size = New Size(169, 25)
        cbGps.TabIndex = 4
        cbGps.Text = "关闭"
        ' 
        ' cbAutoRotation
        ' 
        cbAutoRotation.FormattingEnabled = True
        cbAutoRotation.Items.AddRange(New Object() {"打开", "关闭"})
        cbAutoRotation.Location = New Point(491, 13)
        cbAutoRotation.Name = "cbAutoRotation"
        cbAutoRotation.Size = New Size(169, 25)
        cbAutoRotation.TabIndex = 4
        cbAutoRotation.Text = "关闭"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(1293, -122)
        Label7.Name = "Label7"
        Label7.Size = New Size(37, 17)
        Label7.TabIndex = 3
        Label7.Text = "PASS"
        ' 
        ' lb24TimeFormatStatus
        ' 
        lb24TimeFormatStatus.AutoSize = True
        lb24TimeFormatStatus.Location = New Point(762, 100)
        lb24TimeFormatStatus.Name = "lb24TimeFormatStatus"
        lb24TimeFormatStatus.Size = New Size(37, 17)
        lb24TimeFormatStatus.TabIndex = 3
        lb24TimeFormatStatus.Text = "PASS"
        ' 
        ' lbGpsStatus
        ' 
        lbGpsStatus.AutoSize = True
        lbGpsStatus.Location = New Point(762, 58)
        lbGpsStatus.Name = "lbGpsStatus"
        lbGpsStatus.Size = New Size(37, 17)
        lbGpsStatus.TabIndex = 3
        lbGpsStatus.Text = "PASS"
        ' 
        ' lbAutoRotationStatus
        ' 
        lbAutoRotationStatus.AutoSize = True
        lbAutoRotationStatus.Location = New Point(762, 16)
        lbAutoRotationStatus.Name = "lbAutoRotationStatus"
        lbAutoRotationStatus.Size = New Size(37, 17)
        lbAutoRotationStatus.TabIndex = 3
        lbAutoRotationStatus.Text = "PASS"
        ' 
        ' btSystemConfig
        ' 
        btSystemConfig.Location = New Point(18, 195)
        btSystemConfig.Name = "btSystemConfig"
        btSystemConfig.Size = New Size(75, 23)
        btSystemConfig.TabIndex = 2
        btSystemConfig.Text = "全部设置"
        btSystemConfig.UseVisualStyleBackColor = True
        ' 
        ' bt24TimeFormat
        ' 
        bt24TimeFormat.Location = New Point(666, 97)
        bt24TimeFormat.Name = "bt24TimeFormat"
        bt24TimeFormat.Size = New Size(75, 23)
        bt24TimeFormat.TabIndex = 2
        bt24TimeFormat.Text = "设置"
        bt24TimeFormat.UseVisualStyleBackColor = True
        ' 
        ' btGps
        ' 
        btGps.Location = New Point(666, 55)
        btGps.Name = "btGps"
        btGps.Size = New Size(75, 23)
        btGps.TabIndex = 2
        btGps.Text = "设置"
        btGps.UseVisualStyleBackColor = True
        ' 
        ' btAutoRotation
        ' 
        btAutoRotation.Location = New Point(666, 13)
        btAutoRotation.Name = "btAutoRotation"
        btAutoRotation.Size = New Size(75, 23)
        btAutoRotation.TabIndex = 2
        btAutoRotation.Text = "设置"
        btAutoRotation.UseVisualStyleBackColor = True
        ' 
        ' lbDisableScreenlockStatus
        ' 
        lbDisableScreenlockStatus.AutoSize = True
        lbDisableScreenlockStatus.Location = New Point(365, 140)
        lbDisableScreenlockStatus.Name = "lbDisableScreenlockStatus"
        lbDisableScreenlockStatus.Size = New Size(37, 17)
        lbDisableScreenlockStatus.TabIndex = 3
        lbDisableScreenlockStatus.Text = "PASS"
        ' 
        ' lbAutoBrightnessStatus
        ' 
        lbAutoBrightnessStatus.AutoSize = True
        lbAutoBrightnessStatus.Location = New Point(365, 98)
        lbAutoBrightnessStatus.Name = "lbAutoBrightnessStatus"
        lbAutoBrightnessStatus.Size = New Size(37, 17)
        lbAutoBrightnessStatus.TabIndex = 3
        lbAutoBrightnessStatus.Text = "PASS"
        ' 
        ' lbAutoTimeStatus
        ' 
        lbAutoTimeStatus.AutoSize = True
        lbAutoTimeStatus.Location = New Point(365, 56)
        lbAutoTimeStatus.Name = "lbAutoTimeStatus"
        lbAutoTimeStatus.Size = New Size(37, 17)
        lbAutoTimeStatus.TabIndex = 3
        lbAutoTimeStatus.Text = "PASS"
        ' 
        ' lbScreenOffTimeStatus
        ' 
        lbScreenOffTimeStatus.AutoSize = True
        lbScreenOffTimeStatus.Location = New Point(365, 16)
        lbScreenOffTimeStatus.Name = "lbScreenOffTimeStatus"
        lbScreenOffTimeStatus.Size = New Size(37, 17)
        lbScreenOffTimeStatus.TabIndex = 3
        lbScreenOffTimeStatus.Text = "PASS"
        ' 
        ' btDisableScreenlock
        ' 
        btDisableScreenlock.Location = New Point(272, 137)
        btDisableScreenlock.Name = "btDisableScreenlock"
        btDisableScreenlock.Size = New Size(75, 23)
        btDisableScreenlock.TabIndex = 2
        btDisableScreenlock.Text = "设置"
        btDisableScreenlock.UseVisualStyleBackColor = True
        ' 
        ' btAutoBrightness
        ' 
        btAutoBrightness.Location = New Point(272, 95)
        btAutoBrightness.Name = "btAutoBrightness"
        btAutoBrightness.Size = New Size(75, 23)
        btAutoBrightness.TabIndex = 2
        btAutoBrightness.Text = "设置"
        btAutoBrightness.UseVisualStyleBackColor = True
        ' 
        ' btAutoTime
        ' 
        btAutoTime.Location = New Point(272, 53)
        btAutoTime.Name = "btAutoTime"
        btAutoTime.Size = New Size(75, 23)
        btAutoTime.TabIndex = 2
        btAutoTime.Text = "设置"
        btAutoTime.UseVisualStyleBackColor = True
        ' 
        ' btnScreenOffTime
        ' 
        btnScreenOffTime.Location = New Point(272, 13)
        btnScreenOffTime.Name = "btnScreenOffTime"
        btnScreenOffTime.Size = New Size(75, 23)
        btnScreenOffTime.TabIndex = 2
        btnScreenOffTime.Text = "设置"
        btnScreenOffTime.UseVisualStyleBackColor = True
        ' 
        ' lb24TimeFormat
        ' 
        lb24TimeFormat.AutoSize = True
        lb24TimeFormat.Location = New Point(411, 100)
        lb24TimeFormat.Name = "lb24TimeFormat"
        lb24TimeFormat.Size = New Size(74, 17)
        lb24TimeFormat.TabIndex = 0
        lb24TimeFormat.Text = "24 小时制："
        ' 
        ' lbGps
        ' 
        lbGps.AutoSize = True
        lbGps.Location = New Point(442, 58)
        lbGps.Name = "lbGps"
        lbGps.Size = New Size(43, 17)
        lbGps.TabIndex = 0
        lbGps.Text = "GPS："
        ' 
        ' lbDisableScreenlock
        ' 
        lbDisableScreenlock.AutoSize = True
        lbDisableScreenlock.Location = New Point(18, 140)
        lbDisableScreenlock.Name = "lbDisableScreenlock"
        lbDisableScreenlock.Size = New Size(68, 17)
        lbDisableScreenlock.TabIndex = 0
        lbDisableScreenlock.Text = "禁止锁屏："
        ' 
        ' lbAutoRotation
        ' 
        lbAutoRotation.AutoSize = True
        lbAutoRotation.Location = New Point(417, 16)
        lbAutoRotation.Name = "lbAutoRotation"
        lbAutoRotation.Size = New Size(68, 17)
        lbAutoRotation.TabIndex = 0
        lbAutoRotation.Text = "自动旋转："
        ' 
        ' lbAutoBrightness
        ' 
        lbAutoBrightness.AutoSize = True
        lbAutoBrightness.Location = New Point(18, 98)
        lbAutoBrightness.Name = "lbAutoBrightness"
        lbAutoBrightness.Size = New Size(68, 17)
        lbAutoBrightness.TabIndex = 0
        lbAutoBrightness.Text = "自动亮度："
        ' 
        ' tbScreenOffTime
        ' 
        tbScreenOffTime.Location = New Point(92, 13)
        tbScreenOffTime.Name = "tbScreenOffTime"
        tbScreenOffTime.Size = New Size(174, 23)
        tbScreenOffTime.TabIndex = 1
        ' 
        ' lbAutoTime
        ' 
        lbAutoTime.AutoSize = True
        lbAutoTime.Location = New Point(18, 56)
        lbAutoTime.Name = "lbAutoTime"
        lbAutoTime.Size = New Size(68, 17)
        lbAutoTime.TabIndex = 0
        lbAutoTime.Text = "自动时间："
        ' 
        ' lbScreenOffTime
        ' 
        lbScreenOffTime.AutoSize = True
        lbScreenOffTime.Location = New Point(18, 16)
        lbScreenOffTime.Name = "lbScreenOffTime"
        lbScreenOffTime.Size = New Size(68, 17)
        lbScreenOffTime.TabIndex = 0
        lbScreenOffTime.Text = "灭屏时间："
        ' 
        ' ofdSelectFile
        ' 
        ofdSelectFile.FileName = "OpenFileDialog1"
        ' 
        ' AndroidSettingsForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(847, 522)
        Controls.Add(tcAndroidSettings)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "AndroidSettingsForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Android 工程配置"
        tcAndroidSettings.ResumeLayout(False)
        tpProjectInfo.ResumeLayout(False)
        GbChiperOptions.ResumeLayout(False)
        GbChiperOptions.PerformLayout()
        GbGoOptions.ResumeLayout(False)
        GbGoOptions.PerformLayout()
        GbGmsOptions.ResumeLayout(False)
        GbGmsOptions.PerformLayout()
        GBProject.ResumeLayout(False)
        GBProject.PerformLayout()
        tpProperty.ResumeLayout(False)
        tpProperty.PerformLayout()
        tpVersion.ResumeLayout(False)
        tpVersion.PerformLayout()
        tpFingerprint.ResumeLayout(False)
        tpFingerprint.PerformLayout()
        tpWifi.ResumeLayout(False)
        tpWifi.PerformLayout()
        tpBluetooth.ResumeLayout(False)
        tpBluetooth.PerformLayout()
        tpLanguage.ResumeLayout(False)
        tpLanguage.PerformLayout()
        tpTimezone.ResumeLayout(False)
        tpTimezone.PerformLayout()
        tpLogo.ResumeLayout(False)
        tpLogo.PerformLayout()
        tpWallpaper.ResumeLayout(False)
        tpWallpaper.PerformLayout()
        tpSample.ResumeLayout(False)
        tpSample.PerformLayout()
        tpScreenBrightness.ResumeLayout(False)
        tpScreenBrightness.PerformLayout()
        tpVolume.ResumeLayout(False)
        tpVolume.PerformLayout()
        tpTee.ResumeLayout(False)
        tpTee.PerformLayout()
        tpGoogleCustom.ResumeLayout(False)
        tpGoogleCustom.PerformLayout()
        tpAnimation.ResumeLayout(False)
        tpAnimation.PerformLayout()
        tpSystemSettings.ResumeLayout(False)
        tpSystemSettings.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents tcAndroidSettings As TabControl
    Friend WithEvents tpProjectInfo As TabPage
    Friend WithEvents GBProject As GroupBox
    Friend WithEvents CbAndroidVersin As ComboBox
    Friend WithEvents LbAndroidVersion As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LbDriveName As Label
    Friend WithEvents LbMssiName As Label
    Friend WithEvents LbPublicName As Label
    Friend WithEvents BtSelectProjectPath As Button
    Friend WithEvents LbProjectPath As Label
    Friend WithEvents CBProjectId As ComboBox
    Friend WithEvents LbProjectId As Label
    Friend WithEvents tpVersion As TabPage
    Friend WithEvents GbGmsOptions As GroupBox
    Friend WithEvents RbNotGms As RadioButton
    Friend WithEvents RbGms As RadioButton
    Friend WithEvents GbGoOptions As GroupBox
    Friend WithEvents RbOneGbGo As RadioButton
    Friend WithEvents RbTwoGbGo As RadioButton
    Friend WithEvents RbNotGo As RadioButton
    Friend WithEvents GbChiperOptions As GroupBox
    Friend WithEvents CbChiperModel As ComboBox
    Friend WithEvents CbChiperMaker As ComboBox
    Friend WithEvents LbChiperModel As Label
    Friend WithEvents LbChiperMaker As Label
    Friend WithEvents TbCustomName As TextBox
    Friend WithEvents TbMssiName As TextBox
    Friend WithEvents TbDriveName As TextBox
    Friend WithEvents TbPublicName As TextBox
    Friend WithEvents FbdSelectPath As FolderBrowserDialog
    Friend WithEvents btVersion As Button
    Friend WithEvents tbVersion As TextBox
    Private WithEvents lbVersion As Label
    Friend WithEvents lbVersionState As Label
    Friend WithEvents tpFingerprint As TabPage
    Friend WithEvents lbFingerprint As Label
    Friend WithEvents btFingerprintSet As Button
    Friend WithEvents btRandom As Button
    Friend WithEvents lbFingerprintState As Label
    Friend WithEvents tbFingerprint As TextBox
    Friend WithEvents tpProperty As TabPage
    Friend WithEvents lbProductManufacturerState As Label
    Friend WithEvents lbProductDeviceState As Label
    Friend WithEvents lbProductBrandState As Label
    Friend WithEvents lbProductModelState As Label
    Friend WithEvents lbProductNameState As Label
    Friend WithEvents tbProductManufacturer As TextBox
    Friend WithEvents lbProductManufacturer As Label
    Friend WithEvents tbProductDevice As TextBox
    Friend WithEvents lbProductDevice As Label
    Friend WithEvents tbProductBrand As TextBox
    Friend WithEvents lbProductBrand As Label
    Friend WithEvents tbProductModel As TextBox
    Friend WithEvents lbProductModel As Label
    Friend WithEvents tbProductName As TextBox
    Friend WithEvents lbProductName As Label
    Friend WithEvents btPropertySetting As Button
    Friend WithEvents tpWifi As TabPage
    Friend WithEvents lbWifiStatus As Label
    Friend WithEvents btWifiSetting As Button
    Friend WithEvents lbWifiScreenCastState As Label
    Friend WithEvents lbWifiHotspotNameState As Label
    Friend WithEvents lbWifiStatusState As Label
    Friend WithEvents tbWifiScreenCast As TextBox
    Friend WithEvents tbWifiHotspotName As TextBox
    Friend WithEvents lbWifiScreenCast As Label
    Friend WithEvents lbWifiHotspotName As Label
    Friend WithEvents rbWifiClose As RadioButton
    Friend WithEvents rbWifiOpen As RadioButton
    Friend WithEvents CbProjectPath As ComboBox
    Friend WithEvents tpBluetooth As TabPage
    Friend WithEvents btBluetoothSetting As Button
    Friend WithEvents tbBluetoothName As TextBox
    Friend WithEvents rbBluetoothClose As RadioButton
    Friend WithEvents rbBluetoothOpen As RadioButton
    Friend WithEvents lbBluetoothNameState As Label
    Friend WithEvents lbBluetoothName As Label
    Friend WithEvents lbBluetoothStatusState As Label
    Friend WithEvents lbBluetoothStatus As Label
    Friend WithEvents tpLanguage As TabPage
    Friend WithEvents btLanguageSetting As Button
    Friend WithEvents cbLanguage As ComboBox
    Friend WithEvents lbLanguageState As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tpTimezone As TabPage
    Friend WithEvents cbTimezone As ComboBox
    Friend WithEvents lbTimezoneState As Label
    Friend WithEvents lbTimezone As Label
    Friend WithEvents btTimezoneSetting As Button
    Friend WithEvents rbTimezoneClose As RadioButton
    Friend WithEvents rbTimezoneOpen As RadioButton
    Friend WithEvents lbAutoTimezone As Label
    Friend WithEvents lbAutoTimezoneState As Label
    Friend WithEvents tpLogo As TabPage
    Friend WithEvents tpWallpaper As TabPage
    Friend WithEvents tpSample As TabPage
    Friend WithEvents btLogoSetting As Button
    Friend WithEvents bLogo As Button
    Friend WithEvents tbLogo As TextBox
    Friend WithEvents lbLogoState As Label
    Friend WithEvents lbLogo As Label
    Friend WithEvents btWallpaperSetting As Button
    Friend WithEvents btInserWallpaper As Button
    Friend WithEvents btWallpaper As Button
    Friend WithEvents tbInsertWallpaper As TextBox
    Friend WithEvents lbInsertWallpaperState As Label
    Friend WithEvents tbWallpaper As TextBox
    Friend WithEvents lbInsertWallpaper As Label
    Friend WithEvents lbWallpaperState As Label
    Friend WithEvents lbWallpaper As Label
    Friend WithEvents tbSampleName As TextBox
    Friend WithEvents btSampleSetting As Button
    Friend WithEvents rbSampleClose As RadioButton
    Friend WithEvents rbSampleOpen As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents lbSampleNameState As Label
    Friend WithEvents lbSampleState As Label
    Friend WithEvents lbSample As Label
    Friend WithEvents tpScreenBrightness As TabPage
    Friend WithEvents ofdSelectFile As OpenFileDialog
    Friend WithEvents tpVolume As TabPage
    Friend WithEvents tpTee As TabPage
    Friend WithEvents tpGoogleCustom As TabPage
    Friend WithEvents tpAnimation As TabPage
    Friend WithEvents tpSystemSettings As TabPage
    Friend WithEvents btSampleName As Button
    Friend WithEvents btSample As Button
    Friend WithEvents btBrightnessAllSet As Button
    Friend WithEvents btMinBrightness As Button
    Friend WithEvents btMaxBrightness As Button
    Friend WithEvents btDefaultBrightness As Button
    Friend WithEvents lbMinBrightnessStatus As Label
    Friend WithEvents lbMaxBrightnessStatus As Label
    Friend WithEvents lbDefaultBrightnessStatus As Label
    Friend WithEvents tbMinBrightness As TextBox
    Friend WithEvents lbMinBrightness As Label
    Friend WithEvents tbMaxBrightness As TextBox
    Friend WithEvents lbMaxBrightness As Label
    Friend WithEvents tbDefaultBrightness As TextBox
    Friend WithEvents lbDefaultBrightness As Label
    Friend WithEvents cbOtherVolume As ComboBox
    Friend WithEvents cbNotifyVolume As ComboBox
    Friend WithEvents cbAlarmVolume As ComboBox
    Friend WithEvents cbMusicVolume As ComboBox
    Friend WithEvents cbRingVolume As ComboBox
    Friend WithEvents cbCallVolume As ComboBox
    Friend WithEvents btVolumeAllSet As Button
    Friend WithEvents btOtherVolume As Button
    Friend WithEvents btNotifyVolume As Button
    Friend WithEvents btAlarmVolume As Button
    Friend WithEvents btMusicVolume As Button
    Friend WithEvents btRingVolume As Button
    Friend WithEvents btCallVolume As Button
    Friend WithEvents lbOtherVolumeStatus As Label
    Friend WithEvents lbNotifyVolumeStatus As Label
    Friend WithEvents lbAlarmVolumeStatus As Label
    Friend WithEvents lbMusicVolumeStatus As Label
    Friend WithEvents lbRingVolumeStatus As Label
    Friend WithEvents lbCallVolumeStatus As Label
    Friend WithEvents lbOtherVolume As Label
    Friend WithEvents lbNotifyVolume As Label
    Friend WithEvents lbAlarmVolume As Label
    Friend WithEvents lbMusicVolume As Label
    Friend WithEvents lbRingVolume As Label
    Friend WithEvents lbCallVolume As Label
    Friend WithEvents lbTeeArrayStatus As Label
    Friend WithEvents lbTeeCertStatus As Label
    Friend WithEvents btTeeAllSet As Button
    Friend WithEvents btTeeArray As Button
    Friend WithEvents btTeeCert As Button
    Friend WithEvents tbTeeArray As TextBox
    Friend WithEvents lbTeeArray As Label
    Friend WithEvents tbTeeCert As TextBox
    Friend WithEvents lbTeeCert As Label
    Friend WithEvents lbTeeStatus As Label
    Friend WithEvents btTee As Button
    Friend WithEvents rbTeeClose As RadioButton
    Friend WithEvents rbTeeOpen As RadioButton
    Friend WithEvents lbTee As Label
    Friend WithEvents btnTeeSelectArray As Button
    Friend WithEvents btnTeeSelectCert As Button
    Friend WithEvents lbEmailSignatureStatus As Label
    Friend WithEvents lbHomePageStatus As Label
    Friend WithEvents btGoogleCustom As Button
    Friend WithEvents btEmailSignature As Button
    Friend WithEvents btHomePage As Button
    Friend WithEvents tbEmailSignature As TextBox
    Friend WithEvents lbEmailSignature As Label
    Friend WithEvents tbHomePage As TextBox
    Friend WithEvents lbHomePage As Label
    Friend WithEvents lbAnimTip As Label
    Friend WithEvents lbShutdownAnimStatus As Label
    Friend WithEvents lbShutdownRingStatus As Label
    Friend WithEvents lbBootAnimStatus As Label
    Friend WithEvents lbBootRingStatus As Label
    Friend WithEvents btAnimSet As Button
    Friend WithEvents btShutdownAnim As Button
    Friend WithEvents btShutdownRing As Button
    Friend WithEvents btBootAnim As Button
    Friend WithEvents btBootRing As Button
    Friend WithEvents btSelectShutdownAnim As Button
    Friend WithEvents btSelectShutdownRing As Button
    Friend WithEvents btSelectBootAnim As Button
    Friend WithEvents btSelectBootRing As Button
    Friend WithEvents tbShutdownAnim As TextBox
    Friend WithEvents lbShutdownAnim As Label
    Friend WithEvents tbShutdownRing As TextBox
    Friend WithEvents lbShutdownRing As Label
    Friend WithEvents tbBootAnim As TextBox
    Friend WithEvents lbBootAnim As Label
    Friend WithEvents tbBootRing As TextBox
    Friend WithEvents lbBootRing As Label
    Friend WithEvents cbAutoTime As Global.System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As Global.System.Windows.Forms.Label
    Friend WithEvents lb24TimeFormatStatus As Global.System.Windows.Forms.Label
    Friend WithEvents lbGpsStatus As Global.System.Windows.Forms.Label
    Friend WithEvents lbAutoRotationStatus As Global.System.Windows.Forms.Label
    Friend WithEvents btSystemConfig As Global.System.Windows.Forms.Button
    Friend WithEvents bt24TimeFormat As Global.System.Windows.Forms.Button
    Friend WithEvents btGps As Global.System.Windows.Forms.Button
    Friend WithEvents btAutoRotation As Global.System.Windows.Forms.Button
    Friend WithEvents lbDisableScreenlockStatus As Global.System.Windows.Forms.Label
    Friend WithEvents lbAutoBrightnessStatus As Global.System.Windows.Forms.Label
    Friend WithEvents lbAutoTimeStatus As Global.System.Windows.Forms.Label
    Friend WithEvents lbScreenOffTimeStatus As Global.System.Windows.Forms.Label
    Friend WithEvents btDisableScreenlock As Global.System.Windows.Forms.Button
    Friend WithEvents btAutoBrightness As Global.System.Windows.Forms.Button
    Friend WithEvents btAutoTime As Global.System.Windows.Forms.Button
    Friend WithEvents btnScreenOffTime As Global.System.Windows.Forms.Button
    Friend WithEvents lb24TimeFormat As Global.System.Windows.Forms.Label
    Friend WithEvents lbGps As Global.System.Windows.Forms.Label
    Friend WithEvents lbDisableScreenlock As Global.System.Windows.Forms.Label
    Friend WithEvents lbAutoRotation As Global.System.Windows.Forms.Label
    Friend WithEvents lbAutoBrightness As Global.System.Windows.Forms.Label
    Friend WithEvents tbScreenOffTime As Global.System.Windows.Forms.TextBox
    Friend WithEvents lbAutoTime As Global.System.Windows.Forms.Label
    Friend WithEvents lbScreenOffTime As Global.System.Windows.Forms.Label
    Friend WithEvents cbDisableScreenlock As Global.System.Windows.Forms.ComboBox
    Friend WithEvents cbAutoBrightness As Global.System.Windows.Forms.ComboBox
    Friend WithEvents cb24TimeFormat As Global.System.Windows.Forms.ComboBox
    Friend WithEvents cbGps As Global.System.Windows.Forms.ComboBox
    Friend WithEvents cbAutoRotation As Global.System.Windows.Forms.ComboBox
End Class
