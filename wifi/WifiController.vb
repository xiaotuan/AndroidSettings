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

    Public Sub SetWifiInfos(ByRef form As AndroidSettingsForm)
        If SetWifiDefaultState(form) Then
            If SetHotspotName(form) Then
                SetScreenCastName(form)
            End If
        End If
    End Sub

    Public Function SetWifiDefaultState(ByRef form As AndroidSettingsForm) As Boolean
        Dim result As Boolean = False
        Dim lastState As Boolean = Wifi.GetWifiDefaultState(form.MyProjectInfo)
        Dim wifiState As Boolean = form.rbWifiOpen.Checked
        If lastState <> wifiState Then
            If Wifi.SetWifiDefaultState(form.MyProjectInfo, wifiState) Then
                form.lbWifiStatusState.Text = "PASS"
                form.lbWifiStatusState.ForeColor = Color.Green
                form.lbWifiStatusState.Visible = True
                result = True
            Else
                form.lbWifiStatusState.Text = "FAIL"
                form.lbWifiStatusState.ForeColor = Color.Red
                form.lbWifiStatusState.Visible = True
                result = False
            End If
        Else
            result = True
        End If

        Return result
    End Function

    Public Function SetHotspotName(ByRef form As AndroidSettingsForm) As Boolean
        Dim result As Boolean = False
        Dim lastName As String = Wifi.GetHotspotName(form.MyProjectInfo)
        Dim currentName As String = form.tbWifiHotspotName.Text
        If Not Utils.IsEmptyText(currentName) Then
            If Not currentName.Equals(lastName) Then
                If Wifi.SetHotspotName(form.MyProjectInfo, currentName) Then
                    form.lbWifiHotspotNameState.Text = "PASS"
                    form.lbWifiHotspotNameState.ForeColor = Color.Green
                    form.lbWifiHotspotNameState.Visible = True
                    result = True
                Else
                    form.lbWifiHotspotNameState.Text = "FAIL"
                    form.lbWifiHotspotNameState.ForeColor = Color.Red
                    form.lbWifiHotspotNameState.Visible = True
                    result = False
                End If
            Else
                result = True
                Debug.WriteLine("[WifiController] SetHotspotName=>name is not changed. lastName: " & lastName & ", currentName: " & currentName)
            End If
        Else
            Debug.WriteLine("[WifiController] SetHotspotName=>name is empty. name: " & currentName)
            result = True
        End If
        Return result
    End Function

    Public Function SetScreenCastName(ByRef form As AndroidSettingsForm) As Boolean
        Dim result As Boolean = False
        Dim lastName As String = Wifi.GetScreenCastName(form.MyProjectInfo)
        Dim currentName As String = form.tbWifiHotspotName.Text
        If Not Utils.IsEmptyText(currentName) Then
            If Not currentName.Equals(lastName) Then
                If Wifi.SetScreenCastName(form.MyProjectInfo, currentName) Then
                    form.lbWifiScreenCastState.Text = "PASS"
                    form.lbWifiScreenCastState.ForeColor = Color.Green
                    form.lbWifiScreenCastState.Visible = True
                    result = True
                Else
                    form.lbWifiScreenCastState.Text = "FAIL"
                    form.lbWifiScreenCastState.ForeColor = Color.Red
                    form.lbWifiScreenCastState.Visible = True
                    result = False
                End If
            Else
                result = True
                Debug.WriteLine("[WifiController] SetScreenCastName=>name is not changed. lastName: " & lastName & ", currentName: " & currentName)
            End If
        Else
            Debug.WriteLine("[WifiController] SetScreenCastName=>name is empty. name: " & currentName)
            result = True
        End If
        Return result
    End Function

End Module
