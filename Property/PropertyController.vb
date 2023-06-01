' PropertyController 模块用于设置产品名称、型号、品牌、设备名称和制造商的
Module PropertyController

    ' 更新系统属性面板信息
    '
    ' 隐藏设置状态标签，获取对应属性值并显示在对应编辑框中
    ' 在用户切换到系统属性面板时触发该方法
    '
    Public Sub UpdatePropertyInfo(ByRef form As AndroidSettingsForm)
        Debug.WriteLine("[PropertyController] UpdatePropertyInfo()...")
        form.lbProductNameState.Visible = False
        form.lbProductModelState.Visible = False
        form.lbProductBrandState.Visible = False
        form.lbProductDeviceState.Visible = False
        form.lbProductManufacturerState.Visible = False
        form.tbProductName.Text = AndroidProperty.GetProductName(form.MyProjectInfo)
        form.tbProductModel.Text = AndroidProperty.GetProductModel(form.MyProjectInfo)
        form.tbProductBrand.Text = AndroidProperty.GetProductBrand(form.MyProjectInfo)
        form.tbProductDevice.Text = AndroidProperty.GetProductDevice(form.MyProjectInfo)
        form.tbProductManufacturer.Text = AndroidProperty.GetProductManufacturer(form.MyProjectInfo)
    End Sub

    ' 设置产品名称
    Public Sub SetProductName(ByRef form As AndroidSettingsForm)
        Dim name = form.tbProductName.Text
        If name.Trim.Length > 0 And AndroidProperty.SetProductName(form.MyProjectInfo, name) Then
            form.lbProductNameState.Text = "PASS"
            form.lbProductNameState.ForeColor = Color.Green
            form.lbProductNameState.Visible = True
        Else
            form.lbProductNameState.Text = "FAIL"
            form.lbProductNameState.ForeColor = Color.Red
            form.lbProductNameState.Visible = True
        End If
    End Sub

    ' 设置产品型号
    Public Sub SetProductModel(ByRef form As AndroidSettingsForm)
        Dim model = form.tbProductModel.Text
        If model.Trim.Length > 0 And AndroidProperty.SetProductModel(form.MyProjectInfo, model) Then
            form.lbProductModelState.Text = "PASS"
            form.lbProductModelState.ForeColor = Color.Green
            form.lbProductModelState.Visible = True
        Else
            form.lbProductModelState.Text = "FAIL"
            form.lbProductModelState.ForeColor = Color.Red
            form.lbProductModelState.Visible = True
        End If
    End Sub

    ' 设置产品品牌
    Public Sub SetProductBrand(ByRef form As AndroidSettingsForm)
        Dim brand = form.tbProductBrand.Text
        If brand.Trim.Length > 0 And AndroidProperty.SetProductBrand(form.MyProjectInfo, brand) Then
            form.lbProductBrandState.Text = "PASS"
            form.lbProductBrandState.ForeColor = Color.Green
            form.lbProductBrandState.Visible = True
        Else
            form.lbProductBrandState.Text = "FAIL"
            form.lbProductBrandState.ForeColor = Color.Red
            form.lbProductBrandState.Visible = True
        End If
    End Sub

    ' 设置产品设备名称
    Public Sub SetProductDevice(ByRef form As AndroidSettingsForm)
        Dim device = form.tbProductDevice.Text
        If device.Trim.Length > 0 And AndroidProperty.SetProductDevice(form.MyProjectInfo, device) Then
            form.lbProductDeviceState.Text = "PASS"
            form.lbProductDeviceState.ForeColor = Color.Green
            form.lbProductDeviceState.Visible = True
        Else
            form.lbProductDeviceState.Text = "FAIL"
            form.lbProductDeviceState.ForeColor = Color.Red
            form.lbProductDeviceState.Visible = True
        End If
    End Sub

    ' 设置产品制造商
    Public Sub SetProductManufacturer(ByRef form As AndroidSettingsForm)
        Dim manufacturer = form.tbProductManufacturer.Text
        If manufacturer.Trim.Length > 0 And AndroidProperty.SetProductManufacturer(form.MyProjectInfo, manufacturer) Then
            form.lbProductManufacturerState.Text = "PASS"
            form.lbProductManufacturerState.ForeColor = Color.Green
            form.lbProductManufacturerState.Visible = True
        Else
            form.lbProductManufacturerState.Text = "FAIL"
            form.lbProductManufacturerState.ForeColor = Color.Red
            form.lbProductManufacturerState.Visible = True
        End If
    End Sub

End Module
