Module SampleController

    Public Sub UpdateSampleInfos(ByRef form As AndroidSettingsForm)
        form.lbSampleState.Visible = False
        form.lbSampleNameState.Visible = False

        Dim enabled As Boolean = Sample.GetSampleStatus(form.MyProjectInfo)
        If enabled Then
            form.rbSampleOpen.Checked = True
        Else
            form.rbSampleClose.Checked = True
        End If
        form.tbSampleName.Text = Sample.GetSampleName(form.MyProjectInfo)
    End Sub

    Public Function SetSampleStatus(ByRef form As AndroidSettingsForm) As Boolean
        Dim defaultStatus As Boolean = Sample.GetSampleStatus(form.MyProjectInfo)
        Dim currentStatus As Boolean = form.rbSampleOpen.Checked

        If defaultStatus = currentStatus Then
            form.lbSampleState.Text = "PASS"
            form.lbSampleState.ForeColor = Color.Green
            form.lbSampleState.Visible = True
            Return True
        Else
            If Sample.SetSampleStatus(form.MyProjectInfo, currentStatus) Then
                form.lbSampleState.Text = "PASS"
                form.lbSampleState.ForeColor = Color.Green
                form.lbSampleState.Visible = True
                Return True
            Else
                form.lbSampleState.Text = "FAIL"
                form.lbSampleState.ForeColor = Color.Red
                form.lbSampleState.Visible = True
                Return False
            End If
        End If
    End Function

    Public Function SetSampleName(ByRef form As AndroidSettingsForm) As Boolean
        Dim defaultName As String = Sample.GetSampleName(form.MyProjectInfo)
        Dim currentName As String = form.tbSampleName.Text.Trim

        If Not Utils.IsEmptyText(currentName) And defaultName.Equals(currentName) Then
            form.lbSampleNameState.Text = "PASS"
            form.lbSampleNameState.ForeColor = Color.Green
            form.lbSampleNameState.Visible = True
            Return True
        Else
            If Not Utils.IsEmptyText(currentName) And Sample.SetSampleName(form.MyProjectInfo, currentName) Then
                form.lbSampleNameState.Text = "PASS"
                form.lbSampleNameState.ForeColor = Color.Green
                form.lbSampleNameState.Visible = True
                Return True
            Else
                form.lbSampleNameState.Text = "FAIL"
                form.lbSampleNameState.ForeColor = Color.Red
                form.lbSampleNameState.Visible = True
                Return False
            End If
        End If
    End Function

End Module
