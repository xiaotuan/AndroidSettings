Module PropertyController

    Public Sub SetProperties(ByRef form As AndroidSettingsForm)
        Dim name = form.tbProductName.Text
        Dim model = form.tbProductModel.Text
        Dim brand = form.tbProductBrand.Text
        Dim device = form.tbProductDevice.Text
        Dim manufacturer = form.tbProductManufacturer.Text
        If IsEmptyText(name) Then
            MessageBox.Show(form, "产品名称不能为空！", "提示")
            Return
        End If
        If IsEmptyText(model) Then
            MessageBox.Show(form, "产品型号不能为空！", "提示")
            Return
        End If
        If IsEmptyText(brand) Then
            MessageBox.Show("设备品牌不能为空！", "提示")
            Return
        End If
        If IsEmptyText(device) Then
            MessageBox.Show("设备名称不能为空！", "提示")
            Return
        End If
        If IsEmptyText(manufacturer) Then
            MessageBox.Show("设备制造商不能为空！", "提示")
            Return
        End If
        If AndroidProperty.SetProductName(form.MyProjectInfo, name) Then
            form.lbProductNameState.Text = "PASS"
            form.lbProductNameState.ForeColor = Color.Green
            form.lbProductNameState.Visible = True
            If AndroidProperty.SetProductModel(form.MyProjectInfo, model) Then
                form.lbProductModelState.Text = "PASS"
                form.lbProductModelState.ForeColor = Color.Green
                form.lbProductModelState.Visible = True
                If AndroidProperty.SetProductBrand(form.MyProjectInfo, brand) Then
                    form.lbProductBrandState.Text = "PASS"
                    form.lbProductBrandState.ForeColor = Color.Green
                    form.lbProductBrandState.Visible = True
                    If AndroidProperty.SetProductDevice(form.MyProjectInfo, device) Then
                        form.lbProductDeviceState.Text = "PASS"
                        form.lbProductDeviceState.ForeColor = Color.Green
                        form.lbProductDeviceState.Visible = True
                        If AndroidProperty.SetProductManufacturer(form.MyProjectInfo, manufacturer) Then
                            form.lbProductManufacturerState.Text = "PASS"
                            form.lbProductManufacturerState.ForeColor = Color.Green
                            form.lbProductManufacturerState.Visible = True
                        Else
                            form.lbProductManufacturerState.Text = "FAIL"
                            form.lbProductManufacturerState.ForeColor = Color.Red
                            form.lbProductManufacturerState.Visible = True
                        End If
                    Else
                        form.lbProductDeviceState.Text = "FAIL"
                        form.lbProductDeviceState.ForeColor = Color.Red
                        form.lbProductDeviceState.Visible = True
                    End If
                Else
                    form.lbProductBrandState.Text = "FAIL"
                    form.lbProductBrandState.ForeColor = Color.Red
                    form.lbProductBrandState.Visible = True
                End If
            Else
                form.lbProductModelState.Text = "FAIL"
                form.lbProductModelState.ForeColor = Color.Red
                form.lbProductModelState.Visible = True
            End If
        Else
            form.lbProductNameState.Text = "FAIL"
            form.lbProductNameState.ForeColor = Color.Red
            form.lbProductNameState.Visible = True
        End If
    End Sub

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

    Private Function IsEmptyText(ByVal str As String) As Boolean
        If IsNothing(str) Or Len(str.Trim) = 0 Then
            Return True
        End If
        Return False
    End Function

End Module
