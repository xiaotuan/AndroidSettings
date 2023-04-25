Imports System.CodeDom
Imports System.IO

Module AndroidTVolume

    Public Function GetCallVolume(ByRef info As ProjectInfo) As String
        Return GetVolume(info, "call")
    End Function

    Public Function GetRingVolume(ByRef info As ProjectInfo) As String
        Return GetVolume(info, "ring")
    End Function

    Public Function GetMusicVolume(ByRef info As ProjectInfo) As String
        Return GetVolume(info, "music")
    End Function

    Public Function GetAlarmVolume(ByRef info As ProjectInfo) As String
        Return GetVolume(info, "alarm")
    End Function

    Public Function GetNotificationVolume(ByRef info As ProjectInfo) As String
        Return GetVolume(info, "notification")
    End Function

    Public Function GetOtherVolume(ByRef info As ProjectInfo) As String
        Return GetVolume(info, "other")
    End Function

    Public Function SetCallVolume(ByRef info As ProjectInfo, ByVal volume As String) As Boolean
        Return SetVolume(info, "call", volume)
    End Function

    Public Function SetRingVolume(ByRef info As ProjectInfo, ByVal volume As String) As Boolean
        Return SetVolume(info, "ring", volume)
    End Function

    Public Function SetMusicVolume(ByRef info As ProjectInfo, ByVal volume As String) As Boolean
        Return SetVolume(info, "music", volume)
    End Function

    Public Function SetAlarmVolume(ByRef info As ProjectInfo, ByVal volume As String) As Boolean
        Return SetVolume(info, "alarm", volume)
    End Function

    Public Function SetNotificationVolume(ByRef info As ProjectInfo, ByVal volume As String) As Boolean
        Return SetVolume(info, "notification", volume)
    End Function

    Public Function SetOtherVolume(ByRef info As ProjectInfo, ByVal volume As String) As Boolean
        Return SetVolume(info, "system", volume) And SetVolume(info, "bluetooth_sco", volume) And
            SetVolume(info, "system_enforced", volume) And SetVolume(info, "dtmf", volume) And
            SetVolume(info, "tts", volume) And SetVolume(info, "accessibility", volume) And
            SetVolume(info, "assistant", volume)
    End Function

    Public Function GetVolume(ByRef info As ProjectInfo, ByVal volumeType As String) As String
        Dim volume As String = ""
        Dim originFilePath As String = info.ProjectPath &
                "/sys/frameworks/base/media/java/android/media/AudioSystem.java"
        Dim customFilePath As String = info.ProjectPath & "/sys/weibu/" &
                info.MssiDirName & "/" & info.CustomDirName & "/alps/frameworks/base/media/java/android/media/AudioSystem.java"

        Dim utf8 = New Text.UTF8Encoding(False)
        Dim fileReader As StreamReader = Nothing
        Dim line As String = Nothing

        Try
            If File.Exists(customFilePath) Then
                fileReader = New StreamReader(customFilePath, utf8)
            ElseIf File.Exists(originFilePath) Then
                fileReader = New StreamReader(originFilePath, utf8)
            End If
            Dim foundStart As Boolean = False
            If Not IsNothing(fileReader) Then
                line = fileReader.ReadLine
                Do Until IsNothing(line)
                    If line.Trim.Equals("public static int[] DEFAULT_STREAM_VOLUME = new int[] {") Then
                        foundStart = True
                    End If
                    If foundStart And line.Trim.Equals("};") Then
                        foundStart = False
                    End If
                    If foundStart Then
                        If "call".Equals(volumeType) And line.Trim.EndsWith("// STREAM_VOICE_CALL") Then
                            volume = line.Trim.Split(",")(0)
                            Exit Do
                        ElseIf "ring".Equals(volumeType) And line.Trim.EndsWith("// STREAM_RING") Then
                            volume = line.Trim.Split(",")(0)
                            Exit Do
                        ElseIf "music".Equals(volumeType) And line.Trim.EndsWith("// STREAM_MUSIC") Then
                            volume = line.Trim.Split(",")(0)
                            Exit Do
                        ElseIf "alarm".Equals(volumeType) And line.Trim.EndsWith("// STREAM_ALARM") Then
                            volume = line.Trim.Split(",")(0)
                            Exit Do
                        ElseIf "notification".Equals(volumeType) And line.Trim.EndsWith("// STREAM_NOTIFICATION") Then
                            volume = line.Trim.Split(",")(0)
                            Exit Do
                        ElseIf "other".Equals(volumeType) And line.Trim.EndsWith("// STREAM_SYSTEM") Then
                            volume = line.Trim.Split(",")(0)
                            Exit Do
                        End If
                    End If
                    line = fileReader.ReadLine
                Loop
            End If
        Catch ex As Exception
            Debug.WriteLine("[AndroidTVolume] GetValue=>error: " & ex.ToString)
        End Try
        If Not IsNothing(fileReader) Then
            fileReader.Close()
            fileReader = Nothing
        End If
        Return volume
    End Function

    Public Function SetVolume(ByRef info As ProjectInfo, ByVal volumeType As String, ByVal volume As String) As Boolean
        Dim result As Boolean = False
        Dim needRestore As Boolean = False
        Dim fileExist As Boolean = False
        Dim audioSystemOriginFilePath As String = info.ProjectPath &
                "/sys/frameworks/base/media/java/android/media/AudioSystem.java"
        Dim audioServiceOriginFilePath As String = info.ProjectPath &
                "/sys/frameworks/base/services/core/java/com/android/server/audio/AudioService.java"
        Dim audioSystemCustomFilePath As String = info.ProjectPath & "/sys/weibu/" &
                info.MssiDirName & "/" & info.CustomDirName & "/alps/frameworks/base/media/java/android/media/AudioSystem.java"
        Dim audioServiceCustomFilePath As String = info.ProjectPath & "/sys/weibu/" &
                info.MssiDirName & "/" & info.CustomDirName & "/alps/frameworks/base/services/core/java/com/android/server/audio/AudioService.java"
        Dim currentFilePath As String = audioSystemCustomFilePath
        Dim backPath As String = audioSystemCustomFilePath & ".bk"

        Dim utf8 = New Text.UTF8Encoding(False)
        Dim fs As FileStream = Nothing
        Dim fileReader As StreamReader = Nothing
        Dim fileWriter As StreamWriter = Nothing

        Try
            If Not File.Exists(currentFilePath) Then
                If Not Directory.Exists(Path.GetDirectoryName(currentFilePath)) Then
                    Directory.CreateDirectory(Path.GetDirectoryName(currentFilePath))
                End If
                File.Copy(audioSystemOriginFilePath, currentFilePath, True)
            Else
                fileExist = True
            End If
            File.Copy(currentFilePath, backPath, True)

            Dim foundStart As Boolean = False

            fs = New FileStream(currentFilePath, FileMode.Open)
            fileWriter = New StreamWriter(fs, utf8)
            fileReader = New StreamReader(backPath, utf8)

            fileWriter.NewLine = vbLf

            Dim line As String = fileReader.ReadLine()
            Do Until IsNothing(line)
                If line.Trim.Equals("public static int[] DEFAULT_STREAM_VOLUME = new int[] {") Then
                    foundStart = True
                End If
                If foundStart And line.Trim.Equals("};") Then
                    foundStart = False
                End If
                If foundStart Then
                    If "call".Equals(volumeType) And line.Trim.EndsWith("// STREAM_VOICE_CALL") Then
                        fileWriter.WriteLine("        " & volume & ",   // STREAM_VOICE_CALL")
                    ElseIf "ring".Equals(volumeType) And line.Trim.EndsWith("// STREAM_RING") Then
                        fileWriter.WriteLine("        " & volume & ",   // STREAM_RING")
                    ElseIf "music".Equals(volumeType) And line.Trim.EndsWith("// STREAM_MUSIC") Then
                        fileWriter.WriteLine("        " & volume & ",   // STREAM_MUSIC")
                    ElseIf "alarm".Equals(volumeType) And line.Trim.EndsWith("// STREAM_ALARM") Then
                        fileWriter.WriteLine("        " & volume & ",   // STREAM_ALARM")
                    ElseIf "notification".Equals(volumeType) And line.Trim.EndsWith("// STREAM_NOTIFICATION") Then
                        fileWriter.WriteLine("        " & volume & ",   // STREAM_NOTIFICATION")
                    ElseIf "system".Equals(volumeType) And line.Trim.EndsWith("// STREAM_SYSTEM") Then
                        fileWriter.WriteLine("        " & volume & ",  // STREAM_SYSTEM")
                    ElseIf "bluetooth_sco".Equals(volumeType) And line.Trim.EndsWith("// STREAM_BLUETOOTH_SCO") Then
                        fileWriter.WriteLine("        " & volume & ",   // STREAM_BLUETOOTH_SCO")
                    ElseIf "system_enforced".Equals(volumeType) And line.Trim.EndsWith("// STREAM_SYSTEM_ENFORCED") Then
                        fileWriter.WriteLine("        " & volume & ",  // STREAM_SYSTEM_ENFORCED")
                    ElseIf "dtmf".Equals(volumeType) And line.Trim.EndsWith("// STREAM_DTMF") Then
                        fileWriter.WriteLine("        " & volume & ",  // STREAM_DTMF")
                    ElseIf "tts".Equals(volumeType) And line.Trim.EndsWith("// STREAM_TTS") Then
                        fileWriter.WriteLine("        " & volume & ",  // STREAM_TTS")
                    ElseIf "accessibility".Equals(volumeType) And line.Trim.EndsWith("// STREAM_ACCESSIBILITY") Then
                        fileWriter.WriteLine("        " & volume & ",  // STREAM_ACCESSIBILITY")
                    ElseIf "assistant".Equals(volumeType) And line.Trim.EndsWith("// STREAM_ASSISTANT") Then
                        fileWriter.WriteLine("        " & volume & "    // STREAM_ASSISTANT")
                    Else
                        fileWriter.WriteLine(line)
                    End If
                Else
                    fileWriter.WriteLine(line)
                End If
                line = fileReader.ReadLine
            Loop

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

            If File.Exists(backPath) Then
                File.Delete(backPath)
            End If

            currentFilePath = audioServiceCustomFilePath
            backPath = audioServiceCustomFilePath & ".bk"

            If Not File.Exists(currentFilePath) Then
                If Not Directory.Exists(Path.GetDirectoryName(currentFilePath)) Then
                    Directory.CreateDirectory(Path.GetDirectoryName(currentFilePath))
                End If
                File.Copy(audioServiceOriginFilePath, currentFilePath, True)
            Else
                fileExist = True
            End If
            File.Copy(currentFilePath, backPath, True)

            foundStart = False
            Dim foundEnd As Boolean = False
            Dim insertEnd As Boolean = False
            Dim foundStartTag As Boolean = False
            Dim foundEndTag As Boolean = False

            Dim foundCall As Boolean = False
            Dim foundMusic As Boolean = False
            Dim foundAlarm As Boolean = False
            Dim foundSystem As Boolean = False

            fs = New FileStream(currentFilePath, FileMode.Open)
            fileWriter = New StreamWriter(fs, utf8)
            fileReader = New StreamReader(backPath, utf8)

            fileWriter.NewLine = vbLf

            line = fileReader.ReadLine()
            Do Until IsNothing(line)
                If line.Trim.Equals("// Modify default audio volume by qty {{&&") Then
                    Debug.WriteLine("[AndroidTVolume] SetVolume=>Found start tag.")
                    foundStart = True
                    foundStartTag = True
                End If
                If foundStart And line.Trim.Equals("// &&}}") Then
                    Debug.WriteLine("[AndroidTVolume] SetVolume=>Found end tag.")
                    foundEnd = True
                    foundStart = False
                Else
                    foundEnd = False
                End If
                If line.Trim.Equals("if (looper == null) {") Then
                    Debug.WriteLine("[AndroidTVolume] SetVolume=>Found insert end line.")
                    insertEnd = True
                Else
                    insertEnd = False
                End If

                If foundStart Then
                    Debug.WriteLine("[AndroidTVolume] SetVolume=>found start line: " & line)
                    If volumeType.Equals("call") And line.Trim.StartsWith("AudioSystem.DEFAULT_STREAM_VOLUME[AudioSystem.STREAM_VOICE_CALL] =") Then
                        fileWriter.WriteLine("        AudioSystem.DEFAULT_STREAM_VOLUME[AudioSystem.STREAM_VOICE_CALL] = " & volume & ";")
                        foundCall = True
                    ElseIf volumeType.Equals("music") And line.Trim.StartsWith("AudioSystem.DEFAULT_STREAM_VOLUME[AudioSystem.STREAM_MUSIC] =") Then
                        fileWriter.WriteLine("        AudioSystem.DEFAULT_STREAM_VOLUME[AudioSystem.STREAM_MUSIC] = " & volume & ";")
                        foundMusic = True
                    ElseIf volumeType.Equals("alarm") And line.Trim.StartsWith("AudioSystem.DEFAULT_STREAM_VOLUME[AudioSystem.STREAM_ALARM] =") Then
                        fileWriter.WriteLine("        AudioSystem.DEFAULT_STREAM_VOLUME[AudioSystem.STREAM_ALARM] = " & volume & ";")
                        foundAlarm = True
                    ElseIf volumeType.Equals("system") And line.Trim.StartsWith("AudioSystem.DEFAULT_STREAM_VOLUME[AudioSystem.STREAM_SYSTEM] =") Then
                        fileWriter.WriteLine("        AudioSystem.DEFAULT_STREAM_VOLUME[AudioSystem.STREAM_SYSTEM] = " & volume & ";")
                        foundSystem = True
                    Else
                        fileWriter.WriteLine(line)
                    End If
                Else
                    If foundEnd Then
                        Debug.WriteLine("[AndroidTVolume] SetVolume=>found end line: " & line)
                        If volumeType.Equals("call") And Not foundCall Then
                            fileWriter.WriteLine("        AudioSystem.DEFAULT_STREAM_VOLUME[AudioSystem.STREAM_VOICE_CALL] = " & volume & ";")
                        ElseIf volumeType.Equals("music") And Not foundMusic Then
                            fileWriter.WriteLine("        AudioSystem.DEFAULT_STREAM_VOLUME[AudioSystem.STREAM_MUSIC] = " & volume & ";")
                        ElseIf volumeType.Equals("alarm") And Not foundAlarm Then
                            fileWriter.WriteLine("        AudioSystem.DEFAULT_STREAM_VOLUME[AudioSystem.STREAM_ALARM] = " & volume & ";")
                        ElseIf volumeType.Equals("system") And Not foundSystem Then
                            fileWriter.WriteLine("        AudioSystem.DEFAULT_STREAM_VOLUME[AudioSystem.STREAM_SYSTEM] = " & volume & ";")
                        End If
                        fileWriter.WriteLine(line)
                    Else
                        If insertEnd Then
                            Debug.WriteLine("[AndroidTVolume] SetVolume=>insert end line: " & line)
                            If Not foundStartTag Then
                                fileWriter.WriteLine("        // Modify default audio volume by qty {{&&")
                                If volumeType.Equals("call") Then
                                    fileWriter.WriteLine("        AudioSystem.DEFAULT_STREAM_VOLUME[AudioSystem.STREAM_VOICE_CALL] = " & volume & ";")
                                ElseIf volumeType.Equals("music") Then
                                    fileWriter.WriteLine("        AudioSystem.DEFAULT_STREAM_VOLUME[AudioSystem.STREAM_MUSIC] = " & volume & ";")
                                ElseIf volumeType.Equals("alarm") Then
                                    fileWriter.WriteLine("        AudioSystem.DEFAULT_STREAM_VOLUME[AudioSystem.STREAM_ALARM] = " & volume & ";")
                                ElseIf volumeType.Equals("system") Then
                                    fileWriter.WriteLine("        AudioSystem.DEFAULT_STREAM_VOLUME[AudioSystem.STREAM_SYSTEM] = " & volume & ";")
                                End If
                                fileWriter.WriteLine("        // &&}}")
                                fileWriter.WriteLine("")
                            End If
                            fileWriter.WriteLine(line)
                        Else
                            fileWriter.WriteLine(line)
                        End If
                    End If
                End If
                line = fileReader.ReadLine()
            Loop

            result = True
        Catch ex As Exception
            needRestore = True
            Debug.WriteLine("[AndroidTVolume] SetVolume=>error: " & ex.ToString)
        Finally
            If Not IsNothing(fileWriter) Then
                fileWriter.Close()
                fileWriter = Nothing
            End If
            If Not IsNothing(fs) Then
                fs.Close()
                fs = Nothing
            End If
            If Not IsNothing(fileReader) Then
                fileReader.Close()
                fileReader = Nothing
            End If
            If needRestore Then
                If fileExist Then
                    File.Copy(backPath, currentFilePath, True)
                Else
                    File.Delete(currentFilePath)
                End If
            End If
        End Try

        If File.Exists(backPath) Then
            File.Delete(backPath)
        End If

        Return result
    End Function

End Module
