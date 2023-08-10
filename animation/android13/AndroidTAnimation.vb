Imports System.IO
Imports System.Runtime.Serialization
Imports System.Text

Module AndroidTAnimation

    Public Function SetBootRing(ByRef info As ProjectInfo, ByVal filePath As String) As Boolean
        Dim result As Boolean = False
        Dim backupFilePath As String = Nothing

        If File.Exists(filePath) Then
            Dim customFilePath As String = info.ProjectPath & "\sys\weibu\" & info.MssiDirName &
                "\" & info.CustomDirName & "\alps\vendor\weibu_sz\media\bootaudio.mp3"
            Try
                ' 拷贝开机铃声文件
                If File.Exists(customFilePath) Then
                    backupFilePath = customFilePath & ".bk"
                    File.Copy(customFilePath, backupFilePath, True)
                    File.Copy(filePath, customFilePath, True)
                Else
                    If Not Directory.Exists(Path.GetDirectoryName(customFilePath)) Then
                        Directory.CreateDirectory(Path.GetDirectoryName(customFilePath))
                    End If
                    File.Copy(filePath, customFilePath, True)
                End If

                ' 清除备份文件
                If File.Exists(backupFilePath) Then
                    File.Delete(backupFilePath)
                    backupFilePath = Nothing
                End If

                ' 修改 products.mk 文件
                Dim originFilePath = info.ProjectPath & "\sys\vendor\weibu_sz\products\products.mk"
                customFilePath = info.ProjectPath & "\sys\weibu\" & info.MssiDirName &
                    "\" & info.CustomDirName & "\alps\vendor\weibu_sz\products\products.mk"

                ' 如果需要，拷贝原始文件到客制化目录
                If File.Exists(customFilePath) Then
                    backupFilePath = customFilePath & ".bk"
                    File.Copy(customFilePath, backupFilePath, True)
                Else
                    If Not Directory.Exists(Path.GetDirectoryName(customFilePath)) Then
                        Directory.CreateDirectory(Path.GetDirectoryName(customFilePath))
                    End If
                    File.Copy(originFilePath, customFilePath, True)
                End If

                Dim newValue = "PRODUCT_COPY_FILES += vendor\weibu_sz\media\bootaudio.mp3:system\media\bootaudio.mp3"

                If Not MakeFileUtils.HasValueInMakeFile(customFilePath, New Text.UTF8Encoding(False), newValue) Then
                    result = MakeFileUtils.AddValueToMakeFile(customFilePath, New Text.UTF8Encoding(False), newValue, "")
                    If Not result Then
                        Throw New Exception("Add value failed.")
                    End If
                Else
                    result = True
                End If
            Catch ex As Exception
                Debug.WriteLine("[AndroidTAnimation] SetBootRing=>error: " & ex.StackTrace)
                If File.Exists(backupFilePath) Then
                    File.Copy(backupFilePath, customFilePath, True)
                End If
            End Try
        Else
            Debug.WriteLine("[AndroidTAnimation] SetBootRing=>Ring file isn't exist.")
        End If

        If File.Exists(backupFilePath) Then
            File.Delete(backupFilePath)
        End If

        Debug.WriteLine("[AndroidTAnimation] SetBootRing=>result: " & result)
        Return result
    End Function

    Public Function SetBootAnim(ByRef info As ProjectInfo, ByVal filePath As String) As Boolean
        Dim result As Boolean = False
        Dim backupFilePath As String = Nothing

        If File.Exists(filePath) Then
            Dim customFilePath As String = info.ProjectPath & "\sys\weibu\" & info.MssiDirName &
                "\" & info.CustomDirName & "\alps\vendor\weibu_sz\media\bootanimation.zip"
            Try
                ' 拷贝开机铃声文件
                If File.Exists(customFilePath) Then
                    backupFilePath = customFilePath & ".bk"
                    File.Copy(customFilePath, backupFilePath, True)
                    File.Copy(filePath, customFilePath, True)
                Else
                    If Not Directory.Exists(Path.GetDirectoryName(customFilePath)) Then
                        Directory.CreateDirectory(Path.GetDirectoryName(customFilePath))
                    End If
                    File.Copy(filePath, customFilePath, True)
                End If

                ' 清除备份文件
                If File.Exists(backupFilePath) Then
                    File.Delete(backupFilePath)
                    backupFilePath = Nothing
                End If

                ' 修改 products.mk 文件
                Dim originFilePath = info.ProjectPath & "\sys\vendor\weibu_sz\products\products.mk"
                customFilePath = info.ProjectPath & "\sys\weibu\" & info.MssiDirName &
                    "\" & info.CustomDirName & "\alps\vendor\weibu_sz\products\products.mk"

                ' 如果需要，拷贝原始文件到客制化目录
                If File.Exists(customFilePath) Then
                    backupFilePath = customFilePath & ".bk"
                    File.Copy(customFilePath, backupFilePath, True)
                Else
                    If Not Directory.Exists(Path.GetDirectoryName(customFilePath)) Then
                        Directory.CreateDirectory(Path.GetDirectoryName(customFilePath))
                    End If
                    File.Copy(originFilePath, customFilePath, True)
                End If

                Dim newValue = "PRODUCT_COPY_FILES += vendor\weibu_sz\media\bootanimation.zip:system\media\bootanimation.zip"

                If Not MakeFileUtils.HasValueInMakeFile(customFilePath, New Text.UTF8Encoding(False), newValue) Then
                    result = MakeFileUtils.AddValueToMakeFile(customFilePath, New Text.UTF8Encoding(False), newValue, "")
                    If Not result Then
                        Throw New Exception("Add value failed.")
                    End If
                Else
                    result = True
                End If
            Catch ex As Exception
                Debug.WriteLine("[AndroidTAnimation] SetBootAnim=>error: " & ex.StackTrace)
                If File.Exists(backupFilePath) Then
                    File.Copy(backupFilePath, customFilePath, True)
                End If
            End Try
        Else
            Debug.WriteLine("[AndroidTAnimation] SetBootAnim=>Ring file isn't exist.")
        End If

        If File.Exists(backupFilePath) Then
            File.Delete(backupFilePath)
        End If

        Debug.WriteLine("[AndroidTAnimation] SetBootAnim=>result: " & result)
        Return result
    End Function

    Public Function SetShutdownRing(ByRef info As ProjectInfo, ByVal filePath As String) As Boolean
        Dim result As Boolean = False
        Dim backupFilePath As String = Nothing

        If File.Exists(filePath) Then
            Dim customFilePath As String = info.ProjectPath & "\sys\weibu\" & info.MssiDirName &
                "\" & info.CustomDirName & "\alps\vendor\weibu_sz\media\shutaudio.mp3"
            Try
                ' 拷贝开机铃声文件
                If File.Exists(customFilePath) Then
                    backupFilePath = customFilePath & ".bk"
                    File.Copy(customFilePath, backupFilePath, True)
                    File.Copy(filePath, customFilePath, True)
                Else
                    If Not Directory.Exists(Path.GetDirectoryName(customFilePath)) Then
                        Directory.CreateDirectory(Path.GetDirectoryName(customFilePath))
                    End If
                    File.Copy(filePath, customFilePath, True)
                End If

                ' 清除备份文件
                If File.Exists(backupFilePath) Then
                    File.Delete(backupFilePath)
                    backupFilePath = Nothing
                End If

                ' 修改 products.mk 文件
                Dim originFilePath = info.ProjectPath & "\sys\vendor\weibu_sz\products\products.mk"
                customFilePath = info.ProjectPath & "\sys\weibu\" & info.MssiDirName &
                    "\" & info.CustomDirName & "\alps\vendor\weibu_sz\products\products.mk"

                ' 如果需要，拷贝原始文件到客制化目录
                If File.Exists(customFilePath) Then
                    backupFilePath = customFilePath & ".bk"
                    File.Copy(customFilePath, backupFilePath, True)
                Else
                    If Not Directory.Exists(Path.GetDirectoryName(customFilePath)) Then
                        Directory.CreateDirectory(Path.GetDirectoryName(customFilePath))
                    End If
                    File.Copy(originFilePath, customFilePath, True)
                End If

                Dim newValue = "PRODUCT_COPY_FILES += vendor\weibu_sz\media\shutaudio.mp3:system\media\shutaudio.mp3"

                If Not MakeFileUtils.HasValueInMakeFile(customFilePath, New Text.UTF8Encoding(False), newValue) Then
                    If Not MakeFileUtils.AddValueToMakeFile(customFilePath, New Text.UTF8Encoding(False), newValue, "") Then
                        Throw New Exception("Add value failed.")
                    End If
                End If

                ' 清除备份文件
                If File.Exists(backupFilePath) Then
                    File.Delete(backupFilePath)
                    backupFilePath = Nothing
                End If

                ' 修改 Threads.cpp 文件
                originFilePath = info.ProjectPath & "\sys\frameworks\av\services\audioflinger\Threads.cpp"
                customFilePath = info.ProjectPath & "\sys\weibu\" & info.MssiDirName &
                    "\" & info.CustomDirName & "\alps\frameworks\av\services\audioflinger\Threads.cpp"

                ' 如果需要，拷贝原始文件到客制化目录
                If File.Exists(customFilePath) Then
                    backupFilePath = customFilePath & ".bk"
                    File.Copy(customFilePath, backupFilePath, True)
                Else
                    If Not Directory.Exists(Path.GetDirectoryName(customFilePath)) Then
                        Directory.CreateDirectory(Path.GetDirectoryName(customFilePath))
                    End If
                    File.Copy(originFilePath, customFilePath, True)
                End If

                Dim newCode As StringBuilder = New StringBuilder()
                newCode.Append("            // Solve the problem that there is no sound in the shutdown ringtone by qty {{&&").Append(vbLf).
                    Append("            if (track->mFlags & IAudioFlinger::TRACK_BOOT) {").Append(vbLf).
                    Append("                vlf = 0.25f;").Append(vbLf).
                    Append("                vrf = 0.25f;").Append(vbLf).
                    Append("            }").Append(vbLf).
                    Append("            if(!strcmp(track->mAttr.tags,""BootAnimationAudioTrack"")) {").Append(vbLf).
                    Append("                vlf = 0.25f;").Append(vbLf).
                    Append("                vrf = 0.25f;").Append(vbLf).
                    Append("                vaf = 0.50f;").Append(vbLf).
                    Append("            }").Append(vbLf).
                    Append("            // &&}}").Append(vbLf)
                Dim insertPosition = "// XXX: these things DON'T need to be done each time"
                Dim method = "AudioFlinger::PlaybackThread::mixer_state AudioFlinger::MixerThread::prepareTracks_l("
                If Not CppFileUtils.HasCodeInCppFile(customFilePath, New Text.UTF8Encoding(False), newCode.ToString) Then
                    If Not CppFileUtils.AddCodeToCppFile(customFilePath, New Text.UTF8Encoding(False), method, newCode.ToString, insertPosition) Then
                        Throw New Exception("Add value failed.")
                    End If
                End If

                ' 清除备份文件
                If File.Exists(backupFilePath) Then
                    File.Delete(backupFilePath)
                    backupFilePath = Nothing
                End If

                ' 修改 AudioTrack.cpp 文件
                originFilePath = info.ProjectPath & "\sys\frameworks\av\media\libaudioclient\AudioTrack.cpp"
                customFilePath = info.ProjectPath & "\sys\weibu\" & info.MssiDirName &
                    "\" & info.CustomDirName & "\alps\frameworks\av\media\libaudioclient\AudioTrack.cpp"

                ' 如果需要，拷贝原始文件到客制化目录
                If File.Exists(customFilePath) Then
                    backupFilePath = customFilePath & ".bk"
                    File.Copy(customFilePath, backupFilePath, True)
                Else
                    If Not Directory.Exists(Path.GetDirectoryName(customFilePath)) Then
                        Directory.CreateDirectory(Path.GetDirectoryName(customFilePath))
                    End If
                    File.Copy(originFilePath, customFilePath, True)
                End If

                newCode.Clear()
                newCode.Append("    // Solve the problem that there is no sound in the shutdown ringtone by qty {{&&").Append(vbLf).
                    Append("    if (!strcmp(mAttributes.tags,""BootAnimationAudioTrack"")) {").Append(vbLf).
                    Append("        strcpy(input.attr.tags, ""BootAnimationAudioTrack"");").Append(vbLf).
                    Append("    } else {").Append(vbLf).
                    Append("        strcpy(input.attr.tags, """");").Append(vbLf).
                    Append("    }").Append(vbLf).
                    Append("    // &&}}").Append(vbLf)
                insertPosition = "input.flags = mFlags;"
                method = "status_t AudioTrack::createTrack_l()"
                If Not CppFileUtils.HasCodeInCppFile(customFilePath, New Text.UTF8Encoding(False), newCode.ToString) Then
                    result = CppFileUtils.AddCodeToCppFile(customFilePath, New Text.UTF8Encoding(False), method, newCode.ToString, insertPosition)
                    If Not result Then
                        Throw New Exception("Add value failed.")
                    End If
                Else
                    result = True
                End If

                ' 清除备份文件
                If File.Exists(backupFilePath) Then
                    File.Delete(backupFilePath)
                    backupFilePath = Nothing
                End If

            Catch ex As Exception
                Debug.WriteLine("[AndroidTAnimation] SetBootRing=>error: " & ex.Message)
                If File.Exists(backupFilePath) Then
                    File.Copy(backupFilePath, customFilePath, True)
                End If
            End Try
        Else
            Debug.WriteLine("[AndroidTAnimation] SetBootRing=>Ring file isn't exist.")
        End If

        If File.Exists(backupFilePath) Then
            File.Delete(backupFilePath)
        End If

        Debug.WriteLine("[AndroidTAnimation] SetBootRing=>result: " & result)
        Return result
    End Function

    Public Function SetShutdownAnim(ByRef info As ProjectInfo, ByVal filePath As String) As Boolean
        Dim result As Boolean = False
        Dim backupFilePath As String = Nothing

        If File.Exists(filePath) Then
            Dim customFilePath As String = info.ProjectPath & "\sys\weibu\" & info.MssiDirName &
                "\" & info.CustomDirName & "\alps\vendor\weibu_sz\media\shutdownanimation.zip"
            Try
                ' 拷贝开机铃声文件
                If File.Exists(customFilePath) Then
                    backupFilePath = customFilePath & ".bk"
                    File.Copy(customFilePath, backupFilePath, True)
                    File.Copy(filePath, customFilePath, True)
                Else
                    If Not Directory.Exists(Path.GetDirectoryName(customFilePath)) Then
                        Directory.CreateDirectory(Path.GetDirectoryName(customFilePath))
                    End If
                    File.Copy(filePath, customFilePath, True)
                End If

                ' 清除备份文件
                If File.Exists(backupFilePath) Then
                    File.Delete(backupFilePath)
                    backupFilePath = Nothing
                End If

                ' 修改 products.mk 文件
                Dim originFilePath = info.ProjectPath & "\sys\vendor\weibu_sz\products\products.mk"
                customFilePath = info.ProjectPath & "\sys\weibu\" & info.MssiDirName &
                    "\" & info.CustomDirName & "\alps\vendor\weibu_sz\products\products.mk"

                ' 如果需要，拷贝原始文件到客制化目录
                If File.Exists(customFilePath) Then
                    backupFilePath = customFilePath & ".bk"
                    File.Copy(customFilePath, backupFilePath, True)
                Else
                    If Not Directory.Exists(Path.GetDirectoryName(customFilePath)) Then
                        Directory.CreateDirectory(Path.GetDirectoryName(customFilePath))
                    End If
                    File.Copy(originFilePath, customFilePath, True)
                End If

                Dim newValue = "PRODUCT_COPY_FILES += vendor\weibu_sz\media\shutdownanimation.zip:system\media\shutanimation.zip"

                If Not MakeFileUtils.HasValueInMakeFile(customFilePath, New Text.UTF8Encoding(False), newValue) Then
                    result = MakeFileUtils.AddValueToMakeFile(customFilePath, New Text.UTF8Encoding(False), newValue, "")
                    If Not result Then
                        Throw New Exception("Add value failed.")
                    End If
                Else
                    result = True
                End If
            Catch ex As Exception
                Debug.WriteLine("[AndroidTAnimation] SetBootAnim=>error: " & ex.StackTrace)
                If File.Exists(backupFilePath) Then
                    File.Copy(backupFilePath, customFilePath, True)
                End If
            End Try
        Else
            Debug.WriteLine("[AndroidTAnimation] SetBootAnim=>Ring file isn't exist.")
        End If

        If File.Exists(backupFilePath) Then
            File.Delete(backupFilePath)
        End If

        Debug.WriteLine("[AndroidTAnimation] SetBootAnim=>result: " & result)
        Return result
    End Function

End Module
