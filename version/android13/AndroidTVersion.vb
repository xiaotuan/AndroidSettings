Imports System.IO

Module AndroidTVersion

    Public Function GetVersion(ByRef info As ProjectInfo) As String
        Dim version As String = ""
        Dim versionCustomPath As String
        versionCustomPath = info.ProjectPath + "/sys/weibu/" + info.MssiDirName + "/" + info.CustomDirName + "/alps/build/make/tools/buildinfo.sh"
        Debug.WriteLine("[AndroidTVersion] GetVersion=>versionCustomPath: " & versionCustomPath)
        If System.IO.File.Exists(versionCustomPath) Then
            Dim utf8 = New System.Text.UTF8Encoding(False)
            Dim fileReader As New System.IO.StreamReader(versionCustomPath, utf8)
            Dim line = fileReader.ReadLine()
            Do Until line Is Nothing
                Debug.WriteLine("Line=>line: " & line)
                If line.StartsWith("echo ""ro.build.display.id=") Then
                    version = line.Split("=")(1).Trim
                    version = version.Substring(0, Len(version) - 1).Trim
                End If
                line = fileReader.ReadLine()
            Loop
            fileReader.Close()
        End If
        Return version
    End Function

    Public Function SetVersion(ByRef info As ProjectInfo, ByVal version As String) As Boolean
        If ModifyAndroidTVersion(info, version) And ModifyAndroidSVersion(info, version) Then
            Return True
        End If
        Return False
    End Function

    Private Function ModifyAndroidTVersion(ByRef info As ProjectInfo, ByVal version As String) As Boolean
        Dim result As Boolean = False
        Dim androidTVersionOriginPath As String
        Dim androidTVersionCustomPath As String
        Dim backVersionPath As String

        androidTVersionOriginPath = info.ProjectPath + "/sys/build/make/tools/buildinfo.sh"
        androidTVersionCustomPath = info.ProjectPath + "/sys/weibu/" + info.MssiDirName + "/" + info.CustomDirName + "/alps/build/make/tools/buildinfo.sh"

        If Not System.IO.File.Exists(androidTVersionCustomPath) Then
            Try
                System.IO.Directory.CreateDirectory(My.Computer.FileSystem.GetParentPath(androidTVersionCustomPath))
                System.IO.File.Copy(androidTVersionOriginPath, androidTVersionCustomPath, True)
            Catch e As Exception
                Debug.WriteLine("[AndroidTVersion]ModifyAndroidTVersion=>Copy buildinfo.sh file fail.")
                Return result
            End Try
        End If

        backVersionPath = androidTVersionCustomPath + ".bak"
        Try
            System.IO.File.Copy(androidTVersionCustomPath, backVersionPath, True)
        Catch e As Exception
            Debug.WriteLine("[AndroidTVersion]ModifyAndroidTVersion=>Backup buildinfo.sh file fail.")
            Return result
        End Try

        Try
            Dim fs As FileStream = Nothing
            Dim utf8 = New System.Text.UTF8Encoding(False)
            fs = New FileStream(androidTVersionCustomPath, FileMode.Open)
            Dim fileReader As New System.IO.StreamReader(backVersionPath, utf8)
            Dim fileWriter As New System.IO.StreamWriter(fs, utf8)
            fileWriter.NewLine = vbLf
            Dim line = fileReader.ReadLine()
            Do Until line Is Nothing
                If line.StartsWith("echo ""ro.build.display.id=") Then
                    fileWriter.WriteLine("echo ""ro.build.display.id=" & version & """")
                Else
                    fileWriter.WriteLine(line)
                End If
                line = fileReader.ReadLine()
            Loop
            fileReader.Close()
            fileWriter.Close()
            Return True
        Catch e As Exception
            Debug.WriteLine("[AndroidTVersion]ModifyAndroidTVersion=>Modify version fail.")
        Finally
            If System.IO.File.Exists(backVersionPath) Then
                System.IO.File.Delete(backVersionPath)
            End If
        End Try

        Return False
    End Function

    Private Function ModifyAndroidSVersion(ByRef info As ProjectInfo, ByVal version As String) As Boolean
        Dim androidSVersionOriginPath As String
        Dim androidSVersionCustomPath As String
        Dim backVersionPath As String

        androidSVersionOriginPath = info.ProjectPath + "/vnd/build/make/tools/buildinfo.sh"
        androidSVersionCustomPath = info.ProjectPath + "/vnd/weibu/" + info.PublicDirName + "/" + info.DriveDirName + "/alps/build/make/tools/buildinfo.sh"

        If Not System.IO.File.Exists(androidSVersionCustomPath) Then
            Try
                System.IO.Directory.CreateDirectory(My.Computer.FileSystem.GetParentPath(androidSVersionCustomPath))
                System.IO.File.Copy(androidSVersionOriginPath, androidSVersionCustomPath, True)
            Catch e As Exception
                Debug.WriteLine("[AndroidTVersion]ModifyAndroidTVersion=>Copy buildinfo.sh file fail.")
                Return False
            End Try
        End If

        backVersionPath = androidSVersionCustomPath + ".bak"
        Try
            System.IO.File.Copy(androidSVersionCustomPath, backVersionPath, True)
        Catch e As Exception
            Debug.WriteLine("[AndroidTVersion]ModifyAndroidTVersion=>Backup buildinfo.sh file fail.")
            Return False
        End Try

        Try
            Dim fs As FileStream = Nothing
            Dim utf8 = New System.Text.UTF8Encoding(False)
            fs = New FileStream(androidSVersionCustomPath, FileMode.Open)
            Dim fileReader As New System.IO.StreamReader(backVersionPath, utf8)
            Dim fileWriter As New System.IO.StreamWriter(fs, utf8)
            fileWriter.NewLine = vbLf
            Dim line = fileReader.ReadLine()
            Do Until line Is Nothing
                If line.StartsWith("echo ""ro.build.display.id=") Then
                    fileWriter.WriteLine("echo ""ro.build.display.id=" & version & """")
                Else
                    fileWriter.WriteLine(line)
                End If
                line = fileReader.ReadLine()
            Loop
            fileReader.Close()
            fileWriter.Close()
            Return True
        Catch e As Exception
            Debug.WriteLine("[AndroidTVersion]ModifyAndroidTVersion=>Modify version fail.")
        Finally
            If System.IO.File.Exists(backVersionPath) Then
                System.IO.File.Delete(backVersionPath)
            End If
        End Try

        Return False
    End Function

End Module
