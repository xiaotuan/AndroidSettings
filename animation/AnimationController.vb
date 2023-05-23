Imports System.IO

Module AnimationController

    Public Sub UpdateAnimationInfos(ByRef form As AndroidSettingsForm)
        form.lbBootRingStatus.Visible = False
        form.lbBootAnimStatus.Visible = False
        form.lbShutdownRingStatus.Visible = False
        form.lbShutdownAnimStatus.Visible = False
        If "Android 13".Equals(form.MyProjectInfo.AndroidVersion) Then
            form.lbAnimTip.Visible = True
        Else
            form.lbAnimTip.Visible = False
        End If
    End Sub

    Public Sub SetBootRing(ByRef form As AndroidSettingsForm)
        Dim filePath As String = form.tbBootRing.Text
        If Not Utils.IsEmptyText(filePath) And File.Exists(filePath) And Animation.SetBootRing(form.MyProjectInfo, filePath) Then
            form.lbBootRingStatus.Text = "PASS"
            form.lbBootRingStatus.ForeColor = Color.Green
            form.lbBootRingStatus.Visible = True
        Else
            form.lbBootRingStatus.Text = "FAIL"
            form.lbBootRingStatus.ForeColor = Color.Red
            form.lbBootRingStatus.Visible = True
        End If
    End Sub

    Public Sub SetBootAnim(ByRef form As AndroidSettingsForm)
        Dim filePath As String = form.tbBootRing.Text
        If Not Utils.IsEmptyText(filePath) And File.Exists(filePath) And Animation.SetBootAnim(form.MyProjectInfo, filePath) Then
            form.lbBootAnimStatus.Text = "PASS"
            form.lbBootAnimStatus.ForeColor = Color.Green
            form.lbBootAnimStatus.Visible = True
        Else
            form.lbBootAnimStatus.Text = "FAIL"
            form.lbBootAnimStatus.ForeColor = Color.Red
            form.lbBootAnimStatus.Visible = True
        End If
    End Sub

    Public Sub SetShutdownRing(ByRef form As AndroidSettingsForm)
        Dim filePath As String = form.tbBootRing.Text
        If Not Utils.IsEmptyText(filePath) And File.Exists(filePath) And Animation.SetShutdownRing(form.MyProjectInfo, filePath) Then
            form.lbShutdownRingStatus.Text = "PASS"
            form.lbShutdownRingStatus.ForeColor = Color.Green
            form.lbShutdownRingStatus.Visible = True
        Else
            form.lbShutdownRingStatus.Text = "FAIL"
            form.lbShutdownRingStatus.ForeColor = Color.Red
            form.lbShutdownRingStatus.Visible = True
        End If
    End Sub

    Public Sub SetShutdownAnim(ByRef form As AndroidSettingsForm)
        Dim filePath As String = form.tbBootRing.Text
        If Not Utils.IsEmptyText(filePath) And File.Exists(filePath) And Animation.SetShutdownAnim(form.MyProjectInfo, filePath) Then
            form.lbShutdownAnimStatus.Text = "PASS"
            form.lbShutdownAnimStatus.ForeColor = Color.Green
            form.lbShutdownAnimStatus.Visible = True
        Else
            form.lbShutdownAnimStatus.Text = "FAIL"
            form.lbShutdownAnimStatus.ForeColor = Color.Red
            form.lbShutdownAnimStatus.Visible = True
        End If
    End Sub

End Module
