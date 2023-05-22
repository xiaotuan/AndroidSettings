Imports System.IO

Module AndroidTGoogleCustom

    Public Function SetChromeHomePage(ByRef info As ProjectInfo, ByVal homePage As String) As Boolean
        Dim result As Boolean = False
        Dim needRestore As Boolean = False
        Dim fileExist As Boolean = False
        Dim originFilePath As String = info.ProjectPath & "/sys/packages/providers/PartnerCustomizationsProvider/src/com/android/partnerbrowsercustomizations/PartnerBrowserCustomizationsProvider.java"
        Dim customFilePath As String = info.ProjectPath & "/sys/weibu/" & info.MssiDirName &
            "/" & info.CustomDirName & "/alps/packages/providers/PartnerCustomizationsProvider/src/com/android/partnerbrowsercustomizations/PartnerBrowserCustomizationsProvider.java"
        Dim backPath As String = customFilePath & ".bk"

        Dim utf8 = New Text.UTF8Encoding(False)
        Dim fs As FileStream = Nothing
        Dim fileReader As StreamReader = Nothing
        Dim fileWriter As StreamWriter = Nothing

        Try
            If Not File.Exists(customFilePath) Then
                If Not Directory.Exists(Path.GetDirectoryName(customFilePath)) Then
                    Directory.CreateDirectory(Path.GetDirectoryName(customFilePath))
                End If
                File.Copy(originFilePath, customFilePath)
            Else
                fileExist = True
            End If
            File.Copy(customFilePath, backPath, True)

            fs = New FileStream(customFilePath, FileMode.Open)
            fileReader = New StreamReader(backPath, utf8)
            fileWriter = New StreamWriter(fs, utf8)
            fileWriter.NewLine = vbLf

            Dim line As String = fileReader.ReadLine
            Do Until IsNothing(line)
                If line.Trim.StartsWith("private static String HOMEPAGE_URI") Then
                    fileWriter.WriteLine("    private static String HOMEPAGE_URI = """ & homePage & """;")
                Else
                    fileWriter.WriteLine(line)
                End If
                line = fileReader.ReadLine
            Loop
            fileWriter.Close()
            fileReader.Close()
            fs.Close()
            File.Delete(backPath)

            originFilePath = info.ProjectPath & "/sys/vendor/weibu_sz/product/products.mk"
            customFilePath = info.ProjectPath & "/sys/weibu/" & info.MssiDirName &
            "/" & info.CustomDirName & "/alps/vendor/weibu_sz/products/products.mk"
            backPath = customFilePath & ".bk"

            If Not File.Exists(customFilePath) Then
                If Not Directory.Exists(Path.GetDirectoryName(customFilePath)) Then
                    Directory.CreateDirectory(Path.GetDirectoryName(customFilePath))
                End If
                File.Copy(originFilePath, customFilePath)
            Else
                fileExist = True
            End If
            File.Copy(customFilePath, backPath, True)

            fs = New FileStream(customFilePath, FileMode.Open)
            fileReader = New StreamReader(backPath, utf8)
            fileWriter = New StreamWriter(fs, utf8)
            'fileWriter.NewLine = vbLf

            Dim found As Boolean = False

            line = fileReader.ReadLine
            Do Until IsNothing(line)
                If line.Trim.StartsWith("PRODUCT_PACKAGES += PartnerCustomizationsProvider") Then
                    found = True
                End If
                fileWriter.WriteLine(line)
                line = fileReader.ReadLine
            Loop

            If Not found Then
                fileWriter.WriteLine()
                fileWriter.WriteLine("PRODUCT_PACKAGES += PartnerCustomizationsProvider")
            End If

            result = True
        Catch ex As Exception
            Debug.WriteLine("[AndroidTGoogleCustom] SetChromeHomePage=>error: " & ex.ToString)
            needRestore = True
        Finally
            If Not IsNothing(fileWriter) Then
                fileWriter.Close()
                fileWriter = Nothing
            End If
            If Not IsNothing(fileReader) Then
                fileReader.Close()
                fileReader = Nothing
            End If
            If Not IsNothing(fs) Then
                fs.Close()
                fs = Nothing
            End If
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

    Public Function SetEmailSignature(ByRef info As ProjectInfo, ByVal signature As String) As Boolean
        Dim result As Boolean = False
        Dim needRestore As Boolean = False
        Dim fileExist As Boolean = False
        Dim originFilePath As String = info.ProjectPath & "/sys/packages/providers/EmailPartnerProvider/res/values/strings.xml"
        Dim customFilePath As String = info.ProjectPath & "/sys/weibu/" & info.MssiDirName &
            "/" & info.CustomDirName & "/alps/packages/providers/EmailPartnerProvider/res/values/strings.xml"
        Dim backPath As String = customFilePath & ".bk"

        Dim utf8 = New Text.UTF8Encoding(False)
        Dim fs As FileStream = Nothing
        Dim fileReader As StreamReader = Nothing
        Dim fileWriter As StreamWriter = Nothing

        Try
            If Not File.Exists(customFilePath) Then
                If Not Directory.Exists(Path.GetDirectoryName(customFilePath)) Then
                    Directory.CreateDirectory(Path.GetDirectoryName(customFilePath))
                End If
                File.Copy(originFilePath, customFilePath)
            Else
                fileExist = True
            End If
            File.Copy(customFilePath, backPath, True)

            fs = New FileStream(customFilePath, FileMode.Open)
            fileReader = New StreamReader(backPath, utf8)
            fileWriter = New StreamWriter(fs, utf8)
            fileWriter.NewLine = vbLf

            Dim line As String = fileReader.ReadLine
            Do Until IsNothing(line)
                If line.Trim.StartsWith("<string name=""global_signature"">") Then
                    fileWriter.WriteLine("    <string name=""global_signature"">" & signature & "</string>")
                Else
                    fileWriter.WriteLine(line)
                End If
                line = fileReader.ReadLine
            Loop
            fileWriter.Close()
            fileReader.Close()
            fs.Close()
            File.Delete(backPath)

            originFilePath = info.ProjectPath & "/sys/vendor/weibu_sz/product/products.mk"
            customFilePath = info.ProjectPath & "/sys/weibu/" & info.MssiDirName &
            "/" & info.CustomDirName & "/alps/vendor/weibu_sz/products/products.mk"
            backPath = customFilePath & ".bk"

            If Not File.Exists(customFilePath) Then
                If Not Directory.Exists(Path.GetDirectoryName(customFilePath)) Then
                    Directory.CreateDirectory(Path.GetDirectoryName(customFilePath))
                End If
                File.Copy(originFilePath, customFilePath)
            Else
                fileExist = True
            End If
            File.Copy(customFilePath, backPath, True)

            fs = New FileStream(customFilePath, FileMode.Open)
            fileReader = New StreamReader(backPath, utf8)
            fileWriter = New StreamWriter(fs, utf8)
            'fileWriter.NewLine = vbLf

            Dim found As Boolean = False

            line = fileReader.ReadLine
            Do Until IsNothing(line)
                If line.Trim.StartsWith("PRODUCT_PACKAGES += EmailPartnerProvider") Then
                    found = True
                    End Ifdd
                fileWriter.WriteLine(line)
                line = fileReader.ReadLine
            Loop

            If Not found Then
                fileWriter.WriteLine()
                fileWriter.WriteLine("PRODUCT_PACKAGES += EmailPartnerProvider")
            End If

            result = True
        Catch ex As Exception
            Debug.WriteLine("[AndroidTGoogleCustom] SetEmailSignature=>error: " & ex.ToString)
            needRestore = True
        Finally
            If Not IsNothing(fileWriter) Then
                fileWriter.Close()
                fileWriter = Nothing
            End If
            If Not IsNothing(fileReader) Then
                fileReader.Close()
                fileReader = Nothing
            End If
            If Not IsNothing(fs) Then
                fs.Close()
                fs = Nothing
            End If
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
