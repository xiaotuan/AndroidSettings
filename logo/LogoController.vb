Module LogoController

    Public Sub UpdateLogo(ByRef form As AndroidSettingsForm)
        form.lbLogoState.Visible = False
    End Sub

    Public Sub SetLogo(ByRef form As AndroidSettingsForm)
        Dim path As String = form.tbLogo.Text
        If Not Utils.IsEmptyText(path) And Logo.SetLogo(form.MyProjectInfo, path) Then
            form.lbLogoState.Text = "PASS"
            form.lbLogoState.ForeColor = Color.Green
            form.lbLogoState.Visible = True
        Else
            form.lbLogoState.Text = "FAIL"
            form.lbLogoState.ForeColor = Color.Red
            form.lbLogoState.Visible = True
        End If
    End Sub

End Module
