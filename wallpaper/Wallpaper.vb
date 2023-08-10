Module Wallpaper

    Public Function SetWallpaper(ByRef info As ProjectInfo, ByVal wallpaperFilePath As String) As Boolean
        If "Android 13".Equals(info.AndroidVersion) Then
            Return AndroidTWallpaper.SetWallpaper(info, wallpaperFilePath)
        Else
            Return False
        End If
    End Function

    Public Function SetInsertWallpaper(ByRef info As ProjectInfo, ByVal wallpaperDirectoryPath As String) As Boolean
        If "Android 13".Equals(info.AndroidVersion) Then
            Return AndroidTWallpaper.SetInsertWallpaper(info, wallpaperDirectoryPath)
        Else
            Return False
        End If
    End Function
End Module
