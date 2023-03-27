Module VersionController

    Public Sub UpdateVersionInfo(ByRef form As AndroidSettingsForm)
        Debug.WriteLine("[VersionController] UpdateVersionInfo()...")
        form.lbVersionState.Visible = False
        form.tbVersion.Text = Version.GetVersion(form.MyProjectInfo)
    End Sub

    Public Sub SetVersion(ByRef form As AndroidSettingsForm, ByVal text As String)
        Dim result As Boolean = Version.SetVersion(form.MyProjectInfo, text)
        Debug.WriteLine("SetVersion=>result: " & Str(result))
        If result Then
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
