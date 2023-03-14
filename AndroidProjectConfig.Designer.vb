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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
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
        Me.TBProjectPath = New System.Windows.Forms.TextBox()
        Me.LbProjectPath = New System.Windows.Forms.Label()
        Me.CBProjectId = New System.Windows.Forms.ComboBox()
        Me.LbProjectId = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.FbdSelectPath = New System.Windows.Forms.FolderBrowserDialog()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GbChiperOptions.SuspendLayout()
        Me.GbGoOptions.SuspendLayout()
        Me.GbGmsOptions.SuspendLayout()
        Me.GBProject.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(823, 486)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GbChiperOptions)
        Me.TabPage1.Controls.Add(Me.GbGoOptions)
        Me.TabPage1.Controls.Add(Me.GbGmsOptions)
        Me.TabPage1.Controls.Add(Me.GBProject)
        Me.TabPage1.Location = New System.Drawing.Point(4, 26)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(815, 456)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "工程信息"
        Me.TabPage1.UseVisualStyleBackColor = True
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
        Me.CbChiperMaker.Items.AddRange(New Object() {"MTK", "UNISOC"})
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
        Me.GBProject.Controls.Add(Me.TBProjectPath)
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
        'TBProjectPath
        '
        Me.TBProjectPath.Location = New System.Drawing.Point(104, 98)
        Me.TBProjectPath.Name = "TBProjectPath"
        Me.TBProjectPath.Size = New System.Drawing.Size(612, 23)
        Me.TBProjectPath.TabIndex = 3
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
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 26)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(815, 456)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'AndroidSettingsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(847, 508)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "AndroidSettingsForm"
        Me.Text = "Android 工程配置"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GbChiperOptions.ResumeLayout(False)
        Me.GbChiperOptions.PerformLayout()
        Me.GbGoOptions.ResumeLayout(False)
        Me.GbGoOptions.PerformLayout()
        Me.GbGmsOptions.ResumeLayout(False)
        Me.GbGmsOptions.PerformLayout()
        Me.GBProject.ResumeLayout(False)
        Me.GBProject.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents GBProject As GroupBox
    Friend WithEvents CbAndroidVersin As ComboBox
    Friend WithEvents LbAndroidVersion As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LbDriveName As Label
    Friend WithEvents LbMssiName As Label
    Friend WithEvents LbPublicName As Label
    Friend WithEvents BtSelectProjectPath As Button
    Friend WithEvents TBProjectPath As TextBox
    Friend WithEvents LbProjectPath As Label
    Friend WithEvents CBProjectId As ComboBox
    Friend WithEvents LbProjectId As Label
    Friend WithEvents TabPage2 As TabPage
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
End Class
