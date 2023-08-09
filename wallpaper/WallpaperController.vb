Imports System.IO

Module WallpaperController

    Public Sub UpdateWallpaperInfos(ByRef form As AndroidSettingsForm)
        form.lbWallpaperState.Visible = False
        form.lbInsertWallpaperState.Visible = False
    End Sub

    Public Sub SetWallpaper(ByRef form As AndroidSettingsForm)
        Dim wallpaperPictureFilePath As String = form.tbWallpaper.Text
        If Not Utils.IsEmptyText(wallpaperPictureFilePath) And File.Exists(wallpaperPictureFilePath) And AndroidTWallpaper.SetWallpaper(form.MyProjectInfo, wallpaperPictureFilePath) Then
            form.lbWallpaperState.Text = "PASS"
            form.lbWallpaperState.ForeColor = Color.Green
            form.lbWallpaperState.Visible = True
        Else
            form.lbWallpaperState.Text = "FAIL"
            form.lbWallpaperState.ForeColor = Color.Red
            form.lbWallpaperState.Visible = True
        End If
    End Sub


    Public Sub SetBuildInWallpaper(ByRef form As AndroidSettingsForm)
        Dim insertWallpaperPicturesDirectory As String = form.tbInsertWallpaper.Text
        If Not Utils.IsEmptyText(insertWallpaperPicturesDirectory) And Directory.Exists(insertWallpaperPicturesDirectory) And AndroidTWallpaper.SetInsertWallpaper(form.MyProjectInfo, insertWallpaperPicturesDirectory) Then
            form.lbInsertWallpaperState.Text = "PASS"
            form.lbInsertWallpaperState.ForeColor = Color.Green
            form.lbInsertWallpaperState.Visible = True
        Else
            form.lbInsertWallpaperState.Text = "FAIL"
            form.lbInsertWallpaperState.ForeColor = Color.Red
            form.lbInsertWallpaperState.Visible = True
        End If
    End Sub

End Module
