Module VolumeController

    Public Sub UpdateVolumeInfos(ByRef form As AndroidSettingsForm)
        form.lbCallVolumeStatus.Visible = False
        form.lbRingVolumeStatus.Visible = False
        form.lbMusicVolumeStatus.Visible = False
        form.lbAlarmVolumeStatus.Visible = False
        form.lbNotifyVolumeStatus.Visible = False
        form.lbOtherVolumeStatus.Visible = False

        form.cbCallVolume.Text = Volume.GetCallVolume(form.MyProjectInfo)
        form.cbRingVolume.Text = Volume.GetRingVolume(form.MyProjectInfo)
        form.cbMusicVolume.Text = Volume.GetMusicVolume(form.MyProjectInfo)
        form.cbAlarmVolume.Text = Volume.GetAlarmVolume(form.MyProjectInfo)
        form.cbNotifyVolume.Text = Volume.GetNotificationVolume(form.MyProjectInfo)
        form.cbOtherVolume.Text = Volume.GetOtherVolume(form.MyProjectInfo)
    End Sub

    Public Sub SetCallVolume(ByRef form As AndroidSettingsForm)
        Dim callVolume As String = form.cbCallVolume.Text
        If IsNumeric(callVolume) And Volume.SetCallVolume(form.MyProjectInfo, callVolume) Then
            form.lbCallVolumeStatus.Text = "PASS"
            form.lbCallVolumeStatus.ForeColor = Color.Green
            form.lbCallVolumeStatus.Visible = True
        Else
            form.lbCallVolumeStatus.Text = "FAIL"
            form.lbCallVolumeStatus.ForeColor = Color.Red
            form.lbCallVolumeStatus.Visible = True
        End If
    End Sub

    Public Sub SetRingVolume(ByRef form As AndroidSettingsForm)
        Dim ringVolume As String = form.cbRingVolume.Text
        If IsNumeric(ringVolume) And Volume.SetRingVolume(form.MyProjectInfo, ringVolume) Then
            form.lbRingVolumeStatus.Text = "PASS"
            form.lbRingVolumeStatus.ForeColor = Color.Green
            form.lbRingVolumeStatus.Visible = True
        Else
            form.lbRingVolumeStatus.Text = "FAIL"
            form.lbRingVolumeStatus.ForeColor = Color.Red
            form.lbRingVolumeStatus.Visible = True
        End If
    End Sub

    Public Sub SetMusicVolume(ByRef form As AndroidSettingsForm)
        Dim musicVolume As String = form.cbMusicVolume.Text
        If IsNumeric(musicVolume) And Volume.SetMusicVolume(form.MyProjectInfo, musicVolume) Then
            form.lbMusicVolumeStatus.Text = "PASS"
            form.lbMusicVolumeStatus.ForeColor = Color.Green
            form.lbMusicVolumeStatus.Visible = True
        Else
            form.lbMusicVolumeStatus.Text = "FAIL"
            form.lbMusicVolumeStatus.ForeColor = Color.Red
            form.lbMusicVolumeStatus.Visible = True
        End If
    End Sub

    Public Sub SetAlarmVolume(ByRef form As AndroidSettingsForm)
        Dim alarmVolume As String = form.cbAlarmVolume.Text
        If IsNumeric(alarmVolume) And Volume.SetAlarmVolume(form.MyProjectInfo, alarmVolume) Then
            form.lbAlarmVolumeStatus.Text = "PASS"
            form.lbAlarmVolumeStatus.ForeColor = Color.Green
            form.lbAlarmVolumeStatus.Visible = True
        Else
            form.lbAlarmVolumeStatus.Text = "FAIL"
            form.lbAlarmVolumeStatus.ForeColor = Color.Red
            form.lbAlarmVolumeStatus.Visible = True
        End If
    End Sub

    Public Sub SetNotificationVolume(ByRef form As AndroidSettingsForm)
        Dim notificationVolume As String = form.cbNotifyVolume.Text
        If IsNumeric(notificationVolume) And Volume.SetNotificationVolume(form.MyProjectInfo, notificationVolume) Then
            form.lbNotifyVolumeStatus.Text = "PASS"
            form.lbNotifyVolumeStatus.ForeColor = Color.Green
            form.lbNotifyVolumeStatus.Visible = True
        Else
            form.lbNotifyVolumeStatus.Text = "FAIL"
            form.lbNotifyVolumeStatus.ForeColor = Color.Red
            form.lbNotifyVolumeStatus.Visible = True
        End If
    End Sub

    Public Sub SetOtherVolume(ByRef form As AndroidSettingsForm)
        Dim otherVolume As String = form.cbOtherVolume.Text
        If IsNumeric(otherVolume) And Volume.SetOtherVolume(form.MyProjectInfo, otherVolume) Then
            form.lbOtherVolumeStatus.Text = "PASS"
            form.lbOtherVolumeStatus.ForeColor = Color.Green
            form.lbOtherVolumeStatus.Visible = True
        Else
            form.lbOtherVolumeStatus.Text = "FAIL"
            form.lbOtherVolumeStatus.ForeColor = Color.Red
            form.lbOtherVolumeStatus.Visible = True
        End If
    End Sub

End Module
