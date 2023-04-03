Imports System.Globalization
Imports System.Runtime.CompilerServices
Imports Microsoft.VisualBasic.Devices

Public Class AndroidSettingsForm

    Public MyProjectInfo As ProjectInfo = New ProjectInfo()

    Private Sub androidSettingsForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        For Each Project As ProjectInfo In MyProjects.GetProjects()
            CBProjectId.Items.Add(Project.ProjectId)
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
            TBProjectPath.Text = FbdSelectPath.SelectedPath
            MyProjectInfo.ProjectPath = FbdSelectPath.SelectedPath
        End If
    End Sub

    Private Sub CbAndroidVersin_SelectedIndexChanged(sender As ComboBox, e As EventArgs) Handles CbAndroidVersin.SelectedIndexChanged
        MyProjectInfo.AndroidVersion = sender.SelectedItem
    End Sub

    Private Sub CbAndroidVersin_TextChanged(sender As ComboBox, e As EventArgs) Handles CbAndroidVersin.TextChanged
        MyProjectInfo.AndroidVersion = sender.Text
    End Sub

    Private Sub TBProjectPath_TextChanged(sender As TextBox, e As EventArgs) Handles TBProjectPath.TextChanged
        MyProjectInfo.ProjectPath = sender.Text
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
End Class
