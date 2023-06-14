Module WifiController

    Public Sub UpdateWifiInfo(ByRef form As AndroidSettingsForm)
        form.lbWifiStatusState.Visible = False
        form.lbWifiHotspotNameState.Visible = False
        form.lbWifiScreenCastState.Visible = False

        Dim isDefaultOpen = Wifi.GetWifiDefaultState(form.MyProjectInfo)
        Debug.WriteLine("[WifiController] UpdateWifiInfo=>isDefaultOpen: " & isDefaultOpen)
        If isDefaultOpen Then
            form.rbWifiOpen.Checked = True
        Else
            form.rbWifiClose.Checked = True
        End If

        Dim hotspotName = Wifi.GetHotspotName(form.MyProjectInfo)
        form.tbWifiHotspotName.Text = hotspotName

        Dim screenCastName = Wifi.GetScreenCastName(form.MyProjectInfo)
        form.tbWifiScreenCast.Text = screenCastName
    End Sub

    Public Sub SetWifiDefaultState(ByRef form As AndroidSettingsForm)
        Dim wifiState As Boolean = form.rbWifiOpen.Checked
        If Wifi.SetWifiDefaultState(form.MyProjectInfo, wifiState) Then
            form.lbWifiStatusState.Text = "PASS"
            form.lbWifiStatusState.ForeColor = Color.Green
            form.lbWifiStatusState.Visible = True
        Else
            form.lbWifiStatusState.Text = "FAIL"
            form.lbWifiStatusState.ForeColor = Color.Red
            form.lbWifiStatusState.Visible = True
        End If
    End Sub

    Public Sub SetHotspotName(ByRef form As AndroidSettingsForm)
        Dim currentName As String = form.tbWifiHotspotName.Text
        If Wifi.SetHotspotName(form.MyProjectInfo, currentName) Then
            form.lbWifiHotspotNameState.Text = "PASS"
            form.lbWifiHotspotNameState.ForeColor = Color.Green
            form.lbWifiHotspotNameState.Visible = True
        Else
            form.lbWifiHotspotNameState.Text = "FAIL"
            form.lbWifiHotspotNameState.ForeColor = Color.Red
            form.lbWifiHotspotNameState.Visible = True
        End If
    End Sub

    Public Sub SetScreenCastName(ByRef form As AndroidSettingsForm)
        Dim currentName As String = form.tbWifiHotspotName.Text
        If Wifi.SetScreenCastName(form.MyProjectInfo, currentName) Then
            form.lbWifiScreenCastState.Text = "PASS"
            form.lbWifiScreenCastState.ForeColor = Color.Green
            form.lbWifiScreenCastState.Visible = True
        Else
            form.lbWifiScreenCastState.Text = "FAIL"
            form.lbWifiScreenCastState.ForeColor = Color.Red
            form.lbWifiScreenCastState.Visible = True
        End If
    End Sub

End Module
