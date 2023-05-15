Imports System.IO

Module TeeController

    Public Sub UpdateTeeInfos(ByRef form As AndroidSettingsForm)
        Dim enabled As Boolean = Tee.GetTeeStatus(form.MyProjectInfo)
        form.lbTeeStatus.Visible = False
        form.lbTeeCertStatus.Visible = False
        form.lbTeeArrayStatus.Visible = False
        form.rbTeeOpen.Checked = enabled
    End Sub

    Public Sub SetTeeStatus(ByRef form As AndroidSettingsForm)
        If Tee.SetTeeStatus(form.MyProjectInfo, form.rbTeeOpen.Checked) Then
            form.lbTeeStatus.Text = "PASS"
            form.lbTeeStatus.ForeColor = Color.Green
            form.lbTeeStatus.Visible = True
        Else
            form.lbTeeStatus.Text = "FAIL"
            form.lbTeeStatus.ForeColor = Color.Red
            form.lbTeeStatus.Visible = True
        End If
    End Sub

    Public Sub SetCertFile(ByRef form As AndroidSettingsForm)
        Dim filePath As String = form.tbTeeCert.Text
        If File.Exists(filePath) And Tee.SetCertFile(form.MyProjectInfo, filePath) Then
            form.lbTeeCertStatus.Text = "PASS"
            form.lbTeeCertStatus.ForeColor = Color.Green
            form.lbTeeCertStatus.Visible = True
        Else
            form.lbTeeCertStatus.Text = "FAIL"
            form.lbTeeCertStatus.ForeColor = Color.Red
            form.lbTeeCertStatus.Visible = True
        End If
    End Sub

    Public Sub SetArrayFile(ByRef form As AndroidSettingsForm)
        Dim filePath As String = form.tbTeeArray.Text
        If File.Exists(filePath) And Tee.SetArrayFile(form.MyProjectInfo, filePath) Then
            form.lbTeeArrayStatus.Text = "PASS"
            form.lbTeeArrayStatus.ForeColor = Color.Green
            form.lbTeeArrayStatus.Visible = True
        Else
            form.lbTeeArrayStatus.Text = "FAIL"
            form.lbTeeArrayStatus.ForeColor = Color.Red
            form.lbTeeArrayStatus.Visible = True
        End If
    End Sub

End Module
