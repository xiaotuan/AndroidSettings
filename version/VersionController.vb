' VersionController 模块用于管理版本号选项卡视图
Module VersionController

    ' 更新版本号选项卡视图控件状态
    '
    ' form：AndroidSettingsForm 对象
    Public Sub UpdateVersionInfo(ByRef form As AndroidSettingsForm)
        Debug.WriteLine("[VersionController] UpdateVersionInfo()...")
        form.lbVersionState.Visible = False
        form.tbVersion.Text = Version.GetVersion(form.MyProjectInfo)
    End Sub

    ' 设置软件版本号
    '
    ' form：AndroidSettingsForm 对象
    Public Sub SetVersion(ByRef form As AndroidSettingsForm)
        Dim ver As String = form.tbVersion.Text
        If Not Utils.IsEmptyText(ver) And Version.SetVersion(form.MyProjectInfo, ver) Then
            form.lbVersionState.Text = "PASS"
            form.lbVersionState.ForeColor = Color.Green
            form.lbVersionState.Visible = True
        Else
            form.lbVersionState.Text = "FAIL"
            form.lbVersionState.ForeColor = Color.Red
            form.lbVersionState.Visible = True
        End If
    End Sub
End Module
