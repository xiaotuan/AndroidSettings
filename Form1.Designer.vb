<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.cbAndroidVersion = New System.Windows.Forms.ComboBox()
        Me.tbTaskNumber = New System.Windows.Forms.TextBox()
        Me.tbPublicName = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cbChiper = New System.Windows.Forms.ComboBox()
        Me.cbChiperMode = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rbTwoGBGo = New System.Windows.Forms.RadioButton()
        Me.rbOneGBGo = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbGo = New System.Windows.Forms.RadioButton()
        Me.rbGms = New System.Windows.Forms.RadioButton()
        Me.btNotGms = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btCustomSelectDir = New System.Windows.Forms.Button()
        Me.btDriveSelectDir = New System.Windows.Forms.Button()
        Me.btProjectSelectDir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbCustomDir = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbDriveDir = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbProjectDir = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.TabPage8 = New System.Windows.Forms.TabPage()
        Me.TabPage9 = New System.Windows.Forms.TabPage()
        Me.TabPage10 = New System.Windows.Forms.TabPage()
        Me.TabPage11 = New System.Windows.Forms.TabPage()
        Me.TabPage12 = New System.Windows.Forms.TabPage()
        Me.TabPage13 = New System.Windows.Forms.TabPage()
        Me.fbdDirSelectDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Controls.Add(Me.TabPage7)
        Me.TabControl1.Controls.Add(Me.TabPage8)
        Me.TabControl1.Controls.Add(Me.TabPage9)
        Me.TabControl1.Controls.Add(Me.TabPage10)
        Me.TabControl1.Controls.Add(Me.TabPage11)
        Me.TabControl1.Controls.Add(Me.TabPage12)
        Me.TabControl1.Controls.Add(Me.TabPage13)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(860, 537)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox5)
        Me.TabPage1.Controls.Add(Me.GroupBox4)
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 26)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(852, 507)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Android 工程信息"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.cbAndroidVersion)
        Me.GroupBox5.Controls.Add(Me.tbTaskNumber)
        Me.GroupBox5.Controls.Add(Me.tbPublicName)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Location = New System.Drawing.Point(6, 350)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(840, 141)
        Me.GroupBox5.TabIndex = 6
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "其他选项"
        '
        'cbAndroidVersion
        '
        Me.cbAndroidVersion.FormattingEnabled = True
        Me.cbAndroidVersion.Items.AddRange(New Object() {"Android R", "Android S", "Android T"})
        Me.cbAndroidVersion.Location = New System.Drawing.Point(108, 82)
        Me.cbAndroidVersion.Name = "cbAndroidVersion"
        Me.cbAndroidVersion.Size = New System.Drawing.Size(726, 25)
        Me.cbAndroidVersion.TabIndex = 2
        Me.cbAndroidVersion.Text = "Android S"
        '
        'tbTaskNumber
        '
        Me.tbTaskNumber.Location = New System.Drawing.Point(108, 54)
        Me.tbTaskNumber.Name = "tbTaskNumber"
        Me.tbTaskNumber.Size = New System.Drawing.Size(726, 23)
        Me.tbTaskNumber.TabIndex = 1
        '
        'tbPublicName
        '
        Me.tbPublicName.Location = New System.Drawing.Point(108, 25)
        Me.tbPublicName.Name = "tbPublicName"
        Me.tbPublicName.Size = New System.Drawing.Size(726, 23)
        Me.tbPublicName.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 28)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 17)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "公版名称："
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 57)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 17)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "禅道任务号："
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 85)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 17)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Android 版本号："
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cbChiper)
        Me.GroupBox4.Controls.Add(Me.cbChiperMode)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 254)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(840, 90)
        Me.GroupBox4.TabIndex = 5
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "芯片选项"
        '
        'cbChiper
        '
        Me.cbChiper.FormattingEnabled = True
        Me.cbChiper.Items.AddRange(New Object() {"Mediatek"})
        Me.cbChiper.Location = New System.Drawing.Point(68, 25)
        Me.cbChiper.Name = "cbChiper"
        Me.cbChiper.Size = New System.Drawing.Size(766, 25)
        Me.cbChiper.TabIndex = 1
        Me.cbChiper.Text = "Mediatek"
        '
        'cbChiperMode
        '
        Me.cbChiperMode.FormattingEnabled = True
        Me.cbChiperMode.Items.AddRange(New Object() {"8788", "8766", "8765", "8168"})
        Me.cbChiperMode.Location = New System.Drawing.Point(68, 57)
        Me.cbChiperMode.Name = "cbChiperMode"
        Me.cbChiperMode.Size = New System.Drawing.Size(766, 25)
        Me.cbChiperMode.TabIndex = 1
        Me.cbChiperMode.Text = "8768"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 60)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 17)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "芯片型号："
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 17)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "芯片厂商："
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rbTwoGBGo)
        Me.GroupBox3.Controls.Add(Me.rbOneGBGo)
        Me.GroupBox3.Enabled = False
        Me.GroupBox3.Location = New System.Drawing.Point(6, 198)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(840, 50)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "GO 选项"
        '
        'rbTwoGBGo
        '
        Me.rbTwoGBGo.AutoSize = True
        Me.rbTwoGBGo.Location = New System.Drawing.Point(366, 22)
        Me.rbTwoGBGo.Name = "rbTwoGBGo"
        Me.rbTwoGBGo.Size = New System.Drawing.Size(73, 21)
        Me.rbTwoGBGo.TabIndex = 0
        Me.rbTwoGBGo.Text = "2GB GO"
        Me.rbTwoGBGo.UseVisualStyleBackColor = True
        '
        'rbOneGBGo
        '
        Me.rbOneGBGo.AutoSize = True
        Me.rbOneGBGo.Checked = True
        Me.rbOneGBGo.Location = New System.Drawing.Point(6, 22)
        Me.rbOneGBGo.Name = "rbOneGBGo"
        Me.rbOneGBGo.Size = New System.Drawing.Size(73, 21)
        Me.rbOneGBGo.TabIndex = 0
        Me.rbOneGBGo.TabStop = True
        Me.rbOneGBGo.Text = "1GB GO"
        Me.rbOneGBGo.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbGo)
        Me.GroupBox2.Controls.Add(Me.rbGms)
        Me.GroupBox2.Controls.Add(Me.btNotGms)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 141)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(840, 50)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GMS 选项"
        '
        'rbGo
        '
        Me.rbGo.AutoSize = True
        Me.rbGo.Location = New System.Drawing.Point(729, 22)
        Me.rbGo.Name = "rbGo"
        Me.rbGo.Size = New System.Drawing.Size(45, 21)
        Me.rbGo.TabIndex = 0
        Me.rbGo.Text = "GO"
        Me.rbGo.UseVisualStyleBackColor = True
        '
        'rbGms
        '
        Me.rbGms.AutoSize = True
        Me.rbGms.Checked = True
        Me.rbGms.Location = New System.Drawing.Point(366, 22)
        Me.rbGms.Name = "rbGms"
        Me.rbGms.Size = New System.Drawing.Size(54, 21)
        Me.rbGms.TabIndex = 0
        Me.rbGms.TabStop = True
        Me.rbGms.Text = "GMS"
        Me.rbGms.UseVisualStyleBackColor = True
        '
        'btNotGms
        '
        Me.btNotGms.AutoSize = True
        Me.btNotGms.Location = New System.Drawing.Point(6, 22)
        Me.btNotGms.Name = "btNotGms"
        Me.btNotGms.Size = New System.Drawing.Size(80, 21)
        Me.btNotGms.TabIndex = 0
        Me.btNotGms.Text = "Not GMS"
        Me.btNotGms.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btCustomSelectDir)
        Me.GroupBox1.Controls.Add(Me.btDriveSelectDir)
        Me.GroupBox1.Controls.Add(Me.btProjectSelectDir)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.tbCustomDir)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.tbDriveDir)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.tbProjectDir)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(840, 129)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "路径选项"
        '
        'btCustomSelectDir
        '
        Me.btCustomSelectDir.Location = New System.Drawing.Point(759, 94)
        Me.btCustomSelectDir.Name = "btCustomSelectDir"
        Me.btCustomSelectDir.Size = New System.Drawing.Size(75, 23)
        Me.btCustomSelectDir.TabIndex = 2
        Me.btCustomSelectDir.Text = "选择"
        Me.btCustomSelectDir.UseVisualStyleBackColor = True
        '
        'btDriveSelectDir
        '
        Me.btDriveSelectDir.Location = New System.Drawing.Point(759, 59)
        Me.btDriveSelectDir.Name = "btDriveSelectDir"
        Me.btDriveSelectDir.Size = New System.Drawing.Size(75, 23)
        Me.btDriveSelectDir.TabIndex = 2
        Me.btDriveSelectDir.Text = "选择"
        Me.btDriveSelectDir.UseVisualStyleBackColor = True
        '
        'btProjectSelectDir
        '
        Me.btProjectSelectDir.Location = New System.Drawing.Point(759, 26)
        Me.btProjectSelectDir.Name = "btProjectSelectDir"
        Me.btProjectSelectDir.Size = New System.Drawing.Size(75, 23)
        Me.btProjectSelectDir.TabIndex = 2
        Me.btProjectSelectDir.Text = "选择"
        Me.btProjectSelectDir.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "工程目录："
        '
        'tbCustomDir
        '
        Me.tbCustomDir.Location = New System.Drawing.Point(80, 94)
        Me.tbCustomDir.Name = "tbCustomDir"
        Me.tbCustomDir.Size = New System.Drawing.Size(673, 23)
        Me.tbCustomDir.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "驱动路径："
        '
        'tbDriveDir
        '
        Me.tbDriveDir.Location = New System.Drawing.Point(80, 59)
        Me.tbDriveDir.Name = "tbDriveDir"
        Me.tbDriveDir.Size = New System.Drawing.Size(673, 23)
        Me.tbDriveDir.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "驱动目录："
        '
        'tbProjectDir
        '
        Me.tbProjectDir.Location = New System.Drawing.Point(80, 26)
        Me.tbProjectDir.Name = "tbProjectDir"
        Me.tbProjectDir.Size = New System.Drawing.Size(673, 23)
        Me.tbProjectDir.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 17)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "客制化目录："
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 26)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(852, 507)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "版本号"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Location = New System.Drawing.Point(4, 26)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(852, 507)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Fingerprint"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Location = New System.Drawing.Point(4, 26)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(852, 507)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Logo"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'TabPage5
        '
        Me.TabPage5.Location = New System.Drawing.Point(4, 26)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(852, 507)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "内置 APK"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'TabPage6
        '
        Me.TabPage6.Location = New System.Drawing.Point(4, 26)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(852, 507)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "送样配置"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'TabPage7
        '
        Me.TabPage7.Location = New System.Drawing.Point(4, 26)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Size = New System.Drawing.Size(852, 507)
        Me.TabPage7.TabIndex = 6
        Me.TabPage7.Text = "壁纸"
        Me.TabPage7.UseVisualStyleBackColor = True
        '
        'TabPage8
        '
        Me.TabPage8.Location = New System.Drawing.Point(4, 26)
        Me.TabPage8.Name = "TabPage8"
        Me.TabPage8.Size = New System.Drawing.Size(852, 507)
        Me.TabPage8.TabIndex = 7
        Me.TabPage8.Text = "TEE"
        Me.TabPage8.UseVisualStyleBackColor = True
        '
        'TabPage9
        '
        Me.TabPage9.Location = New System.Drawing.Point(4, 26)
        Me.TabPage9.Name = "TabPage9"
        Me.TabPage9.Size = New System.Drawing.Size(852, 507)
        Me.TabPage9.TabIndex = 8
        Me.TabPage9.Text = "设置应用"
        Me.TabPage9.UseVisualStyleBackColor = True
        '
        'TabPage10
        '
        Me.TabPage10.Location = New System.Drawing.Point(4, 26)
        Me.TabPage10.Name = "TabPage10"
        Me.TabPage10.Size = New System.Drawing.Size(852, 507)
        Me.TabPage10.TabIndex = 9
        Me.TabPage10.Text = "SystemUI"
        Me.TabPage10.UseVisualStyleBackColor = True
        '
        'TabPage11
        '
        Me.TabPage11.Location = New System.Drawing.Point(4, 26)
        Me.TabPage11.Name = "TabPage11"
        Me.TabPage11.Size = New System.Drawing.Size(852, 507)
        Me.TabPage11.TabIndex = 10
        Me.TabPage11.Text = "桌面"
        Me.TabPage11.UseVisualStyleBackColor = True
        '
        'TabPage12
        '
        Me.TabPage12.Location = New System.Drawing.Point(4, 26)
        Me.TabPage12.Name = "TabPage12"
        Me.TabPage12.Size = New System.Drawing.Size(852, 507)
        Me.TabPage12.TabIndex = 11
        Me.TabPage12.Text = "其他"
        Me.TabPage12.UseVisualStyleBackColor = True
        '
        'TabPage13
        '
        Me.TabPage13.Location = New System.Drawing.Point(4, 26)
        Me.TabPage13.Name = "TabPage13"
        Me.TabPage13.Size = New System.Drawing.Size(852, 507)
        Me.TabPage13.TabIndex = 12
        Me.TabPage13.Text = "开关机动画"
        Me.TabPage13.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 561)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents TabPage7 As TabPage
    Friend WithEvents TabPage8 As TabPage
    Friend WithEvents TabPage9 As TabPage
    Friend WithEvents TabPage10 As TabPage
    Friend WithEvents TabPage11 As TabPage
    Friend WithEvents TabPage12 As TabPage
    Friend WithEvents TabPage13 As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tbCustomDir As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbDriveDir As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbProjectDir As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents cbAndroidVersion As ComboBox
    Friend WithEvents tbTaskNumber As TextBox
    Friend WithEvents tbPublicName As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents cbChiper As ComboBox
    Friend WithEvents cbChiperMode As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents rbTwoGBGo As RadioButton
    Friend WithEvents rbOneGBGo As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rbGo As RadioButton
    Friend WithEvents rbGms As RadioButton
    Friend WithEvents btNotGms As RadioButton
    Friend WithEvents btCustomSelectDir As Button
    Friend WithEvents btDriveSelectDir As Button
    Friend WithEvents btProjectSelectDir As Button
    Friend WithEvents fbdDirSelectDialog As FolderBrowserDialog
End Class
