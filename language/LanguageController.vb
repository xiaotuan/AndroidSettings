Module LanguageController

    Public Sub UpdateLanguage(ByRef form As AndroidSettingsForm)
        form.lbLanguageState.Visible = False
        Dim lang As String = Language.GetLanguage(form.MyProjectInfo)
        Dim found As Boolean = False
        For Each language As String In form.cbLanguage.Items
            Dim lan As String = language.Split("-")(1)
            If lan.Equals(lang) Then
                form.cbLanguage.Text = language
                found = True
            End If
        Next
        If Not found Then
            form.cbLanguage.Text = lang
        End If
    End Sub

    Public Sub SetLanguage(ByRef form As AndroidSettingsForm)
        Dim lan As String = form.cbLanguage.Text
        If lan.Contains("-") And lan.Split("-").Length = 2 Then
            lan = lan.Split("-")(1)
        End If
        If Not Utils.IsEmptyText(lan) And Language.SetLanguage(form.MyProjectInfo, lan) Then
            form.lbLanguageState.Text = "PASS"
            form.lbLanguageState.ForeColor = Color.Green
            form.lbLanguageState.Visible = True
        Else
            form.lbLanguageState.Text = "FAIL"
            form.lbLanguageState.ForeColor = Color.Red
            form.lbLanguageState.Visible = True
        End If
    End Sub

End Module
