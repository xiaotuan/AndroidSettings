Module AndroidProperty

    Public Function GetProductName(ByRef info As ProjectInfo) As String
        If info.AndroidVersion.Equals("Android 13") Then
            Return AndroidTProperty.GetProductName(info)
        Else
            Return ""
        End If
    End Function

    Public Function GetProductModel(ByRef info As ProjectInfo) As String
        If info.AndroidVersion.Equals("Android 13") Then
            Return AndroidTProperty.GetProductModel(info)
        Else
            Return ""
        End If
    End Function

    Public Function GetProductBrand(ByRef info As ProjectInfo) As String
        If info.AndroidVersion.Equals("Android 13") Then
            Return AndroidTProperty.GetProductBrand(info)
        Else
            Return ""
        End If
    End Function

    Public Function GetProductDevice(ByRef info As ProjectInfo) As String
        If info.AndroidVersion.Equals("Android 13") Then
            Return AndroidTProperty.GetProductDevice(info)
        Else
            Return ""
        End If
    End Function

    Public Function GetProductManufacturer(ByRef info As ProjectInfo) As String
        If info.AndroidVersion.Equals("Android 13") Then
            Return AndroidTProperty.GetProductManufacturer(info)
        Else
            Return ""
        End If
    End Function

    Public Function SetProductName(ByRef info As ProjectInfo, ByVal name As String) As Boolean
        If info.AndroidVersion.Equals("Android 13") Then
            Return AndroidTProperty.SetProductName(info, name)
        Else
            Return ""
        End If
    End Function

    Public Function SetProductModel(ByRef info As ProjectInfo, ByVal model As String) As Boolean
        If info.AndroidVersion.Equals("Android 13") Then
            Return AndroidTProperty.SetProductModel(info, model)
        Else
            Return ""
        End If
    End Function

    Public Function SetProductBrand(ByRef info As ProjectInfo, ByVal brand As String) As Boolean
        If info.AndroidVersion.Equals("Android 13") Then
            Return AndroidTProperty.SetProductBrand(info, brand)
        Else
            Return ""
        End If
    End Function

    Public Function SetProductDevice(ByRef info As ProjectInfo, ByVal device As String) As Boolean
        If info.AndroidVersion.Equals("Android 13") Then
            Return AndroidTProperty.SetProductDevice(info, device)
        Else
            Return ""
        End If
    End Function

    Public Function SetProductManufacturer(ByRef info As ProjectInfo, ByVal manufacturer As String) As Boolean
        If info.AndroidVersion.Equals("Android 13") Then
            Return AndroidTProperty.SetProductManufacturer(info, manufacturer)
        Else
            Return ""
        End If
    End Function
End Module
