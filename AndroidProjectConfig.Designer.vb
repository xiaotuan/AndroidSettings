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
        Me.tcAndroidSettings = New System.Windows.Forms.TabControl()
        Me.tpProjectInfo = New System.Windows.Forms.TabPage()
        Me.GbChiperOptions = New System.Windows.Forms.GroupBox()
        Me.CbChiperModel = New System.Windows.Forms.ComboBox()
        Me.CbChiperMaker = New System.Windows.Forms.ComboBox()
        Me.LbChiperModel = New System.Windows.Forms.Label()
        Me.LbChiperMaker = New System.Windows.Forms.Label()
        Me.GbGoOptions = New System.Windows.Forms.GroupBox()
        Me.RbOneGbGo = New System.Windows.Forms.RadioButton()
        Me.RbTwoGbGo = New System.Windows.Forms.RadioButton()
        Me.RbNotGo = New System.Windows.Forms.RadioButton()
        Me.GbGmsOptions = New System.Windows.Forms.GroupBox()
        Me.RbNotGms = New System.Windows.Forms.RadioButton()
        Me.RbGms = New System.Windows.Forms.RadioButton()
        Me.GBProject = New System.Windows.Forms.GroupBox()
        Me.CbProjectPath = New System.Windows.Forms.ComboBox()
        Me.TbCustomName = New System.Windows.Forms.TextBox()
        Me.TbMssiName = New System.Windows.Forms.TextBox()
        Me.TbDriveName = New System.Windows.Forms.TextBox()
        Me.TbPublicName = New System.Windows.Forms.TextBox()
        Me.CbAndroidVersin = New System.Windows.Forms.ComboBox()
        Me.LbAndroidVersion = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LbDriveName = New System.Windows.Forms.Label()
        Me.LbMssiName = New System.Windows.Forms.Label()
        Me.LbPublicName = New System.Windows.Forms.Label()
        Me.BtSelectProjectPath = New System.Windows.Forms.Button()
        Me.LbProjectPath = New System.Windows.Forms.Label()
        Me.CBProjectId = New System.Windows.Forms.ComboBox()
        Me.LbProjectId = New System.Windows.Forms.Label()
        Me.tpProperty = New System.Windows.Forms.TabPage()
        Me.lbProductManufacturerState = New System.Windows.Forms.Label()
        Me.lbProductDeviceState = New System.Windows.Forms.Label()
        Me.lbProductBrandState = New System.Windows.Forms.Label()
        Me.lbProductModelState = New System.Windows.Forms.Label()
        Me.lbProductNameState = New System.Windows.Forms.Label()
        Me.btPropertySetting = New System.Windows.Forms.Button()
        Me.tbProductManufacturer = New System.Windows.Forms.TextBox()
        Me.lbProductManufacturer = New System.Windows.Forms.Label()
        Me.tbProductDevice = New System.Windows.Forms.TextBox()
        Me.lbProductDevice = New System.Windows.Forms.Label()
        Me.tbProductBrand = New System.Windows.Forms.TextBox()
        Me.lbProductBrand = New System.Windows.Forms.Label()
        Me.tbProductModel = New System.Windows.Forms.TextBox()
        Me.lbProductModel = New System.Windows.Forms.Label()
        Me.tbProductName = New System.Windows.Forms.TextBox()
        Me.lbProductName = New System.Windows.Forms.Label()
        Me.tpVersion = New System.Windows.Forms.TabPage()
        Me.lbVersionState = New System.Windows.Forms.Label()
        Me.btVersion = New System.Windows.Forms.Button()
        Me.tbVersion = New System.Windows.Forms.TextBox()
        Me.lbVersion = New System.Windows.Forms.Label()
        Me.tpFingerprint = New System.Windows.Forms.TabPage()
        Me.btFingerprintSet = New System.Windows.Forms.Button()
        Me.btRandom = New System.Windows.Forms.Button()
        Me.lbFingerprintState = New System.Windows.Forms.Label()
        Me.tbFingerprint = New System.Windows.Forms.TextBox()
        Me.lbFingerprint = New System.Windows.Forms.Label()
        Me.tpWifi = New System.Windows.Forms.TabPage()
        Me.btWifiSetting = New System.Windows.Forms.Button()
        Me.lbWifiScreenCastState = New System.Windows.Forms.Label()
        Me.lbWifiHotspotNameState = New System.Windows.Forms.Label()
        Me.lbWifiStatusState = New System.Windows.Forms.Label()
        Me.tbWifiScreenCast = New System.Windows.Forms.TextBox()
        Me.tbWifiHotspotName = New System.Windows.Forms.TextBox()
        Me.lbWifiScreenCast = New System.Windows.Forms.Label()
        Me.lbWifiHotspotName = New System.Windows.Forms.Label()
        Me.rbWifiClose = New System.Windows.Forms.RadioButton()
        Me.rbWifiOpen = New System.Windows.Forms.RadioButton()
        Me.lbWifiStatus = New System.Windows.Forms.Label()
        Me.tpBluetooth = New System.Windows.Forms.TabPage()
        Me.btBluetoothSetting = New System.Windows.Forms.Button()
        Me.tbBluetoothName = New System.Windows.Forms.TextBox()
        Me.rbBluetoothClose = New System.Windows.Forms.RadioButton()
        Me.rbBluetoothOpen = New System.Windows.Forms.RadioButton()
        Me.lbBluetoothNameState = New System.Windows.Forms.Label()
        Me.lbBluetoothName = New System.Windows.Forms.Label()
        Me.lbBluetoothStatusState = New System.Windows.Forms.Label()
        Me.lbBluetoothStatus = New System.Windows.Forms.Label()
        Me.tpLanguage = New System.Windows.Forms.TabPage()
        Me.btLanguageSetting = New System.Windows.Forms.Button()
        Me.cbLanguage = New System.Windows.Forms.ComboBox()
        Me.lbLanguageState = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tpTimezone = New System.Windows.Forms.TabPage()
        Me.cbTimezone = New System.Windows.Forms.ComboBox()
        Me.lbTimezoneState = New System.Windows.Forms.Label()
        Me.lbTimezone = New System.Windows.Forms.Label()
        Me.btTimezoneSetting = New System.Windows.Forms.Button()
        Me.FbdSelectPath = New System.Windows.Forms.FolderBrowserDialog()
        Me.tcAndroidSettings.SuspendLayout()
        Me.tpProjectInfo.SuspendLayout()
        Me.GbChiperOptions.SuspendLayout()
        Me.GbGoOptions.SuspendLayout()
        Me.GbGmsOptions.SuspendLayout()
        Me.GBProject.SuspendLayout()
        Me.tpProperty.SuspendLayout()
        Me.tpVersion.SuspendLayout()
        Me.tpFingerprint.SuspendLayout()
        Me.tpWifi.SuspendLayout()
        Me.tpBluetooth.SuspendLayout()
        Me.tpLanguage.SuspendLayout()
        Me.tpTimezone.SuspendLayout()
        Me.SuspendLayout()
        '
        'tcAndroidSettings
        '
        Me.tcAndroidSettings.Controls.Add(Me.tpProjectInfo)
        Me.tcAndroidSettings.Controls.Add(Me.tpProperty)
        Me.tcAndroidSettings.Controls.Add(Me.tpVersion)
        Me.tcAndroidSettings.Controls.Add(Me.tpFingerprint)
        Me.tcAndroidSettings.Controls.Add(Me.tpWifi)
        Me.tcAndroidSettings.Controls.Add(Me.tpBluetooth)
        Me.tcAndroidSettings.Controls.Add(Me.tpLanguage)
        Me.tcAndroidSettings.Controls.Add(Me.tpTimezone)
        Me.tcAndroidSettings.Location = New System.Drawing.Point(12, 12)
        Me.tcAndroidSettings.Name = "tcAndroidSettings"
        Me.tcAndroidSettings.SelectedIndex = 0
        Me.tcAndroidSettings.Size = New System.Drawing.Size(823, 486)
        Me.tcAndroidSettings.TabIndex = 0
        '
        'tpProjectInfo
        '
        Me.tpProjectInfo.Controls.Add(Me.GbChiperOptions)
        Me.tpProjectInfo.Controls.Add(Me.GbGoOptions)
        Me.tpProjectInfo.Controls.Add(Me.GbGmsOptions)
        Me.tpProjectInfo.Controls.Add(Me.GBProject)
        Me.tpProjectInfo.Location = New System.Drawing.Point(4, 26)
        Me.tpProjectInfo.Name = "tpProjectInfo"
        Me.tpProjectInfo.Padding = New System.Windows.Forms.Padding(3)
        Me.tpProjectInfo.Size = New System.Drawing.Size(815, 456)
        Me.tpProjectInfo.TabIndex = 0
        Me.tpProjectInfo.Text = "工程信息"
        Me.tpProjectInfo.UseVisualStyleBackColor = True
        '
        'GbChiperOptions
        '
        Me.GbChiperOptions.Controls.Add(Me.CbChiperModel)
        Me.GbChiperOptions.Controls.Add(Me.CbChiperMaker)
        Me.GbChiperOptions.Controls.Add(Me.LbChiperModel)
        Me.GbChiperOptions.Controls.Add(Me.LbChiperMaker)
        Me.GbChiperOptions.Location = New System.Drawing.Point(6, 347)
        Me.GbChiperOptions.Name = "GbChiperOptions"
        Me.GbChiperOptions.Size = New System.Drawing.Size(803, 97)
        Me.GbChiperOptions.TabIndex = 2
        Me.GbChiperOptions.TabStop = False
        Me.GbChiperOptions.Text = "芯片选项"
        '
        'CbChiperModel
        '
        Me.CbChiperModel.FormattingEnabled = True
        Me.CbChiperModel.Items.AddRange(New Object() {"MT6761", "MT6739", "MT8183"})
        Me.CbChiperModel.Location = New System.Drawing.Point(80, 57)
        Me.CbChiperModel.Name = "CbChiperModel"
        Me.CbChiperModel.Size = New System.Drawing.Size(212, 25)
        Me.CbChiperModel.TabIndex = 1
        Me.CbChiperModel.Text = "MT6761"
        '
        'CbChiperMaker
        '
        Me.CbChiperMaker.FormattingEnabled = True
        Me.CbChiperMaker.Items.AddRange(New Object() {"MTK"})
        Me.CbChiperMaker.Location = New System.Drawing.Point(80, 21)
        Me.CbChiperMaker.Name = "CbChiperMaker"
        Me.CbChiperMaker.Size = New System.Drawing.Size(212, 25)
        Me.CbChiperMaker.TabIndex = 1
        Me.CbChiperMaker.Text = "MTK"
        '
        'LbChiperModel
        '
        Me.LbChiperModel.AutoSize = True
        Me.LbChiperModel.Location = New System.Drawing.Point(6, 60)
        Me.LbChiperModel.Name = "LbChiperModel"
        Me.LbChiperModel.Size = New System.Drawing.Size(68, 17)
        Me.LbChiperModel.TabIndex = 0
        Me.LbChiperModel.Text = "芯片型号："
        '
        'LbChiperMaker
        '
        Me.LbChiperMaker.AutoSize = True
        Me.LbChiperMaker.Location = New System.Drawing.Point(6, 24)
        Me.LbChiperMaker.Name = "LbChiperMaker"
        Me.LbChiperMaker.Size = New System.Drawing.Size(68, 17)
        Me.LbChiperMaker.TabIndex = 0
        Me.LbChiperMaker.Text = "芯片厂商："
        '
        'GbGoOptions
        '
        Me.GbGoOptions.Controls.Add(Me.RbOneGbGo)
        Me.GbGoOptions.Controls.Add(Me.RbTwoGbGo)
        Me.GbGoOptions.Controls.Add(Me.RbNotGo)
        Me.GbGoOptions.Location = New System.Drawing.Point(6, 287)
        Me.GbGoOptions.Name = "GbGoOptions"
        Me.GbGoOptions.Size = New System.Drawing.Size(803, 54)
        Me.GbGoOptions.TabIndex = 1
        Me.GbGoOptions.TabStop = False
        Me.GbGoOptions.Text = "Go 选项"
        '
        'RbOneGbGo
        '
        Me.RbOneGbGo.AutoSize = True
        Me.RbOneGbGo.Location = New System.Drawing.Point(373, 22)
        Me.RbOneGbGo.Name = "RbOneGbGo"
        Me.RbOneGbGo.Size = New System.Drawing.Size(73, 21)
        Me.RbOneGbGo.TabIndex = 1
        Me.RbOneGbGo.Text = "1GB GO"
        Me.RbOneGbGo.UseVisualStyleBackColor = True
        '
        'RbTwoGbGo
        '
        Me.RbTwoGbGo.AutoSize = True
        Me.RbTwoGbGo.Checked = True
        Me.RbTwoGbGo.Location = New System.Drawing.Point(703, 22)
        Me.RbTwoGbGo.Name = "RbTwoGbGo"
        Me.RbTwoGbGo.Size = New System.Drawing.Size(73, 21)
        Me.RbTwoGbGo.TabIndex = 1
        Me.RbTwoGbGo.TabStop = True
        Me.RbTwoGbGo.Text = "2GB GO"
        Me.RbTwoGbGo.UseVisualStyleBackColor = True
        '
        'RbNotGo
        '
        Me.RbNotGo.AutoSize = True
        Me.RbNotGo.Location = New System.Drawing.Point(6, 22)
        Me.RbNotGo.Name = "RbNotGo"
        Me.RbNotGo.Size = New System.Drawing.Size(61, 21)
        Me.RbNotGo.TabIndex = 0
        Me.RbNotGo.Text = "非 GO"
        Me.RbNotGo.UseVisualStyleBackColor = True
        '
        'GbGmsOptions
        '
        Me.GbGmsOptions.Controls.Add(Me.RbNotGms)
        Me.GbGmsOptions.Controls.Add(Me.RbGms)
        Me.GbGmsOptions.Location = New System.Drawing.Point(6, 227)
        Me.GbGmsOptions.Name = "GbGmsOptions"
        Me.GbGmsOptions.Size = New System.Drawing.Size(803, 54)
        Me.GbGmsOptions.TabIndex = 1
        Me.GbGmsOptions.TabStop = False
        Me.GbGmsOptions.Text = "GMS 选项"
        '
        'RbNotGms
        '
        Me.RbNotGms.AutoSize = True
        Me.RbNotGms.Location = New System.Drawing.Point(6, 22)
        Me.RbNotGms.Name = "RbNotGms"
        Me.RbNotGms.Size = New System.Drawing.Size(70, 21)
        Me.RbNotGms.TabIndex = 1
        Me.RbNotGms.Text = "非 GMS"
        Me.RbNotGms.UseVisualStyleBackColor = True
        '
        'RbGms
        '
        Me.RbGms.AutoSize = True
        Me.RbGms.Checked = True
        Me.RbGms.Location = New System.Drawing.Point(373, 22)
        Me.RbGms.Name = "RbGms"
        Me.RbGms.Size = New System.Drawing.Size(54, 21)
        Me.RbGms.TabIndex = 0
        Me.RbGms.TabStop = True
        Me.RbGms.Text = "GMS"
        Me.RbGms.UseVisualStyleBackColor = True
        '
        'GBProject
        '
        Me.GBProject.Controls.Add(Me.CbProjectPath)
        Me.GBProject.Controls.Add(Me.TbCustomName)
        Me.GBProject.Controls.Add(Me.TbMssiName)
        Me.GBProject.Controls.Add(Me.TbDriveName)
        Me.GBProject.Controls.Add(Me.TbPublicName)
        Me.GBProject.Controls.Add(Me.CbAndroidVersin)
        Me.GBProject.Controls.Add(Me.LbAndroidVersion)
        Me.GBProject.Controls.Add(Me.Label4)
        Me.GBProject.Controls.Add(Me.LbDriveName)
        Me.GBProject.Controls.Add(Me.LbMssiName)
        Me.GBProject.Controls.Add(Me.LbPublicName)
        Me.GBProject.Controls.Add(Me.BtSelectProjectPath)
        Me.GBProject.Controls.Add(Me.LbProjectPath)
        Me.GBProject.Controls.Add(Me.CBProjectId)
        Me.GBProject.Controls.Add(Me.LbProjectId)
        Me.GBProject.Location = New System.Drawing.Point(6, 6)
        Me.GBProject.Name = "GBProject"
        Me.GBProject.Size = New System.Drawing.Size(803, 215)
        Me.GBProject.TabIndex = 0
        Me.GBProject.TabStop = False
        Me.GBProject.Text = "项目信息选项"
        '
        'CbProjectPath
        '
        Me.CbProjectPath.FormattingEnabled = True
        Me.CbProjectPath.Location = New System.Drawing.Point(104, 98)
        Me.CbProjectPath.Name = "CbProjectPath"
        Me.CbProjectPath.Size = New System.Drawing.Size(612, 25)
        Me.CbProjectPath.TabIndex = 16
        '
        'TbCustomName
        '
        Me.TbCustomName.Location = New System.Drawing.Point(513, 173)
        Me.TbCustomName.Name = "TbCustomName"
        Me.TbCustomName.Size = New System.Drawing.Size(284, 23)
        Me.TbCustomName.TabIndex = 15
        '
        'TbMssiName
        '
        Me.TbMssiName.Location = New System.Drawing.Point(513, 137)
        Me.TbMssiName.Name = "TbMssiName"
        Me.TbMssiName.Size = New System.Drawing.Size(284, 23)
        Me.TbMssiName.TabIndex = 15
        '
        'TbDriveName
        '
        Me.TbDriveName.Location = New System.Drawing.Point(104, 173)
        Me.TbDriveName.Name = "TbDriveName"
        Me.TbDriveName.Size = New System.Drawing.Size(293, 23)
        Me.TbDriveName.TabIndex = 15
        '
        'TbPublicName
        '
        Me.TbPublicName.Location = New System.Drawing.Point(104, 137)
        Me.TbPublicName.Name = "TbPublicName"
        Me.TbPublicName.Size = New System.Drawing.Size(293, 23)
        Me.TbPublicName.TabIndex = 15
        '
        'CbAndroidVersin
        '
        Me.CbAndroidVersin.FormattingEnabled = True
        Me.CbAndroidVersin.Items.AddRange(New Object() {"Android 11", "Android 12", "Android 13"})
        Me.CbAndroidVersin.Location = New System.Drawing.Point(104, 62)
        Me.CbAndroidVersin.Name = "CbAndroidVersin"
        Me.CbAndroidVersin.Size = New System.Drawing.Size(293, 25)
        Me.CbAndroidVersin.TabIndex = 14
        Me.CbAndroidVersin.Text = "Android 13"
        '
        'LbAndroidVersion
        '
        Me.LbAndroidVersion.AutoSize = True
        Me.LbAndroidVersion.Location = New System.Drawing.Point(6, 65)
        Me.LbAndroidVersion.Name = "LbAndroidVersion"
        Me.LbAndroidVersion.Size = New System.Drawing.Size(95, 17)
        Me.LbAndroidVersion.TabIndex = 13
        Me.LbAndroidVersion.Text = "Android 版本："
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(403, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 17)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "客制化目录名称："
        '
        'LbDriveName
        '
        Me.LbDriveName.AutoSize = True
        Me.LbDriveName.Location = New System.Drawing.Point(6, 176)
        Me.LbDriveName.Name = "LbDriveName"
        Me.LbDriveName.Size = New System.Drawing.Size(92, 17)
        Me.LbDriveName.TabIndex = 9
        Me.LbDriveName.Text = "驱动目录名称："
        '
        'LbMssiName
        '
        Me.LbMssiName.AutoSize = True
        Me.LbMssiName.Location = New System.Drawing.Point(403, 142)
        Me.LbMssiName.Name = "LbMssiName"
        Me.LbMssiName.Size = New System.Drawing.Size(75, 17)
        Me.LbMssiName.TabIndex = 7
        Me.LbMssiName.Text = "Mssi 名称："
        '
        'LbPublicName
        '
        Me.LbPublicName.AutoSize = True
        Me.LbPublicName.Location = New System.Drawing.Point(6, 140)
        Me.LbPublicName.Name = "LbPublicName"
        Me.LbPublicName.Size = New System.Drawing.Size(68, 17)
        Me.LbPublicName.TabIndex = 5
        Me.LbPublicName.Text = "公版名称："
        '
        'BtSelectProjectPath
        '
        Me.BtSelectProjectPath.Location = New System.Drawing.Point(722, 98)
        Me.BtSelectProjectPath.Name = "BtSelectProjectPath"
        Me.BtSelectProjectPath.Size = New System.Drawing.Size(75, 23)
        Me.BtSelectProjectPath.TabIndex = 4
        Me.BtSelectProjectPath.Text = "选择..."
        Me.BtSelectProjectPath.UseVisualStyleBackColor = True
        '
        'LbProjectPath
        '
        Me.LbProjectPath.AutoSize = True
        Me.LbProjectPath.Location = New System.Drawing.Point(6, 101)
        Me.LbProjectPath.Name = "LbProjectPath"
        Me.LbProjectPath.Size = New System.Drawing.Size(68, 17)
        Me.LbProjectPath.TabIndex = 2
        Me.LbProjectPath.Text = "工程路径："
        '
        'CBProjectId
        '
        Me.CBProjectId.FormattingEnabled = True
        Me.CBProjectId.Location = New System.Drawing.Point(104, 26)
        Me.CBProjectId.Name = "CBProjectId"
        Me.CBProjectId.Size = New System.Drawing.Size(293, 25)
        Me.CBProjectId.TabIndex = 1
        '
        'LbProjectId
        '
        Me.LbProjectId.AutoSize = True
        Me.LbProjectId.Location = New System.Drawing.Point(6, 29)
        Me.LbProjectId.Name = "LbProjectId"
        Me.LbProjectId.Size = New System.Drawing.Size(56, 17)
        Me.LbProjectId.TabIndex = 0
        Me.LbProjectId.Text = "禅道号："
        '
        'tpProperty
        '
        Me.tpProperty.Controls.Add(Me.lbProductManufacturerState)
        Me.tpProperty.Controls.Add(Me.lbProductDeviceState)
        Me.tpProperty.Controls.Add(Me.lbProductBrandState)
        Me.tpProperty.Controls.Add(Me.lbProductModelState)
        Me.tpProperty.Controls.Add(Me.lbProductNameState)
        Me.tpProperty.Controls.Add(Me.btPropertySetting)
        Me.tpProperty.Controls.Add(Me.tbProductManufacturer)
        Me.tpProperty.Controls.Add(Me.lbProductManufacturer)
        Me.tpProperty.Controls.Add(Me.tbProductDevice)
        Me.tpProperty.Controls.Add(Me.lbProductDevice)
        Me.tpProperty.Controls.Add(Me.tbProductBrand)
        Me.tpProperty.Controls.Add(Me.lbProductBrand)
        Me.tpProperty.Controls.Add(Me.tbProductModel)
        Me.tpProperty.Controls.Add(Me.lbProductModel)
        Me.tpProperty.Controls.Add(Me.tbProductName)
        Me.tpProperty.Controls.Add(Me.lbProductName)
        Me.tpProperty.Location = New System.Drawing.Point(4, 26)
        Me.tpProperty.Name = "tpProperty"
        Me.tpProperty.Size = New System.Drawing.Size(815, 456)
        Me.tpProperty.TabIndex = 3
        Me.tpProperty.Text = "系统属性"
        Me.tpProperty.UseVisualStyleBackColor = True
        '
        'lbProductManufacturerState
        '
        Me.lbProductManufacturerState.AutoSize = True
        Me.lbProductManufacturerState.Location = New System.Drawing.Point(756, 158)
        Me.lbProductManufacturerState.Name = "lbProductManufacturerState"
        Me.lbProductManufacturerState.Size = New System.Drawing.Size(37, 17)
        Me.lbProductManufacturerState.TabIndex = 3
        Me.lbProductManufacturerState.Text = "PASS"
        '
        'lbProductDeviceState
        '
        Me.lbProductDeviceState.AutoSize = True
        Me.lbProductDeviceState.Location = New System.Drawing.Point(756, 123)
        Me.lbProductDeviceState.Name = "lbProductDeviceState"
        Me.lbProductDeviceState.Size = New System.Drawing.Size(37, 17)
        Me.lbProductDeviceState.TabIndex = 3
        Me.lbProductDeviceState.Text = "PASS"
        '
        'lbProductBrandState
        '
        Me.lbProductBrandState.AutoSize = True
        Me.lbProductBrandState.Location = New System.Drawing.Point(756, 88)
        Me.lbProductBrandState.Name = "lbProductBrandState"
        Me.lbProductBrandState.Size = New System.Drawing.Size(37, 17)
        Me.lbProductBrandState.TabIndex = 3
        Me.lbProductBrandState.Text = "PASS"
        '
        'lbProductModelState
        '
        Me.lbProductModelState.AutoSize = True
        Me.lbProductModelState.Location = New System.Drawing.Point(756, 51)
        Me.lbProductModelState.Name = "lbProductModelState"
        Me.lbProductModelState.Size = New System.Drawing.Size(37, 17)
        Me.lbProductModelState.TabIndex = 3
        Me.lbProductModelState.Text = "PASS"
        '
        'lbProductNameState
        '
        Me.lbProductNameState.AutoSize = True
        Me.lbProductNameState.Location = New System.Drawing.Point(756, 15)
        Me.lbProductNameState.Name = "lbProductNameState"
        Me.lbProductNameState.Size = New System.Drawing.Size(37, 17)
        Me.lbProductNameState.TabIndex = 3
        Me.lbProductNameState.Text = "PASS"
        '
        'btPropertySetting
        '
        Me.btPropertySetting.Location = New System.Drawing.Point(13, 211)
        Me.btPropertySetting.Name = "btPropertySetting"
        Me.btPropertySetting.Size = New System.Drawing.Size(75, 23)
        Me.btPropertySetting.TabIndex = 2
        Me.btPropertySetting.Text = "设置"
        Me.btPropertySetting.UseVisualStyleBackColor = True
        '
        'tbProductManufacturer
        '
        Me.tbProductManufacturer.Location = New System.Drawing.Point(257, 158)
        Me.tbProductManufacturer.Name = "tbProductManufacturer"
        Me.tbProductManufacturer.Size = New System.Drawing.Size(493, 23)
        Me.tbProductManufacturer.TabIndex = 1
        '
        'lbProductManufacturer
        '
        Me.lbProductManufacturer.AutoSize = True
        Me.lbProductManufacturer.Location = New System.Drawing.Point(13, 158)
        Me.lbProductManufacturer.Name = "lbProductManufacturer"
        Me.lbProductManufacturer.Size = New System.Drawing.Size(238, 17)
        Me.lbProductManufacturer.TabIndex = 0
        Me.lbProductManufacturer.Text = "设备制造商（ro.product.manufacturer)："
        '
        'tbProductDevice
        '
        Me.tbProductDevice.Location = New System.Drawing.Point(257, 120)
        Me.tbProductDevice.Name = "tbProductDevice"
        Me.tbProductDevice.Size = New System.Drawing.Size(493, 23)
        Me.tbProductDevice.TabIndex = 1
        '
        'lbProductDevice
        '
        Me.lbProductDevice.AutoSize = True
        Me.lbProductDevice.Location = New System.Drawing.Point(13, 123)
        Me.lbProductDevice.Name = "lbProductDevice"
        Me.lbProductDevice.Size = New System.Drawing.Size(186, 17)
        Me.lbProductDevice.TabIndex = 0
        Me.lbProductDevice.Text = "设备名称（ro.product.device)："
        '
        'tbProductBrand
        '
        Me.tbProductBrand.Location = New System.Drawing.Point(257, 85)
        Me.tbProductBrand.Name = "tbProductBrand"
        Me.tbProductBrand.Size = New System.Drawing.Size(493, 23)
        Me.tbProductBrand.TabIndex = 1
        '
        'lbProductBrand
        '
        Me.lbProductBrand.AutoSize = True
        Me.lbProductBrand.Location = New System.Drawing.Point(13, 88)
        Me.lbProductBrand.Name = "lbProductBrand"
        Me.lbProductBrand.Size = New System.Drawing.Size(184, 17)
        Me.lbProductBrand.TabIndex = 0
        Me.lbProductBrand.Text = "设备品牌（ro.product.brand)："
        '
        'tbProductModel
        '
        Me.tbProductModel.Location = New System.Drawing.Point(257, 48)
        Me.tbProductModel.Name = "tbProductModel"
        Me.tbProductModel.Size = New System.Drawing.Size(493, 23)
        Me.tbProductModel.TabIndex = 1
        '
        'lbProductModel
        '
        Me.lbProductModel.AutoSize = True
        Me.lbProductModel.Location = New System.Drawing.Point(13, 51)
        Me.lbProductModel.Name = "lbProductModel"
        Me.lbProductModel.Size = New System.Drawing.Size(186, 17)
        Me.lbProductModel.TabIndex = 0
        Me.lbProductModel.Text = "产品型号（ro.product.model)："
        '
        'tbProductName
        '
        Me.tbProductName.Location = New System.Drawing.Point(257, 12)
        Me.tbProductName.Name = "tbProductName"
        Me.tbProductName.Size = New System.Drawing.Size(493, 23)
        Me.tbProductName.TabIndex = 1
        '
        'lbProductName
        '
        Me.lbProductName.AutoSize = True
        Me.lbProductName.Location = New System.Drawing.Point(13, 15)
        Me.lbProductName.Name = "lbProductName"
        Me.lbProductName.Size = New System.Drawing.Size(181, 17)
        Me.lbProductName.TabIndex = 0
        Me.lbProductName.Text = "产品名称（ro.product.name)："
        '
        'tpVersion
        '
        Me.tpVersion.Controls.Add(Me.lbVersionState)
        Me.tpVersion.Controls.Add(Me.btVersion)
        Me.tpVersion.Controls.Add(Me.tbVersion)
        Me.tpVersion.Controls.Add(Me.lbVersion)
        Me.tpVersion.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.tpVersion.Location = New System.Drawing.Point(4, 26)
        Me.tpVersion.Name = "tpVersion"
        Me.tpVersion.Padding = New System.Windows.Forms.Padding(3)
        Me.tpVersion.Size = New System.Drawing.Size(815, 456)
        Me.tpVersion.TabIndex = 1
        Me.tpVersion.Text = "版本号"
        Me.tpVersion.UseVisualStyleBackColor = True
        '
        'lbVersionState
        '
        Me.lbVersionState.AutoSize = True
        Me.lbVersionState.BackColor = System.Drawing.Color.Transparent
        Me.lbVersionState.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbVersionState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbVersionState.Location = New System.Drawing.Point(772, 41)
        Me.lbVersionState.Name = "lbVersionState"
        Me.lbVersionState.Size = New System.Drawing.Size(37, 17)
        Me.lbVersionState.TabIndex = 3
        Me.lbVersionState.Text = "PASS"
        Me.lbVersionState.Visible = False
        '
        'btVersion
        '
        Me.btVersion.Location = New System.Drawing.Point(6, 75)
        Me.btVersion.Name = "btVersion"
        Me.btVersion.Size = New System.Drawing.Size(75, 23)
        Me.btVersion.TabIndex = 2
        Me.btVersion.Text = "设置"
        Me.btVersion.UseVisualStyleBackColor = True
        '
        'tbVersion
        '
        Me.tbVersion.Location = New System.Drawing.Point(6, 33)
        Me.tbVersion.Name = "tbVersion"
        Me.tbVersion.Size = New System.Drawing.Size(760, 23)
        Me.tbVersion.TabIndex = 1
        '
        'lbVersion
        '
        Me.lbVersion.AutoSize = True
        Me.lbVersion.Location = New System.Drawing.Point(6, 13)
        Me.lbVersion.Name = "lbVersion"
        Me.lbVersion.Size = New System.Drawing.Size(355, 17)
        Me.lbVersion.TabIndex = 0
        Me.lbVersion.Text = "版本号：（例如：UMIDIGI_G3 Tab_V1.0_`date +%Y%m%d`）"
        '
        'tpFingerprint
        '
        Me.tpFingerprint.Controls.Add(Me.btFingerprintSet)
        Me.tpFingerprint.Controls.Add(Me.btRandom)
        Me.tpFingerprint.Controls.Add(Me.lbFingerprintState)
        Me.tpFingerprint.Controls.Add(Me.tbFingerprint)
        Me.tpFingerprint.Controls.Add(Me.lbFingerprint)
        Me.tpFingerprint.Location = New System.Drawing.Point(4, 26)
        Me.tpFingerprint.Name = "tpFingerprint"
        Me.tpFingerprint.Size = New System.Drawing.Size(815, 456)
        Me.tpFingerprint.TabIndex = 2
        Me.tpFingerprint.Text = "Fingerprint"
        Me.tpFingerprint.UseVisualStyleBackColor = True
        '
        'btFingerprintSet
        '
        Me.btFingerprintSet.Location = New System.Drawing.Point(6, 76)
        Me.btFingerprintSet.Name = "btFingerprintSet"
        Me.btFingerprintSet.Size = New System.Drawing.Size(75, 23)
        Me.btFingerprintSet.TabIndex = 4
        Me.btFingerprintSet.Text = "设置"
        Me.btFingerprintSet.UseVisualStyleBackColor = True
        '
        'btRandom
        '
        Me.btRandom.Location = New System.Drawing.Point(685, 35)
        Me.btRandom.Name = "btRandom"
        Me.btRandom.Size = New System.Drawing.Size(75, 23)
        Me.btRandom.TabIndex = 3
        Me.btRandom.Text = "随机生成"
        Me.btRandom.UseVisualStyleBackColor = True
        '
        'lbFingerprintState
        '
        Me.lbFingerprintState.AutoSize = True
        Me.lbFingerprintState.ForeColor = System.Drawing.Color.Green
        Me.lbFingerprintState.Location = New System.Drawing.Point(766, 38)
        Me.lbFingerprintState.Name = "lbFingerprintState"
        Me.lbFingerprintState.Size = New System.Drawing.Size(37, 17)
        Me.lbFingerprintState.TabIndex = 2
        Me.lbFingerprintState.Text = "PASS"
        '
        'tbFingerprint
        '
        Me.tbFingerprint.Location = New System.Drawing.Point(6, 35)
        Me.tbFingerprint.Name = "tbFingerprint"
        Me.tbFingerprint.Size = New System.Drawing.Size(673, 23)
        Me.tbFingerprint.TabIndex = 1
        '
        'lbFingerprint
        '
        Me.lbFingerprint.AutoSize = True
        Me.lbFingerprint.Location = New System.Drawing.Point(6, 13)
        Me.lbFingerprint.Name = "lbFingerprint"
        Me.lbFingerprint.Size = New System.Drawing.Size(83, 17)
        Me.lbFingerprint.TabIndex = 0
        Me.lbFingerprint.Text = "Fingerprint："
        '
        'tpWifi
        '
        Me.tpWifi.Controls.Add(Me.btWifiSetting)
        Me.tpWifi.Controls.Add(Me.lbWifiScreenCastState)
        Me.tpWifi.Controls.Add(Me.lbWifiHotspotNameState)
        Me.tpWifi.Controls.Add(Me.lbWifiStatusState)
        Me.tpWifi.Controls.Add(Me.tbWifiScreenCast)
        Me.tpWifi.Controls.Add(Me.tbWifiHotspotName)
        Me.tpWifi.Controls.Add(Me.lbWifiScreenCast)
        Me.tpWifi.Controls.Add(Me.lbWifiHotspotName)
        Me.tpWifi.Controls.Add(Me.rbWifiClose)
        Me.tpWifi.Controls.Add(Me.rbWifiOpen)
        Me.tpWifi.Controls.Add(Me.lbWifiStatus)
        Me.tpWifi.Location = New System.Drawing.Point(4, 26)
        Me.tpWifi.Name = "tpWifi"
        Me.tpWifi.Size = New System.Drawing.Size(815, 456)
        Me.tpWifi.TabIndex = 4
        Me.tpWifi.Text = "WiFi"
        Me.tpWifi.UseVisualStyleBackColor = True
        '
        'btWifiSetting
        '
        Me.btWifiSetting.Location = New System.Drawing.Point(14, 149)
        Me.btWifiSetting.Name = "btWifiSetting"
        Me.btWifiSetting.Size = New System.Drawing.Size(75, 23)
        Me.btWifiSetting.TabIndex = 5
        Me.btWifiSetting.Text = "设置"
        Me.btWifiSetting.UseVisualStyleBackColor = True
        '
        'lbWifiScreenCastState
        '
        Me.lbWifiScreenCastState.AutoSize = True
        Me.lbWifiScreenCastState.Location = New System.Drawing.Point(757, 100)
        Me.lbWifiScreenCastState.Name = "lbWifiScreenCastState"
        Me.lbWifiScreenCastState.Size = New System.Drawing.Size(37, 17)
        Me.lbWifiScreenCastState.TabIndex = 4
        Me.lbWifiScreenCastState.Text = "PASS"
        '
        'lbWifiHotspotNameState
        '
        Me.lbWifiHotspotNameState.AutoSize = True
        Me.lbWifiHotspotNameState.Location = New System.Drawing.Point(757, 59)
        Me.lbWifiHotspotNameState.Name = "lbWifiHotspotNameState"
        Me.lbWifiHotspotNameState.Size = New System.Drawing.Size(37, 17)
        Me.lbWifiHotspotNameState.TabIndex = 4
        Me.lbWifiHotspotNameState.Text = "PASS"
        '
        'lbWifiStatusState
        '
        Me.lbWifiStatusState.AutoSize = True
        Me.lbWifiStatusState.Location = New System.Drawing.Point(757, 22)
        Me.lbWifiStatusState.Name = "lbWifiStatusState"
        Me.lbWifiStatusState.Size = New System.Drawing.Size(37, 17)
        Me.lbWifiStatusState.TabIndex = 4
        Me.lbWifiStatusState.Text = "PASS"
        '
        'tbWifiScreenCast
        '
        Me.tbWifiScreenCast.Location = New System.Drawing.Point(116, 97)
        Me.tbWifiScreenCast.Name = "tbWifiScreenCast"
        Me.tbWifiScreenCast.Size = New System.Drawing.Size(619, 23)
        Me.tbWifiScreenCast.TabIndex = 3
        '
        'tbWifiHotspotName
        '
        Me.tbWifiHotspotName.Location = New System.Drawing.Point(116, 56)
        Me.tbWifiHotspotName.Name = "tbWifiHotspotName"
        Me.tbWifiHotspotName.Size = New System.Drawing.Size(619, 23)
        Me.tbWifiHotspotName.TabIndex = 3
        '
        'lbWifiScreenCast
        '
        Me.lbWifiScreenCast.AutoSize = True
        Me.lbWifiScreenCast.Location = New System.Drawing.Point(14, 100)
        Me.lbWifiScreenCast.Name = "lbWifiScreenCast"
        Me.lbWifiScreenCast.Size = New System.Drawing.Size(96, 17)
        Me.lbWifiScreenCast.TabIndex = 2
        Me.lbWifiScreenCast.Text = "WiFi 投屏名称："
        '
        'lbWifiHotspotName
        '
        Me.lbWifiHotspotName.AutoSize = True
        Me.lbWifiHotspotName.Location = New System.Drawing.Point(14, 59)
        Me.lbWifiHotspotName.Name = "lbWifiHotspotName"
        Me.lbWifiHotspotName.Size = New System.Drawing.Size(96, 17)
        Me.lbWifiHotspotName.TabIndex = 2
        Me.lbWifiHotspotName.Text = "WiFi 热点名称："
        '
        'rbWifiClose
        '
        Me.rbWifiClose.AutoSize = True
        Me.rbWifiClose.Checked = True
        Me.rbWifiClose.Location = New System.Drawing.Point(204, 18)
        Me.rbWifiClose.Name = "rbWifiClose"
        Me.rbWifiClose.Size = New System.Drawing.Size(50, 21)
        Me.rbWifiClose.TabIndex = 1
        Me.rbWifiClose.TabStop = True
        Me.rbWifiClose.Text = "关闭"
        Me.rbWifiClose.UseVisualStyleBackColor = True
        '
        'rbWifiOpen
        '
        Me.rbWifiOpen.AutoSize = True
        Me.rbWifiOpen.Location = New System.Drawing.Point(116, 18)
        Me.rbWifiOpen.Name = "rbWifiOpen"
        Me.rbWifiOpen.Size = New System.Drawing.Size(50, 21)
        Me.rbWifiOpen.TabIndex = 1
        Me.rbWifiOpen.TabStop = True
        Me.rbWifiOpen.Text = "打开"
        Me.rbWifiOpen.UseVisualStyleBackColor = True
        '
        'lbWifiStatus
        '
        Me.lbWifiStatus.AutoSize = True
        Me.lbWifiStatus.Location = New System.Drawing.Point(14, 20)
        Me.lbWifiStatus.Name = "lbWifiStatus"
        Me.lbWifiStatus.Size = New System.Drawing.Size(96, 17)
        Me.lbWifiStatus.TabIndex = 0
        Me.lbWifiStatus.Text = "WiFi 默认状态："
        '
        'tpBluetooth
        '
        Me.tpBluetooth.Controls.Add(Me.btBluetoothSetting)
        Me.tpBluetooth.Controls.Add(Me.tbBluetoothName)
        Me.tpBluetooth.Controls.Add(Me.rbBluetoothClose)
        Me.tpBluetooth.Controls.Add(Me.rbBluetoothOpen)
        Me.tpBluetooth.Controls.Add(Me.lbBluetoothNameState)
        Me.tpBluetooth.Controls.Add(Me.lbBluetoothName)
        Me.tpBluetooth.Controls.Add(Me.lbBluetoothStatusState)
        Me.tpBluetooth.Controls.Add(Me.lbBluetoothStatus)
        Me.tpBluetooth.Location = New System.Drawing.Point(4, 26)
        Me.tpBluetooth.Name = "tpBluetooth"
        Me.tpBluetooth.Size = New System.Drawing.Size(815, 456)
        Me.tpBluetooth.TabIndex = 5
        Me.tpBluetooth.Text = "蓝牙"
        Me.tpBluetooth.UseVisualStyleBackColor = True
        '
        'btBluetoothSetting
        '
        Me.btBluetoothSetting.Location = New System.Drawing.Point(20, 111)
        Me.btBluetoothSetting.Name = "btBluetoothSetting"
        Me.btBluetoothSetting.Size = New System.Drawing.Size(75, 23)
        Me.btBluetoothSetting.TabIndex = 3
        Me.btBluetoothSetting.Text = "设置"
        Me.btBluetoothSetting.UseVisualStyleBackColor = True
        '
        'tbBluetoothName
        '
        Me.tbBluetoothName.Location = New System.Drawing.Point(94, 59)
        Me.tbBluetoothName.Name = "tbBluetoothName"
        Me.tbBluetoothName.Size = New System.Drawing.Size(644, 23)
        Me.tbBluetoothName.TabIndex = 2
        '
        'rbBluetoothClose
        '
        Me.rbBluetoothClose.AutoSize = True
        Me.rbBluetoothClose.Checked = True
        Me.rbBluetoothClose.Location = New System.Drawing.Point(243, 21)
        Me.rbBluetoothClose.Name = "rbBluetoothClose"
        Me.rbBluetoothClose.Size = New System.Drawing.Size(50, 21)
        Me.rbBluetoothClose.TabIndex = 1
        Me.rbBluetoothClose.TabStop = True
        Me.rbBluetoothClose.Text = "关闭"
        Me.rbBluetoothClose.UseVisualStyleBackColor = True
        '
        'rbBluetoothOpen
        '
        Me.rbBluetoothOpen.AutoSize = True
        Me.rbBluetoothOpen.Location = New System.Drawing.Point(118, 21)
        Me.rbBluetoothOpen.Name = "rbBluetoothOpen"
        Me.rbBluetoothOpen.Size = New System.Drawing.Size(50, 21)
        Me.rbBluetoothOpen.TabIndex = 1
        Me.rbBluetoothOpen.Text = "打开"
        Me.rbBluetoothOpen.UseVisualStyleBackColor = True
        '
        'lbBluetoothNameState
        '
        Me.lbBluetoothNameState.AutoSize = True
        Me.lbBluetoothNameState.Location = New System.Drawing.Point(759, 62)
        Me.lbBluetoothNameState.Name = "lbBluetoothNameState"
        Me.lbBluetoothNameState.Size = New System.Drawing.Size(37, 17)
        Me.lbBluetoothNameState.TabIndex = 0
        Me.lbBluetoothNameState.Text = "PASS"
        '
        'lbBluetoothName
        '
        Me.lbBluetoothName.AutoSize = True
        Me.lbBluetoothName.Location = New System.Drawing.Point(20, 65)
        Me.lbBluetoothName.Name = "lbBluetoothName"
        Me.lbBluetoothName.Size = New System.Drawing.Size(68, 17)
        Me.lbBluetoothName.TabIndex = 0
        Me.lbBluetoothName.Text = "蓝牙名称："
        '
        'lbBluetoothStatusState
        '
        Me.lbBluetoothStatusState.AutoSize = True
        Me.lbBluetoothStatusState.Location = New System.Drawing.Point(759, 23)
        Me.lbBluetoothStatusState.Name = "lbBluetoothStatusState"
        Me.lbBluetoothStatusState.Size = New System.Drawing.Size(37, 17)
        Me.lbBluetoothStatusState.TabIndex = 0
        Me.lbBluetoothStatusState.Text = "PASS"
        '
        'lbBluetoothStatus
        '
        Me.lbBluetoothStatus.AutoSize = True
        Me.lbBluetoothStatus.Location = New System.Drawing.Point(20, 23)
        Me.lbBluetoothStatus.Name = "lbBluetoothStatus"
        Me.lbBluetoothStatus.Size = New System.Drawing.Size(92, 17)
        Me.lbBluetoothStatus.TabIndex = 0
        Me.lbBluetoothStatus.Text = "蓝牙默认状态："
        '
        'tpLanguage
        '
        Me.tpLanguage.Controls.Add(Me.btLanguageSetting)
        Me.tpLanguage.Controls.Add(Me.cbLanguage)
        Me.tpLanguage.Controls.Add(Me.lbLanguageState)
        Me.tpLanguage.Controls.Add(Me.Label1)
        Me.tpLanguage.Location = New System.Drawing.Point(4, 26)
        Me.tpLanguage.Name = "tpLanguage"
        Me.tpLanguage.Size = New System.Drawing.Size(815, 456)
        Me.tpLanguage.TabIndex = 6
        Me.tpLanguage.Text = "语言"
        Me.tpLanguage.UseVisualStyleBackColor = True
        '
        'btLanguageSetting
        '
        Me.btLanguageSetting.Location = New System.Drawing.Point(13, 67)
        Me.btLanguageSetting.Name = "btLanguageSetting"
        Me.btLanguageSetting.Size = New System.Drawing.Size(75, 23)
        Me.btLanguageSetting.TabIndex = 4
        Me.btLanguageSetting.Text = "设置"
        Me.btLanguageSetting.UseVisualStyleBackColor = True
        '
        'cbLanguage
        '
        Me.cbLanguage.FormattingEnabled = True
        Me.cbLanguage.Location = New System.Drawing.Point(63, 16)
        Me.cbLanguage.Name = "cbLanguage"
        Me.cbLanguage.Size = New System.Drawing.Size(667, 25)
        Me.cbLanguage.TabIndex = 2
        '
        'lbLanguageState
        '
        Me.lbLanguageState.AutoSize = True
        Me.lbLanguageState.Location = New System.Drawing.Point(752, 19)
        Me.lbLanguageState.Name = "lbLanguageState"
        Me.lbLanguageState.Size = New System.Drawing.Size(37, 17)
        Me.lbLanguageState.TabIndex = 0
        Me.lbLanguageState.Text = "PASS"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "语言："
        '
        'tpTimezone
        '
        Me.tpTimezone.Controls.Add(Me.cbTimezone)
        Me.tpTimezone.Controls.Add(Me.lbTimezoneState)
        Me.tpTimezone.Controls.Add(Me.lbTimezone)
        Me.tpTimezone.Controls.Add(Me.btTimezoneSetting)
        Me.tpTimezone.Location = New System.Drawing.Point(4, 26)
        Me.tpTimezone.Name = "tpTimezone"
        Me.tpTimezone.Size = New System.Drawing.Size(815, 456)
        Me.tpTimezone.TabIndex = 7
        Me.tpTimezone.Text = "时区"
        Me.tpTimezone.UseVisualStyleBackColor = True
        '
        'cbTimezone
        '
        Me.cbTimezone.FormattingEnabled = True
        Me.cbTimezone.Location = New System.Drawing.Point(63, 16)
        Me.cbTimezone.Name = "cbTimezone"
        Me.cbTimezone.Size = New System.Drawing.Size(667, 25)
        Me.cbTimezone.TabIndex = 8
        '
        'lbTimezoneState
        '
        Me.lbTimezoneState.AutoSize = True
        Me.lbTimezoneState.Location = New System.Drawing.Point(752, 19)
        Me.lbTimezoneState.Name = "lbTimezoneState"
        Me.lbTimezoneState.Size = New System.Drawing.Size(37, 17)
        Me.lbTimezoneState.TabIndex = 6
        Me.lbTimezoneState.Text = "PASS"
        '
        'lbTimezone
        '
        Me.lbTimezone.AutoSize = True
        Me.lbTimezone.Location = New System.Drawing.Point(13, 19)
        Me.lbTimezone.Name = "lbTimezone"
        Me.lbTimezone.Size = New System.Drawing.Size(44, 17)
        Me.lbTimezone.TabIndex = 7
        Me.lbTimezone.Text = "时区："
        '
        'btTimezoneSetting
        '
        Me.btTimezoneSetting.Location = New System.Drawing.Point(13, 67)
        Me.btTimezoneSetting.Name = "btTimezoneSetting"
        Me.btTimezoneSetting.Size = New System.Drawing.Size(75, 23)
        Me.btTimezoneSetting.TabIndex = 5
        Me.btTimezoneSetting.Text = "设置"
        Me.btTimezoneSetting.UseVisualStyleBackColor = True
        '
        'AndroidSettingsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(847, 508)
        Me.Controls.Add(Me.tcAndroidSettings)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "AndroidSettingsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Android 工程配置"
        Me.tcAndroidSettings.ResumeLayout(False)
        Me.tpProjectInfo.ResumeLayout(False)
        Me.GbChiperOptions.ResumeLayout(False)
        Me.GbChiperOptions.PerformLayout()
        Me.GbGoOptions.ResumeLayout(False)
        Me.GbGoOptions.PerformLayout()
        Me.GbGmsOptions.ResumeLayout(False)
        Me.GbGmsOptions.PerformLayout()
        Me.GBProject.ResumeLayout(False)
        Me.GBProject.PerformLayout()
        Me.tpProperty.ResumeLayout(False)
        Me.tpProperty.PerformLayout()
        Me.tpVersion.ResumeLayout(False)
        Me.tpVersion.PerformLayout()
        Me.tpFingerprint.ResumeLayout(False)
        Me.tpFingerprint.PerformLayout()
        Me.tpWifi.ResumeLayout(False)
        Me.tpWifi.PerformLayout()
        Me.tpBluetooth.ResumeLayout(False)
        Me.tpBluetooth.PerformLayout()
        Me.tpLanguage.ResumeLayout(False)
        Me.tpLanguage.PerformLayout()
        Me.tpTimezone.ResumeLayout(False)
        Me.tpTimezone.PerformLayout()
        Me.ResumeLayout(False)

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
End Class
