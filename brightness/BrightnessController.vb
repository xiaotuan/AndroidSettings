Module BrightnessController

    Public Sub UpdateBrightnessInfos(ByRef form As AndroidSettingsForm)
        form.lbDefaultBrightnessStatus.Visible = False
        form.lbMaxBrightnessStatus.Visible = False
        form.lbMinBrightnessStatus.Visible = False

        form.tbDefaultBrightness.Text = Brightness.GetDefaultBrightness(form.MyProjectInfo)
        form.tbMaxBrightness.Text = Brightness.GetMaxBrightness(form.MyProjectInfo)
        form.tbMinBrightness.Text = Brightness.GetMinBrightness(form.MyProjectInfo)
    End Sub

    Public Sub SetDefaultBrightness(ByRef form As AndroidSettingsForm)
        Dim defaultBrightness As String = form.tbDefaultBrightness.Text
        If IsNumeric(defaultBrightness) And Brightness.SetDefaultBrightness(form.MyProjectInfo, defaultBrightness) Then
            form.lbDefaultBrightnessStatus.Text = "PASS"
            form.lbDefaultBrightnessStatus.ForeColor = Color.Green
            form.lbDefaultBrightnessStatus.Visible = True
        Else
            form.lbDefaultBrightnessStatus.Text = "FAIL"
            form.lbDefaultBrightnessStatus.ForeColor = Color.Red
            form.lbDefaultBrightnessStatus.Visible = True
        End If
    End Sub

    Public Sub SetMaxBrightness(ByRef form As AndroidSettingsForm)
        Dim maxBrightness As String = form.tbMaxBrightness.Text
        If IsNumeric(maxBrightness) And Brightness.SetMaxBrightness(form.MyProjectInfo, maxBrightness) Then
            form.lbMaxBrightnessStatus.Text = "PASS"
            form.lbMaxBrightnessStatus.ForeColor = Color.Green
            form.lbMaxBrightnessStatus.Visible = True
        Else
            form.lbMaxBrightnessStatus.Text = "FAIL"
            form.lbMaxBrightnessStatus.ForeColor = Color.Red
            form.lbMaxBrightnessStatus.Visible = True
        End If
    End Sub

    Public Sub SetMinBrightness(ByRef form As AndroidSettingsForm)
        Dim minBrightness As String = form.tbMinBrightness.Text
        If IsNumeric(minBrightness) And Brightness.SetMinBrightness(form.MyProjectInfo, minBrightness) Then
            form.lbMinBrightnessStatus.Text = "PASS"
            form.lbMinBrightnessStatus.ForeColor = Color.Green
            form.lbMinBrightnessStatus.Visible = True
        Else
            form.lbMinBrightnessStatus.Text = "FAIL"
            form.lbMinBrightnessStatus.ForeColor = Color.Red
            form.lbMinBrightnessStatus.Visible = True
        End If
    End Sub

End Module
