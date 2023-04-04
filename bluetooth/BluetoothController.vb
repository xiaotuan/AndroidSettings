Module BluetoothController

    Public Sub UpdateBluetoothInfo(ByRef form As AndroidSettingsForm)
        form.lbBluetoothStatusState.Visible = False
        form.lbBluetoothNameState.Visible = False

        Dim isOpen As Boolean = Bluetooth.GetDefaultState(form.MyProjectInfo)
        If isOpen Then
            form.rbBluetoothOpen.Checked = True
        Else
            form.rbBluetoothClose.Checked = True
        End If
        form.tbBluetoothName.Text = Bluetooth.GetBluetoothName(form.MyProjectInfo)
    End Sub

    Public Sub SetBluetoothInfos(ByRef form As AndroidSettingsForm)
        If Bluetooth.SetDefaultState(form.MyProjectInfo, form.rbBluetoothOpen.Checked) Then
            form.lbBluetoothStatusState.Text = "PASS"
            form.lbBluetoothStatusState.ForeColor = Color.Green
            form.lbBluetoothStatusState.Visible = True
            If Bluetooth.SetBluetoothName(form.MyProjectInfo, form.tbBluetoothName.Text) Then
                form.lbBluetoothNameState.Text = "PASS"
                form.lbBluetoothNameState.ForeColor = Color.Green
                form.lbBluetoothNameState.Visible = True
            Else
                form.lbBluetoothNameState.Text = "FAIL"
                form.lbBluetoothNameState.ForeColor = Color.Red
                form.lbBluetoothNameState.Visible = True
            End If
        Else
            form.lbBluetoothStatusState.Text = "FAIL"
            form.lbBluetoothStatusState.ForeColor = Color.Red
            form.lbBluetoothStatusState.Visible = True
        End If
    End Sub

End Module
