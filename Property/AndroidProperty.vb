' AndroidProperty 模块是一个接口，用于分离实现代码，它会根据不同的系统版本选择调用相应的实现模块
' 当前只实现了 Android 13 版本的修改
Module AndroidProperty

    ' 根据传递过来的 Android 版本号调用对应的实现模块获取产品名称
    Public Function GetProductName(ByRef info As ProjectInfo) As String
        If "Android 13".Equals(info.AndroidVersion) Then
            Return AndroidTProperty.GetProductName(info)
        Else
            Return ""
        End If
    End Function

    ' 根据传递过来的 Android 版本号调用对应的实现模块获取产品型号
    Public Function GetProductModel(ByRef info As ProjectInfo) As String
        If "Android 13".Equals(info.AndroidVersion) Then
            Return AndroidTProperty.GetProductModel(info)
        Else
            Return ""
        End If
    End Function

    ' 根据传递过来的 Android 版本号调用对应的实现模块获取产品品牌
    Public Function GetProductBrand(ByRef info As ProjectInfo) As String
        If "Android 13".Equals(info.AndroidVersion) Then
            Return AndroidTProperty.GetProductBrand(info)
        Else
            Return ""
        End If
    End Function

    ' 根据传递过来的 Android 版本号调用对应的实现模块获取产品设备名称
    Public Function GetProductDevice(ByRef info As ProjectInfo) As String
        If "Android 13".Equals(info.AndroidVersion) Then
            Return AndroidTProperty.GetProductDevice(info)
        Else
            Return ""
        End If
    End Function

    ' 根据传递过来的 Android 版本号调用对应的实现模块获取产品制造商
    Public Function GetProductManufacturer(ByRef info As ProjectInfo) As String
        If "Android 13".Equals(info.AndroidVersion) Then
            Return AndroidTProperty.GetProductManufacturer(info)
        Else
            Return ""
        End If
    End Function

    ' 根据传递过来的 Android 版本号调用对应的实现模块设置产品名称
    Public Function SetProductName(ByRef info As ProjectInfo, ByVal name As String) As Boolean
        If "Android 13".Equals(info.AndroidVersion) Then
            Return AndroidTProperty.SetProductName(info, name)
        Else
            Return ""
        End If
    End Function

    ' 根据传递过来的 Android 版本号调用对应的实现模块设置产品型号
    Public Function SetProductModel(ByRef info As ProjectInfo, ByVal model As String) As Boolean
        If "Android 13".Equals(info.AndroidVersion) Then
            Return AndroidTProperty.SetProductModel(info, model)
        Else
            Return ""
        End If
    End Function

    ' 根据传递过来的 Android 版本号调用对应的实现模块设置产品品牌
    Public Function SetProductBrand(ByRef info As ProjectInfo, ByVal brand As String) As Boolean
        If "Android 13".Equals(info.AndroidVersion) Then
            Return AndroidTProperty.SetProductBrand(info, brand)
        Else
            Return ""
        End If
    End Function

    ' 根据传递过来的 Android 版本号调用对应的实现模块设置产品设备名称
    Public Function SetProductDevice(ByRef info As ProjectInfo, ByVal device As String) As Boolean
        If "Android 13".Equals(info.AndroidVersion) Then
            Return AndroidTProperty.SetProductDevice(info, device)
        Else
            Return ""
        End If
    End Function

    ' 根据传递过来的 Android 版本号调用对应的实现模块设置产品名称
    Public Function SetProductManufacturer(ByRef info As ProjectInfo, ByVal manufacturer As String) As Boolean
        If "Android 13".Equals(info.AndroidVersion) Then
            Return AndroidTProperty.SetProductManufacturer(info, manufacturer)
        Else
            Return ""
        End If
    End Function
End Module
