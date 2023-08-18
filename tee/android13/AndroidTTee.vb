Imports System.Drawing.Imaging
Imports System.IO
Imports System.Runtime.CompilerServices

Module AndroidTTee

    Public Function GetTeeStatus(ByRef info As ProjectInfo) As Boolean
        Dim result As Boolean = False
        Dim value As String = Nothing

        Dim originFilePath As String = info.ProjectPath & "/vnd/device/mediateksample/" &
            info.PublicDirName & "/ProjectConfig.mk"
        Dim customFilePath As String = info.ProjectPath & "/vnd/weibu/" & info.PublicDirName &
            "/" & info.DriveDirName & "/config/ProjectConfig.mk"

        If File.Exists(customFilePath) Then
            If MakeFileUtils.HasValueInMakeFile(customFilePath, New Text.UTF8Encoding(False), "TRUSTKERNEL_TEE_SUPPORT") Then
                value = MakeFileUtils.GetValueFromMakeFile(customFilePath, "TRUSTKERNEL_TEE_SUPPORT", New Text.UTF8Encoding(False), "=")
                If "yes".Equals(value) Then
                    result = True
                End If
            Else
                If MakeFileUtils.HasValueInMakeFile(originFilePath, New Text.UTF8Encoding(False), "TRUSTKERNEL_TEE_SUPPORT") Then
                    value = MakeFileUtils.GetValueFromMakeFile(originFilePath, "TRUSTKERNEL_TEE_SUPPORT", New Text.UTF8Encoding(False), "=")
                    If "yes".Equals(value) Then
                        result = True
                    End If
                End If
            End If
        End If

        Debug.WriteLine("[AndroidTTee] GetTeeStatus=>result: " & result.ToString)
        Return result
    End Function

    Public Function SetTeeStatus(ByRef info As ProjectInfo, ByVal enabled As Boolean) As Boolean
        Dim result As Boolean = False

        Dim newValue As String = "no"
        If enabled Then
            newValue = "yes"
        End If

        Dim customFilePath As String = info.ProjectPath & "/vnd/weibu/" & info.PublicDirName &
            "/" & info.DriveDirName & "/config/ProjectConfig.mk"

        If MakeFileUtils.HasValueInMakeFile(customFilePath, New Text.UTF8Encoding(False), "TRUSTKERNEL_TEE_SUPPORT") Then
            result = MakeFileUtils.SetValueToMakeFile(customFilePath, New Text.UTF8Encoding(False), "TRUSTKERNEL_TEE_SUPPORT", "TRUSTKERNEL_TEE_SUPPORT = " & newValue)
        Else
            result = MakeFileUtils.AddValueToMakeFile(customFilePath, New Text.UTF8Encoding(False), "TRUSTKERNEL_TEE_SUPPORT = " & newValue, "")
        End If

        If result Then
            If MakeFileUtils.HasValueInMakeFile(customFilePath, New Text.UTF8Encoding(False), "MTK_PERSIST_PARTITION_SUPPORT") Then
                result = MakeFileUtils.SetValueToMakeFile(customFilePath, New Text.UTF8Encoding(False), "MTK_PERSIST_PARTITION_SUPPORT", "MTK_PERSIST_PARTITION_SUPPORT = " & newValue)
            Else
                result = MakeFileUtils.AddValueToMakeFile(customFilePath, New Text.UTF8Encoding(False), "MTK_PERSIST_PARTITION_SUPPORT = " & newValue, "")
            End If
        End If

        If result Then
            If MakeFileUtils.HasValueInMakeFile(customFilePath, New Text.UTF8Encoding(False), "MTK_TEE_SUPPORT") Then
                result = MakeFileUtils.SetValueToMakeFile(customFilePath, New Text.UTF8Encoding(False), "MTK_TEE_SUPPORT", "MTK_TEE_SUPPORT = " & newValue)
            Else
                result = MakeFileUtils.AddValueToMakeFile(customFilePath, New Text.UTF8Encoding(False), "MTK_TEE_SUPPORT = " & newValue, "")
            End If
        End If

        If result Then
            result = False
            customFilePath = info.ProjectPath & "/vnd/weibu/" & info.PublicDirName & "/" & info.DriveDirName & "/config/" & info.PublicDirName & "_defconfig"
            newValue = "CONFIG_TRUSTKERNEL_TEE_SUPPORT=y"
            If Not enabled Then
                newValue = "#" & newValue
            End If
            If KernelConfigFileUtils.SetValueToKernelConfigFile(customFilePath, New Text.UTF8Encoding(False), "", "CONFIG_TRUSTKERNEL_TEE_SUPPORT", newValue) Then
                newValue = "CONFIG_TRUSTKERNEL_TEE_FP_SUPPORT=y"
                If Not enabled Then
                    newValue = "#" & newValue
                End If
                If KernelConfigFileUtils.SetValueToKernelConfigFile(customFilePath, New Text.UTF8Encoding(False), "", "CONFIG_TRUSTKERNEL_TEE_FP_SUPPORT", newValue) Then
                    newValue = "CONFIG_TRUSTKERNEL_TEE_RPMB_SUPPORT=y"
                    If Not enabled Then
                        newValue = "#" & newValue
                    End If
                    If KernelConfigFileUtils.SetValueToKernelConfigFile(customFilePath, New Text.UTF8Encoding(False), "", "CONFIG_TRUSTKERNEL_TEE_RPMB_SUPPORT", newValue) Then
                        result = True
                    End If
                End If
            End If

            If result Then
                result = False
                newValue = "no"
                If enabled Then
                    newValue = "yes"
                End If
                customFilePath = info.ProjectPath & "/vnd/weibu/" & info.PublicDirName & "/" & info.DriveDirName & "/config/" & info.PublicDirName & "_pl.mk"
                If MakeFileUtils.HasValueInMakeFile(customFilePath, New Text.UTF8Encoding(False), "MTK_TEE_SUPPORT") Then
                    result = MakeFileUtils.SetValueToMakeFile(customFilePath, New Text.UTF8Encoding(False), "MTK_TEE_SUPPORT", "MTK_TEE_SUPPORT = " & newValue)
                Else
                    result = MakeFileUtils.AddValueToMakeFile(customFilePath, New Text.UTF8Encoding(False), "MTK_TEE_SUPPORT = " & newValue, "")
                End If

                If result Then
                    If MakeFileUtils.HasValueInMakeFile(customFilePath, New Text.UTF8Encoding(False), "TRUSTKERNEL_TEE_SUPPORT") Then
                        result = MakeFileUtils.SetValueToMakeFile(customFilePath, New Text.UTF8Encoding(False), "TRUSTKERNEL_TEE_SUPPORT", "TRUSTKERNEL_TEE_SUPPORT = " & newValue)
                    Else
                        result = MakeFileUtils.AddValueToMakeFile(customFilePath, New Text.UTF8Encoding(False), "TRUSTKERNEL_TEE_SUPPORT = " & newValue, "")
                    End If
                End If
                If result Then
                    result = False
                    Dim backupPath As String = Nothing
                    Dim originFilePath As String = info.ProjectPath & "/vnd/vendor/mediatek/proprietary/trustzone/custom/build/project/" &
             info.PublicDirName & ".mk"
                    customFilePath = info.ProjectPath & "/vnd/weibu/" & info.PublicDirName &
                        "/" & info.DriveDirName & "/alps/vendor/mediatek/proprietary/trustzone/custom/build/project/" &
                        info.PublicDirName & ".mk"
                    If enabled Then
                        If File.Exists(customFilePath) Then
                            File.Delete(customFilePath)
                        End If
                        result = True
                    Else
                        Try
                            If Not File.Exists(customFilePath) Then
                                If Not Directory.Exists(Path.GetDirectoryName(customFilePath)) Then
                                    Directory.CreateDirectory(Path.GetDirectoryName(customFilePath))
                                End If
                                File.Copy(originFilePath, customFilePath, True)
                            Else
                                backupPath = customFilePath & ".bk"
                                File.Copy(customFilePath, backupPath, True)
                            End If

                            newValue = "no"
                            If enabled Then
                                newValue = "yes"
                            End If

                            If MakeFileUtils.HasValueInMakeFile(customFilePath, New Text.UTF8Encoding(False), "MTK_TEE_SUPPORT") Then
                                result = MakeFileUtils.SetValueToMakeFile(customFilePath, New Text.UTF8Encoding(False), "MTK_TEE_SUPPORT", "MTK_TEE_SUPPORT = " & newValue)
                            Else
                                result = MakeFileUtils.AddValueToMakeFile(customFilePath, New Text.UTF8Encoding(False), "MTK_TEE_SUPPORT = " & newValue, "")
                            End If

                            If result Then
                                If MakeFileUtils.HasValueInMakeFile(customFilePath, New Text.UTF8Encoding(False), "TRUSTKERNEL_TEE_SUPPORT") Then
                                    result = MakeFileUtils.SetValueToMakeFile(customFilePath, New Text.UTF8Encoding(False), "TRUSTKERNEL_TEE_SUPPORT", "TRUSTKERNEL_TEE_SUPPORT = " & newValue)
                                Else
                                    result = MakeFileUtils.AddValueToMakeFile(customFilePath, New Text.UTF8Encoding(False), "TRUSTKERNEL_TEE_SUPPORT = " & newValue, "")
                                End If
                                If Not result Then
                                    Throw New Exception("Modify " & customFilePath & " file fail.")
                                End If
                            Else
                                Throw New Exception("Modify " & customFilePath & " file fail.")
                            End If
                        Catch ex As Exception
                            Debug.WriteLine("[AndroidTTee] SetTeeStatus=>error: " & ex.ToString)
                            If File.Exists(backupPath) Then
                                File.Copy(backupPath, customFilePath, True)
                            End If
                        End Try

                        If File.Exists(backupPath) Then
                            File.Delete(backupPath)
                        End If
                    End If
                End If
            Else
                Debug.WriteLine("[AndroidTTee] SetTeeStatus=>modify " & customFilePath & " file fail.")
            End If
        Else
            Debug.WriteLine("[AndroidTTee] SetTeeStatus=>modify " & customFilePath & " file fail.")
        End If

        Return result
    End Function

    Public Function SetCertFile(ByRef info As ProjectInfo, ByVal filePath As String) As Boolean
        Dim result As Boolean = False
        Dim needRestore As Boolean = False
        Dim customFilePath As String = info.ProjectPath & "/vnd/weibu/" & info.PublicDirName & "/" &
            info.DriveDirName & "/alps/vendor/mediatek/proprietary/trustzone/trustkernel/source/build/" &
            info.PublicDirName & "/cert.dat"
        Dim backPath As String = customFilePath & ".bk"

        Try
            If Not File.Exists(customFilePath) Then
                If Directory.Exists(Path.GetDirectoryName(customFilePath)) Then
                    Directory.CreateDirectory(Path.GetDirectoryName(customFilePath))
                End If
            Else
                File.Copy(customFilePath, backPath, True)
            End If
            File.Copy(filePath, customFilePath, True)
            result = True
        Catch ex As Exception
            Debug.WriteLine("[AndroidTTee] SetCertFile=>error: " & ex.ToString)
            needRestore = True
        Finally
            If needRestore Then
                If File.Exists(backPath) Then
                    File.Copy(backPath, customFilePath, True)
                End If
            End If
        End Try
        If File.Exists(backPath) Then
            File.Delete(backPath)
        End If
        Return result
    End Function

    Public Function SetArrayFile(ByRef info As ProjectInfo, ByVal filePath As String) As Boolean
        Dim result As Boolean = False
        Dim needRestore As Boolean = False
        Dim fileExist As Boolean = False
        Dim customFilePath As String = info.ProjectPath & "/vnd/weibu/" & info.PublicDirName & "/" &
            info.DriveDirName & "/alps/vendor/mediatek/proprietary/trustzone/trustkernel/source/build/" &
            info.PublicDirName & "/array.c"
        Dim backPath As String = customFilePath & ".bk"

        Try
            If Not File.Exists(customFilePath) Then
                If Directory.Exists(Path.GetDirectoryName(customFilePath)) Then
                    Directory.CreateDirectory(Path.GetDirectoryName(customFilePath))
                End If
            Else
                fileExist = True
                File.Copy(customFilePath, backPath, True)
            End If
            File.Copy(filePath, customFilePath, True)
            result = True
        Catch ex As Exception
            Debug.WriteLine("[AndroidTTee] SetArrayFile=>error: " & ex.ToString)
            needRestore = True
        Finally
            If needRestore Then
                If fileExist Then
                    If File.Exists(backPath) Then
                        File.Copy(backPath, customFilePath, True)
                    End If
                Else
                    File.Delete(customFilePath)
                End If
            End If
        End Try
        If File.Exists(backPath) Then
            File.Delete(backPath)
        End If
        Return result
    End Function

End Module
