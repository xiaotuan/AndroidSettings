Imports System.IO

Module AndroidTGoogleCustom

    Public Function SetChromeHomePage(ByRef info As ProjectInfo, ByVal homePage As String) As Boolean
        Dim result As Boolean = False

        Dim originFilePath As String = info.ProjectPath & "/sys/packages/providers/PartnerCustomizationsProvider/src/com/android/partnerbrowsercustomizations/PartnerBrowserCustomizationsProvider.java"
        Dim customFilePath As String = info.ProjectPath & "/sys/weibu/" & info.MssiDirName &
            "/" & info.CustomDirName & "/alps/packages/providers/PartnerCustomizationsProvider/src/com/android/partnerbrowsercustomizations/PartnerBrowserCustomizationsProvider.java"
        Dim backPath As String = Nothing

        Try
            If Not File.Exists(customFilePath) Then
                If Not Directory.Exists(Path.GetDirectoryName(customFilePath)) Then
                    Directory.CreateDirectory(Path.GetDirectoryName(customFilePath))
                End If
                File.Copy(originFilePath, customFilePath, True)
            Else
                backPath = customFilePath & ".bk"
                File.Copy(customFilePath, backPath, True)
            End If

            result = JavaFileUtils.SetValueToJavaFile(customFilePath, New Text.UTF8Encoding(False), "", "private static String HOMEPAGE_URI", "    private static String HOMEPAGE_URI = """ & homePage & """;")

            If File.Exists(backPath) Then
                File.Delete(backPath)
                backPath = Nothing
            End If

            originFilePath = info.ProjectPath & "/sys/vendor/weibu_sz/product/products.mk"
            customFilePath = info.ProjectPath & "/sys/weibu/" & info.MssiDirName & "/" & info.CustomDirName & "/alps/vendor/weibu_sz/products/products.mk"

            If result Then
                result = False
                If Not File.Exists(customFilePath) Then
                    If Not Directory.Exists(Path.GetDirectoryName(customFilePath)) Then
                        Directory.CreateDirectory(Path.GetDirectoryName(customFilePath))
                    End If
                    File.Copy(originFilePath, customFilePath, True)
                Else
                    backPath = customFilePath & ".bk"
                    File.Copy(customFilePath, backPath, True)
                End If

                If Not MakeFileUtils.HasValueInMakeFile(customFilePath, New Text.UTF8Encoding(False), "PRODUCT_PACKAGES += PartnerCustomizationsProvider") Then
                    result = MakeFileUtils.AddValueToMakeFile(customFilePath, New Text.UTF8Encoding(False), "PRODUCT_PACKAGES += PartnerCustomizationsProvider", "")
                Else
                    result = True
                End If
            End If
        Catch ex As Exception
            Debug.WriteLine("[AndroidTGoogleCustom] SetChromeHomePage=>error: " & ex.ToString)
            If File.Exists(backPath) Then
                File.Copy(backPath, customFilePath, True)
            End If
        End Try

        If File.Exists(backPath) Then
            File.Delete(backPath)
        End If

        Debug.WriteLine("[AndroidTGoogleCustom] SetChromeHomePage=>result: " & result)
        Return result
    End Function

    Public Function SetEmailSignature(ByRef info As ProjectInfo, ByVal signature As String) As Boolean
        Dim result As Boolean = False

        Dim originFilePath As String = info.ProjectPath & "/sys/packages/providers/EmailPartnerProvider/res/values/strings.xml"
        Dim customFilePath As String = info.ProjectPath & "/sys/weibu/" & info.MssiDirName &
            "/" & info.CustomDirName & "/alps/packages/providers/EmailPartnerProvider/res/values/strings.xml"
        Dim backPath As String = Nothing

        Try
            If Not File.Exists(customFilePath) Then
                If Not Directory.Exists(Path.GetDirectoryName(customFilePath)) Then
                    Directory.CreateDirectory(Path.GetDirectoryName(customFilePath))
                End If
                File.Copy(originFilePath, customFilePath, True)
            Else
                backPath = customFilePath & ".bk"
                File.Copy(customFilePath, backPath, True)
            End If

            result = XmlFileUtils.SetValueToXmlFile(customFilePath, New Text.UTF8Encoding(False), "    <string name=""global_signature"">" & signature & "</string>", "<string name=""global_signature"">")

            If File.Exists(backPath) Then
                File.Delete(backPath)
                backPath = Nothing
            End If

            originFilePath = info.ProjectPath & "/sys/vendor/weibu_sz/product/products.mk"
            customFilePath = info.ProjectPath & "/sys/weibu/" & info.MssiDirName & "/" & info.CustomDirName & "/alps/vendor/weibu_sz/products/products.mk"

            If result Then
                result = False
                If Not File.Exists(customFilePath) Then
                    If Not Directory.Exists(Path.GetDirectoryName(customFilePath)) Then
                        Directory.CreateDirectory(Path.GetDirectoryName(customFilePath))
                    End If
                    File.Copy(originFilePath, customFilePath, True)
                Else
                    backPath = customFilePath & ".bk"
                    File.Copy(customFilePath, backPath, True)
                End If

                If Not MakeFileUtils.HasValueInMakeFile(customFilePath, New Text.UTF8Encoding(False), "PRODUCT_PACKAGES += EmailPartnerProvider") Then
                    result = MakeFileUtils.AddValueToMakeFile(customFilePath, New Text.UTF8Encoding(False), "PRODUCT_PACKAGES += EmailPartnerProvider", "")
                Else
                    result = True
                End If
            End If
        Catch ex As Exception
            Debug.WriteLine("[AndroidTGoogleCustom] SetEmailSignature=>error: " & ex.ToString)
            If File.Exists(backPath) Then
                File.Copy(backPath, customFilePath, True)
            End If
        End Try

        Debug.WriteLine("[AndroidTGoogleCustom] SetEmailSignature=>result: " & result)
        Return result
    End Function

End Module
