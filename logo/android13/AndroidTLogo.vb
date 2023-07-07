Imports System.IO

Module AndroidTLogo

    Public Function SetLogo(ByRef info As ProjectInfo, ByVal logoPath As String) As Boolean
        Dim result As Boolean = False
        If info.ChiperModel.Equals("MT8781") Then
            result = SetMt8781Logo(info, logoPath)
        Else
            result = SetOtherLogo(info, logoPath)
        End If
        Return result
    End Function

    Private Function SetMt8781Logo(ByRef info As ProjectInfo, ByVal logoPath As String) As Boolean
        Dim result As Boolean = False
        Dim isFakeHorizontal As Boolean = IsHorizontalProject(info)
        Dim screenType As String = GetScreenType(info)
        If Not Utils.IsEmptyText(screenType) Then
            If isFakeHorizontal Then
                screenType = screenType & "nl"
            End If

            Dim ubootFilePath = info.ProjectPath & "/vnd/weibu/" & info.PublicDirName & "/" & info.DriveDirName & "/alps/vendor/mediatek/proprietary/external/BootLogo/logo/" & screenType & "/" & screenType & "_uboot.bmp"
            Dim kernelFilePath = info.ProjectPath & "/vnd/weibu/" & info.PublicDirName & "/" & info.DriveDirName & "/alps/vendor/mediatek/proprietary/external/BootLogo/logo/" & screenType & "/" & screenType & "_kernel.bmp"

            result = SetLogo(info, ubootFilePath, kernelFilePath, logoPath)
        End If
        Return result
    End Function

    Private Function SetOtherLogo(ByRef info As ProjectInfo, ByVal logoPath As String) As Boolean
        Dim result As Boolean = False
        Dim isFakeHorizontal As Boolean = IsHorizontalProject(info)
        Dim screenType As String = GetScreenType(info)
        If Not Utils.IsEmptyText(screenType) Then
            If isFakeHorizontal Then
                screenType = screenType & "nl"
            End If

            Dim ubootFilePath = info.ProjectPath & "/vnd/weibu/" & info.PublicDirName & "/" & info.DriveDirName & "/alps/vendor/mediatek/proprietary/bootable/bootloader/lk/dev/logo/" & screenType & "/" & screenType & "_uboot.bmp"
            Dim kernelFilePath = info.ProjectPath & "/vnd/weibu/" & info.PublicDirName & "/" & info.DriveDirName & "/alps/vendor/mediatek/proprietary/bootable/bootloader/lk/dev/logo/" & screenType & "/" & screenType & "_kernel.bmp"

            result = SetLogo(info, ubootFilePath, kernelFilePath, logoPath)
        End If
        Return result
    End Function

    Private Function SetLogo(ByRef info As ProjectInfo, ByVal ubootFilePath As String, ByVal kernelFilePath As String, ByVal logoFilePath As String) As Boolean
        Dim result As Boolean = False
        Dim fileExists As Boolean = False
        Dim needRestore As Boolean = False
        Dim isFakeHorizontal As Boolean = IsHorizontalProject(info)
        Dim screenType As String = GetScreenType(info)
        If Not Utils.IsEmptyText(screenType) Then
            If isFakeHorizontal Then
                screenType = screenType & "nl"
            End If

            Dim backPath As String = ubootFilePath & ".bk"
            Try
                If Not System.IO.File.Exists(ubootFilePath) Then
                    If Not System.IO.Directory.Exists(Path.GetDirectoryName(ubootFilePath)) Then
                        System.IO.Directory.CreateDirectory(Path.GetDirectoryName(ubootFilePath))
                    End If
                Else
                    System.IO.File.Copy(ubootFilePath, backPath, True)
                    fileExists = True
                End If
                System.IO.File.Copy(logoFilePath, ubootFilePath, True)
                result = True
            Catch ex As Exception
                result = False
                needRestore = True
                Debug.WriteLine("[AndroidTLogo] SetMt8781Logo=>error: " + ex.ToString)
            Finally
                If needRestore Then
                    If Not fileExists Then
                        If System.IO.File.Exists(ubootFilePath) Then
                            System.IO.File.Delete(ubootFilePath)
                        End If
                    Else
                        If System.IO.File.Exists(backPath) Then
                            System.IO.File.Copy(backPath, ubootFilePath, True)
                        End If
                    End If
                End If
            End Try
            If System.IO.File.Exists(backPath) Then
                System.IO.File.Delete(backPath)
            End If
            If result Then
                result = False
                backPath = kernelFilePath & ".bk"
                Try
                    If Not System.IO.File.Exists(kernelFilePath) Then
                        If Not System.IO.Directory.Exists(Path.GetDirectoryName(kernelFilePath)) Then
                            System.IO.Directory.CreateDirectory(Path.GetDirectoryName(kernelFilePath))
                        End If
                    Else
                        System.IO.File.Copy(kernelFilePath, backPath, True)
                        fileExists = True
                    End If
                    System.IO.File.Copy(logoFilePath, kernelFilePath, True)
                    result = True
                Catch ex As Exception
                    result = False
                    needRestore = True
                    Debug.WriteLine("[AndroidTLogo] SetMt8781Logo=>error: " + ex.ToString)
                Finally
                    If needRestore Then
                        If Not fileExists Then
                            If System.IO.File.Exists(kernelFilePath) Then
                                System.IO.File.Delete(kernelFilePath)
                            End If
                        Else
                            If System.IO.File.Exists(backPath) Then
                                System.IO.File.Copy(backPath, kernelFilePath, True)
                            End If
                        End If
                    End If
                End Try
                If System.IO.File.Exists(backPath) Then
                    System.IO.File.Delete(backPath)
                End If
            End If
        End If
        Return result
    End Function

    Private Function GetScreenType(ByRef info As ProjectInfo) As String
        Dim screenType As String = ""
        Dim originFilePath = info.ProjectPath & "/vnd/device/mediateksample/" & info.PublicDirName & "/ProjectConfig.mk"
        Dim customFilePath = info.ProjectPath & "/vnd/weibu/" & info.PublicDirName & "/" & info.DriveDirName & "/config/ProjectConfig.mk"
        If File.Exists(customFilePath) Then
            Dim utf8 = New System.Text.UTF8Encoding(False)
            Dim fileReader As StreamReader = Nothing
            Try
                fileReader = New System.IO.StreamReader(customFilePath, utf8)
                Dim line = fileReader.ReadLine()
                Do Until IsNothing(line)
                    If line.StartsWith("BOOT_LOGO") And line.Split("=").Length = 2 Then
                        screenType = line.Split("=")(1).Trim
                        Debug.WriteLine("[AndroidTLogo] GetScreenType=>screenType : " & screenType)
                        Exit Do
                    End If
                    line = fileReader.ReadLine()
                Loop
            Catch ex As Exception
                Debug.WriteLine("[AndroidTLogo] GetScreenType=>error: " & ex.ToString)
            Finally
                If Not IsNothing(fileReader) Then
                    fileReader.Close()
                    fileReader = Nothing
                End If
            End Try
        End If
        If Utils.IsEmptyText(screenType) Then
            Dim utf8 = New System.Text.UTF8Encoding(False)
            Dim fileReader As StreamReader = Nothing
            Try
                fileReader = New System.IO.StreamReader(originFilePath, utf8)
                Dim line = fileReader.ReadLine()
                Do Until IsNothing(line)
                    If line.StartsWith("BOOT_LOGO") And line.Split("=").Length = 2 Then
                        screenType = line.Split("=")(1).Trim
                        Debug.WriteLine("[AndroidTLogo] GetScreenType=>screenType : " & screenType)
                        Exit Do
                    End If
                    line = fileReader.ReadLine()
                Loop
            Catch ex As Exception
                Debug.WriteLine("[AndroidTLogo] GetScreenType=>error: " & ex.ToString)
            Finally
                If Not IsNothing(fileReader) Then
                    fileReader.Close()
                    fileReader = Nothing
                End If
            End Try
        End If
        Return screenType
    End Function

    Private Function IsHorizontalProject(ByRef info As ProjectInfo) As Boolean
        Dim isFakeHorizontal As Boolean = False
        Debug.WriteLine("[AndroidTLogo] IsHorizontalProject=>project path: " & info.ProjectPath)
        Dim customFilePath As String = info.ProjectPath & "/vnd/weibu/" & info.PublicDirName & "/" & info.DriveDirName & "/config/csci.ini"
        If System.IO.File.Exists(customFilePath) Then
            Dim utf8 = New System.Text.UTF8Encoding(False)
            Dim fileReader As StreamReader = Nothing
            Try
                fileReader = New System.IO.StreamReader(customFilePath, utf8)
                Dim line = fileReader.ReadLine()
                Do Until IsNothing(line)
                    If line.StartsWith("ro.vendor.fake.orientation") Then
                        line = line.Substring("ro.vendor.fake.orientation".Length).Trim
                        line = line.Split(" ")(0)
                        isFakeHorizontal = "1".Equals(line)
                        Debug.WriteLine("[AndroidTLogo] IsHorizontalProject=>line : " & line)
                        Exit Do
                    End If
                    line = fileReader.ReadLine()
                Loop
            Catch ex As Exception
                Debug.WriteLine("[AndroidTLogo] IsHorizontalProject=>error: " & ex.ToString)
            Finally
                If Not IsNothing(fileReader) Then
                    fileReader.Close()
                    fileReader = Nothing
                End If
            End Try
        End If
        Return isFakeHorizontal
    End Function

End Module
