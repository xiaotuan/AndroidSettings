Imports System.Drawing.Imaging
Imports System.IO

Module AndroidTWallpaper

    Public Function SetWallpaper(ByRef info As ProjectInfo, ByVal wallpaperFilePath As String) As Boolean
        If info.Go <> 0 Then
            Return SetGoWallpaper(info, wallpaperFilePath)
        Else
            Return SetNotGoWallPaper(info, wallpaperFilePath)
        End If
    End Function

    Public Function SetInsertWallpaper(ByRef info As ProjectInfo, ByVal wallpaperDirectoryPath As String) As Boolean
        Dim result As Boolean = False
        Dim fileExists As Boolean = False
        Dim needRestore As Boolean = False
        Dim drawableDirectory As String = info.ProjectPath & "/sys/weibu/" & info.MssiDirName & "/" & info.CustomDirName & "/alps/vendor/mediatek/proprietary/packages/apps/WallpaperPicker/res/drawable-nodpi/"
        Dim valuesFilePath As String = info.ProjectPath & "/sys/weibu/" & info.MssiDirName & "/" & info.CustomDirName & "/alps/vendor/mediatek/proprietary/packages/apps/WallpaperPicker/res/values-nodpi/wallpapers.xml"
        Dim currentPath As String = ""
        Dim backPath As String = ""

        Try
            If Directory.Exists(wallpaperDirectoryPath) Then
                Debug.WriteLine("[AndroidTWallpaper] SetInsertWallpaper=>wallpaperDirectoryPath: " & wallpaperDirectoryPath)
                Dim files As List(Of String) = New List(Of String)(Directory.EnumerateFiles(wallpaperDirectoryPath))
                For Each f In files
                    Debug.WriteLine("[AndroidTWallpaper] SetInsertWallpaper=>file: " & f.ToString)
                    fileExists = False
                    currentPath = drawableDirectory & Path.GetFileName(f)
                    If Not File.Exists(currentPath) Then
                        If Not Directory.Exists(drawableDirectory) Then
                            Directory.CreateDirectory(drawableDirectory)
                        End If
                    Else
                        fileExists = True
                        backPath = currentPath & ".bk"
                        File.Copy(currentPath, backPath, True)
                    End If
                    File.Copy(f, currentPath, True)
                    File.Copy(f, drawableDirectory & Path.GetFileNameWithoutExtension(f) & "_small" & Path.GetExtension(f), True)
                    If File.Exists(backPath) Then
                        File.Delete(backPath)
                    End If
                Next

                If Not File.Exists(valuesFilePath) Then
                    If Not Directory.Exists(Path.GetDirectoryName(valuesFilePath)) Then
                        Directory.CreateDirectory(Path.GetDirectoryName(valuesFilePath))
                    End If
                    File.Create(valuesFilePath).Close()
                Else
                    fileExists = True
                    backPath = valuesFilePath & ".bk"
                    currentPath = valuesFilePath
                End If
                File.Copy(valuesFilePath, backPath, True)

                Dim fileReader As System.IO.StreamReader = Nothing
                Dim fileWriter As System.IO.StreamWriter = Nothing
                Dim fs As FileStream = Nothing
                Dim utf8 = New System.Text.UTF8Encoding(False)
                Try
                    If fileExists Then
                        fs = New FileStream(valuesFilePath, FileMode.Open)
                        fileReader = New System.IO.StreamReader(backPath, utf8)
                        fileWriter = New System.IO.StreamWriter(fs, utf8)
                        fileWriter.NewLine = vbLf
                        Dim line = fileReader.ReadLine()
                        Do Until IsNothing(line)
                            If line.Trim.StartsWith("</string-array>") Then
                                For Each f In files
                                    fileWriter.WriteLine("        <item>" & Path.GetFileNameWithoutExtension(f) & "</item>")
                                Next
                                fileWriter.WriteLine(line)
                            Else
                                fileWriter.WriteLine(line)
                            End If
                            line = fileReader.ReadLine()
                        Loop
                    Else
                        fs = New FileStream(valuesFilePath, FileMode.Open)
                        fileWriter = New System.IO.StreamWriter(fs, utf8)
                        fileWriter.WriteLine("<?xml version=""1.0"" encoding=""utf-8""?>")
                        fileWriter.WriteLine("<!--")
                        fileWriter.WriteLine(" * Copyright (C) 2009 Google Inc.")
                        fileWriter.WriteLine(" *")
                        fileWriter.WriteLine(" * Licensed under the Apache License, Version 2.0 (the ""License"");")
                        fileWriter.WriteLine(" * you may not use this file except in compliance with the License.")
                        fileWriter.WriteLine(" * You may obtain a copy of the License at")
                        fileWriter.WriteLine(" *")
                        fileWriter.WriteLine(" *      http://www.apache.org/licenses/LICENSE-2.0")
                        fileWriter.WriteLine(" *")
                        fileWriter.WriteLine(" * Unless required by applicable law or agreed to in writing, software")
                        fileWriter.WriteLine(" * distributed under the License is distributed on an ""As Is"" BASIS,")
                        fileWriter.WriteLine(" * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.")
                        fileWriter.WriteLine(" * See the License for the specific language governing permissions and")
                        fileWriter.WriteLine(" * limitations under the License.")
                        fileWriter.WriteLine(" -->")
                        fileWriter.WriteLine("")
                        fileWriter.WriteLine("<resources>")
                        fileWriter.WriteLine("    <string-array name=""wallpapers"" translatable=""false"">")
                        For Each f In files
                            fileWriter.WriteLine("        <item>" & Path.GetFileNameWithoutExtension(f) & "</item>")
                        Next
                        fileWriter.WriteLine("    </string-array>")
                        fileWriter.WriteLine("</resources>")
                    End If
                    result = True
                Catch e As Exception
                    result = False
                    needRestore = True
                    Debug.WriteLine("[AndroidTWallpaper] SetInsertWallpaper=>error: " + e.ToString)
                Finally
                    If Not IsNothing(fileReader) Then
                        fileReader.Close()
                        fileReader = Nothing
                    End If
                    If Not IsNothing(fileWriter) Then
                        fileWriter.Close()
                        fileWriter = Nothing
                    End If
                    If Not IsNothing(fs) Then
                        fs.Close()
                        fs = Nothing
                    End If
                    If needRestore Then
                        If Not fileExists Then
                            If System.IO.File.Exists(valuesFilePath) Then
                                System.IO.File.Delete(valuesFilePath)
                            End If
                        Else
                            If System.IO.File.Exists(backPath) Then
                                System.IO.File.Copy(backPath, valuesFilePath, True)
                            End If
                        End If
                    End If
                End Try
            End If
        Catch ex As Exception
            needRestore = True
            Debug.WriteLine("[AndroidTWallpaper] SetInsertWallpaper=>error: " & ex.ToString)
        Finally
            If needRestore Then
                If fileExists Then
                    File.Copy(backPath, currentPath, True)
                End If
            End If
        End Try

        If File.Exists(backPath) Then
            File.Delete(backPath)
        End If

        Return result
    End Function

    Private Function SetGoWallpaper(ByRef info As ProjectInfo, ByVal wallpaperFilePath As String) As Boolean
        Dim result As Boolean = False
        Dim fileExists As Boolean = False
        Dim needRestore As Boolean = False
        Dim defaultFilePath As String = info.ProjectPath & "/sys/weibu/" & info.MssiDirName & "/" & info.CustomDirName &
            "/alps/device/mediatek/system/common/overlay/ago/frameworks/base/core/res/res/drawable-nodpi/default_wallpaper.jpg"
        Dim sw720dpFilePath As String = info.ProjectPath & "/sys/weibu/" & info.MssiDirName & "/" & info.CustomDirName &
            "/alps/frameworks/base/core/res/res/drawable-sw720dp-nodpi/default_wallpaper.png"
        Dim sw600dpFilePath As String = info.ProjectPath & "/sys/weibu/" & info.MssiDirName & "/" & info.CustomDirName &
            "/alps/frameworks/base/core/res/res/drawable-sw600dp-nodpi/default_wallpaper.png"
        Dim backPath As String = defaultFilePath & ".bk"

        Dim bmp As New Bitmap(wallpaperFilePath)
        Try
            If Not File.Exists(defaultFilePath) Then
                If Not Directory.Exists(Path.GetDirectoryName(defaultFilePath)) Then
                    Directory.CreateDirectory(Path.GetDirectoryName(defaultFilePath))
                End If
            Else
                fileExists = True
                File.Copy(defaultFilePath, backPath, True)
            End If
            bmp.Save(defaultFilePath, ImageFormat.Jpeg)

            If File.Exists(backPath) Then
                File.Delete(backPath)
            End If

            backPath = sw600dpFilePath & ".bk"
            fileExists = False
            If Not File.Exists(sw600dpFilePath) Then
                If Not Directory.Exists(Path.GetDirectoryName(sw600dpFilePath)) Then
                    Directory.CreateDirectory(Path.GetDirectoryName(sw600dpFilePath))
                End If
            Else
                fileExists = True
                File.Copy(sw600dpFilePath, backPath, True)
            End If
            File.Copy(wallpaperFilePath, sw600dpFilePath, True)


            If File.Exists(backPath) Then
                File.Delete(backPath)
            End If

            backPath = sw720dpFilePath & ".bk"
            fileExists = False
            If Not File.Exists(sw720dpFilePath) Then
                If Not Directory.Exists(Path.GetDirectoryName(sw720dpFilePath)) Then
                    Directory.CreateDirectory(Path.GetDirectoryName(sw720dpFilePath))
                End If
            Else
                fileExists = True
                File.Copy(sw720dpFilePath, backPath, True)
            End If
            File.Copy(wallpaperFilePath, sw720dpFilePath, True)
            result = True
        Catch ex As Exception
            needRestore = True
            Debug.WriteLine("[AndroidTWallpaper] SetGoWallpaper=>error: " & ex.ToString)
        Finally
            If needRestore Then
                If fileExists Then
                    File.Copy(backPath, defaultFilePath)
                End If
            End If
        End Try

        If File.Exists(backPath) Then
            File.Delete(backPath)
        End If

        bmp.Dispose()

        Return result
    End Function

    Private Function SetNotGoWallPaper(ByRef info As ProjectInfo, ByVal wallpaperFilePath As String) As Boolean
        Dim result As Boolean = False
        Dim fileExists As Boolean = False
        Dim needRestore As Boolean = False
        Dim defaultFilePath As String = info.ProjectPath & "/sys/weibu/" & info.MssiDirName & "/" & info.CustomDirName &
            "/alps/frameworks/base/core/res/res/drawable-nodpi/default_wallpaper.png"
        Dim sw720dpFilePath As String = info.ProjectPath & "/sys/weibu/" & info.MssiDirName & "/" & info.CustomDirName &
            "/alps/frameworks/base/core/res/res/drawable-sw720dp-nodpi/default_wallpaper.png"
        Dim sw600dpFilePath As String = info.ProjectPath & "/sys/weibu/" & info.MssiDirName & "/" & info.CustomDirName &
            "/alps/frameworks/base/core/res/res/drawable-sw600dp-nodpi/default_wallpaper.png"
        Dim backPath As String = defaultFilePath & ".bk"

        Try
            If Not File.Exists(defaultFilePath) Then
                If Not Directory.Exists(Path.GetDirectoryName(defaultFilePath)) Then
                    Directory.CreateDirectory(Path.GetDirectoryName(defaultFilePath))
                End If
            Else
                fileExists = True
                File.Copy(defaultFilePath, backPath, True)
            End If
            File.Copy(wallpaperFilePath, defaultFilePath, True)

            If File.Exists(backPath) Then
                File.Delete(backPath)
            End If

            If Not File.Exists(sw600dpFilePath) Then
                If Not Directory.Exists(Path.GetDirectoryName(sw600dpFilePath)) Then
                    Directory.CreateDirectory(Path.GetDirectoryName(sw600dpFilePath))
                End If
            Else
                fileExists = True
                File.Copy(sw600dpFilePath, backPath, True)
            End If
            File.Copy(wallpaperFilePath, sw600dpFilePath, True)

            If File.Exists(backPath) Then
                File.Delete(backPath)
            End If

            If Not File.Exists(sw720dpFilePath) Then
                If Not Directory.Exists(Path.GetDirectoryName(sw720dpFilePath)) Then
                    Directory.CreateDirectory(Path.GetDirectoryName(sw720dpFilePath))
                End If
            Else
                fileExists = True
                File.Copy(sw720dpFilePath, backPath, True)
            End If
            File.Copy(wallpaperFilePath, sw720dpFilePath, True)
            result = True
        Catch ex As Exception
            needRestore = True
            Debug.WriteLine("[AndroidTWallpaper] SetGoWallpaper=>error: " & ex.ToString)
        Finally
            If needRestore Then
                If fileExists Then
                    File.Copy(backPath, defaultFilePath)
                End If
            End If
        End Try

        If File.Exists(backPath) Then
            File.Delete(backPath)
        End If

        Return result
    End Function

End Module
