' FingerprintController 模块用于管理 Fingerprint 
Module FingerprintController

    ' 更新 Fingerprint 选项卡视图控件信息
    '
    ' form：AndroidSettingsForm 对象
    Public Sub UpdateFingerprintInfo(ByRef form As AndroidSettingsForm)
        Debug.WriteLine("[FingerprintController] UpdateFingerprintInfo()...")
        form.lbFingerprintState.Visible = False
        form.tbFingerprint.Text = Fingerprint.GetFingerprint(form.MyProjectInfo)
    End Sub

    ' 设置 fingerprint
    '
    ' form：AndroidSettingsForm 对象
    Public Sub SetFingerprint(ByRef form As AndroidSettingsForm)
        Dim fp As String = form.tbFingerprint.Text
        If Not Utils.IsEmptyText(fp) And Fingerprint.SetFingerprint(form.MyProjectInfo, fp) Then
            form.lbFingerprintState.Text = "PASS"
            form.lbFingerprintState.ForeColor = Color.Green
            form.lbFingerprintState.Visible = True
        Else
            form.lbFingerprintState.Text = "FAIL"
            form.lbFingerprintState.ForeColor = Color.Red
            form.lbFingerprintState.Visible = True
        End If
    End Sub

End Module
