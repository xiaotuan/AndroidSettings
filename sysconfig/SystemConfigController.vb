Module SystemConfigController

    Public Sub UpdateSystemConfigInfos(ByRef form As AndroidSettingsForm)
        form.lbScreenOffTimeStatus.Visible = False
        form.lbAutoRotationStatus.Visible = False
        form.lbAutoTimeStatus.Visible = False
        form.lbGpsStatus.Visible = False
        form.lbAutoBrightnessStatus.Visible = False
        form.lb24TimeFormatStatus.Visible = False
        form.lbDisableScreenlockStatus.Visible = False

        form.tbScreenOffTime.Text = AndroidTSystemConfig.GetScreeOffTime(form.MyProjectInfo)

        If AndroidTSystemConfig.IsAutoRotation(form.MyProjectInfo) Then
            form.cbAutoRotation.Text = "打开"
        Else
            form.cbAutoRotation.Text = "关闭"
        End If

        If AndroidTSystemConfig.IsAutoTime(form.MyProjectInfo) Then
            form.cbAutoTime.Text = "打开"
        Else
            form.cbAutoTime.Text = "关闭"
        End If

        If AndroidTSystemConfig.IsAutoBrightness(form.MyProjectInfo) Then
            form.cbAutoBrightness.Text = "打开"
        Else
            form.cbAutoBrightness.Text = "关闭"
        End If

        If AndroidTSystemConfig.IsGPSOn(form.MyProjectInfo) Then
            form.cbGps.Text = "打开"
        Else
            form.cbGps.Text = "关闭"
        End If

        If AndroidTSystemConfig.Is24TimeFormat(form.MyProjectInfo) Then
            form.cb24TimeFormat.Text = "打开"
        Else
            form.cb24TimeFormat.Text = "关闭"
        End If

        If AndroidTSystemConfig.IsDisableScreenLock(form.MyProjectInfo) Then
            form.cbDisableScreenlock.Text = "打开"
        Else
            form.cbDisableScreenlock.Text = "关闭"
        End If
    End Sub

    Public Sub SetScreenOffTime(ByRef form As AndroidSettingsForm)
        Dim time As String = form.tbScreenOffTime.Text
        If Not Utils.IsEmptyText(time) And AndroidTSystemConfig.SetScreenOffTime(form.MyProjectInfo, time) Then
            form.lbScreenOffTimeStatus.Text = "PASS"
            form.lbScreenOffTimeStatus.ForeColor = Color.Green
            form.lbScreenOffTimeStatus.Visible = True
        Else
            form.lbScreenOffTimeStatus.Text = "FAIL"
            form.lbScreenOffTimeStatus.ForeColor = Color.Red
            form.lbScreenOffTimeStatus.Visible = True
        End If
    End Sub

    Public Sub SetAutoTime(ByRef form As AndroidSettingsForm)
        Dim state As String = "false"
        If "打开".Equals(form.cbAutoTime.Text) Then
            state = "true"
        End If
        If AndroidTSystemConfig.SetAutoTime(form.MyProjectInfo, state) Then
            form.lbAutoTimeStatus.Text = "PASS"
            form.lbAutoTimeStatus.ForeColor = Color.Green
            form.lbAutoTimeStatus.Visible = True
        Else
            form.lbAutoTimeStatus.Text = "FAIL"
            form.lbAutoTimeStatus.ForeColor = Color.Red
            form.lbAutoTimeStatus.Visible = True
        End If
    End Sub

    Public Sub SetAutoRotation(ByRef form As AndroidSettingsForm)
        Dim state As String = "false"
        If "打开".Equals(form.cbAutoRotation.Text) Then
            state = "true"
        End If
        If AndroidTSystemConfig.SetAutoRotation(form.MyProjectInfo, state) Then
            form.lbAutoRotationStatus.Text = "PASS"
            form.lbAutoRotationStatus.ForeColor = Color.Green
            form.lbAutoRotationStatus.Visible = True
        Else
            form.lbAutoRotationStatus.Text = "FAIL"
            form.lbAutoRotationStatus.ForeColor = Color.Red
            form.lbAutoRotationStatus.Visible = True
        End If
    End Sub

    Public Sub SetAutoBrightness(ByRef form As AndroidSettingsForm)
        Dim state As String = "false"
        If "打开".Equals(form.cbAutoBrightness.Text) Then
            state = "true"
        End If
        If AndroidTSystemConfig.SetAutoBrightness(form.MyProjectInfo, state) Then
            form.lbAutoBrightnessStatus.Text = "PASS"
            form.lbAutoBrightnessStatus.ForeColor = Color.Green
            form.lbAutoBrightnessStatus.Visible = True
        Else
            form.lbAutoBrightnessStatus.Text = "FAIL"
            form.lbAutoBrightnessStatus.ForeColor = Color.Red
            form.lbAutoBrightnessStatus.Visible = True
        End If
    End Sub

    Public Sub SetGps(ByRef form As AndroidSettingsForm)
        Dim state As String = "0"
        If "打开".Equals(form.cbGps.Text) Then
            state = "3"
        End If
        If AndroidTSystemConfig.SetGps(form.MyProjectInfo, state) Then
            form.lbGpsStatus.Text = "PASS"
            form.lbGpsStatus.ForeColor = Color.Green
            form.lbGpsStatus.Visible = True
        Else
            form.lbGpsStatus.Text = "FAIL"
            form.lbGpsStatus.ForeColor = Color.Red
            form.lbGpsStatus.Visible = True
        End If
    End Sub

    Public Sub SetDisableScreenLock(ByRef form As AndroidSettingsForm)
        Dim state As String = "false"
        If "打开".Equals(form.cbDisableScreenlock.Text) Then
            state = "true"
        End If
        If AndroidTSystemConfig.SetDisableScreenLock(form.MyProjectInfo, state) Then
            form.lbDisableScreenlockStatus.Text = "PASS"
            form.lbDisableScreenlockStatus.ForeColor = Color.Green
            form.lbDisableScreenlockStatus.Visible = True
        Else
            form.lbDisableScreenlockStatus.Text = "FAIL"
            form.lbDisableScreenlockStatus.ForeColor = Color.Red
            form.lbDisableScreenlockStatus.Visible = True
        End If
    End Sub

    Public Sub Set24TimeFormat(ByRef form As AndroidSettingsForm)
        Dim state As String = "12"
        If "打开".Equals(form.cb24TimeFormat.Text) Then
            state = "24"
        End If
        If AndroidTSystemConfig.Set24TimeFormat(form.MyProjectInfo, state) Then
            form.lb24TimeFormatStatus.Text = "PASS"
            form.lb24TimeFormatStatus.ForeColor = Color.Green
            form.lb24TimeFormatStatus.Visible = True
        Else
            form.lb24TimeFormatStatus.Text = "FAIL"
            form.lb24TimeFormatStatus.ForeColor = Color.Red
            form.lb24TimeFormatStatus.Visible = True
        End If
    End Sub
End Module
