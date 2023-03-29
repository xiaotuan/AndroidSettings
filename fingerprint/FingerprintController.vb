Module FingerprintController

    Public Sub UpdateFingerprintInfo(ByRef form As AndroidSettingsForm)
        Debug.WriteLine("[FingerprintController] UpdateFingerprintInfo()...")
        form.lbFingerprintState.Visible = False
        form.tbFingerprint.Text = Fingerprint.GetFingerprint(form.MyProjectInfo)
    End Sub

    Public Sub SetFingerprint(ByRef form As AndroidSettingsForm, ByVal fp As String)
        Dim result As Boolean = Fingerprint.SetFingerprint(form.MyProjectInfo, fp)
        Debug.WriteLine("[FingerprintController]SetFingerprint=>result: " & Str(result))
        If result Then
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
