Module GoogleCustomController

    Public Sub UpdateGoogleCustomInfos(ByRef form As AndroidSettingsForm)
        form.lbHomePageStatus.Visible = False
        form.lbEmailSignatureStatus.Visible = False
    End Sub

    Public Sub SetChromeHomePage(ByRef form As AndroidSettingsForm)
        Dim homePage As String = form.tbHomePage.Text
        If Not Utils.IsEmptyText(homePage) Then
            If GoogleCustom.SetChromeHomePage(form.MyProjectInfo, homePage) Then
                form.lbHomePageStatus.Text = "PASS"
                form.lbHomePageStatus.ForeColor = Color.Green
                form.lbHomePageStatus.Visible = True
            Else
                form.lbHomePageStatus.Text = "FAIL"
                form.lbHomePageStatus.ForeColor = Color.Red
                form.lbHomePageStatus.Visible = True
            End If
        Else
            form.lbHomePageStatus.Text = "FAIL"
            form.lbHomePageStatus.ForeColor = Color.Red
            form.lbHomePageStatus.Visible = True
        End If
    End Sub

    Public Sub SetEmailSignature(ByRef form As AndroidSettingsForm)
        Dim signature As String = form.tbEmailSignature.Text
        If Not Utils.IsEmptyText(signature) Then
            If GoogleCustom.SetEmailSignature(form.MyProjectInfo, signature) Then
                form.lbEmailSignatureStatus.Text = "PASS"
                form.lbEmailSignatureStatus.ForeColor = Color.Green
                form.lbEmailSignatureStatus.Visible = True
            Else
                form.lbEmailSignatureStatus.Text = "FAIL"
                form.lbEmailSignatureStatus.ForeColor = Color.Red
                form.lbEmailSignatureStatus.Visible = True
            End If
        Else
            form.lbEmailSignatureStatus.Text = "FAIL"
            form.lbEmailSignatureStatus.ForeColor = Color.Red
            form.lbEmailSignatureStatus.Visible = True
        End If
    End Sub

End Module
