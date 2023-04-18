Module TimezoneController

    Public Sub UpdateTimezoneInfos(ByRef form As AndroidSettingsForm)
        form.lbAutoTimezoneState.Visible = False
        form.lbTimezoneState.Visible = False
        Dim isOpen As Boolean = Timezone.GetAutoTimezoneState(form.MyProjectInfo)
        If isOpen Then
            form.rbTimezoneOpen.Checked = True
        Else
            form.rbTimezoneClose.Checked = True
        End If
        Dim zone = Timezone.GetTimezone(form.MyProjectInfo)
        Dim found As Boolean = False
        For Each item As String In form.cbTimezone.Items
            Dim z = item.Split("-")(1)
            If z.Equals(zone) Then
                form.cbTimezone.Text = item
                found = True
            End If
        Next
        If Not found Then
            form.cbTimezone.Text = zone
        End If
    End Sub

    Public Sub SetTimezoneInfos(ByRef form As AndroidSettingsForm)
        If Timezone.SetAutoTimezone(form.MyProjectInfo, form.rbTimezoneOpen.Checked) Then
            form.lbAutoTimezoneState.Text = "PASS"
            form.lbAutoTimezoneState.ForeColor = Color.Green
            form.lbAutoTimezoneState.Visible = True

            Dim zone = form.cbTimezone.Text
            If zone.Contains("-") And zone.Split("-").Length() = 2 Then
                zone = zone.Split("-")(1)
            End If
            If Not Utils.IsEmptyText(zone) And Timezone.SetTimezone(form.MyProjectInfo, zone) Then
                form.lbTimezoneState.Text = "PASS"
                form.lbTimezoneState.ForeColor = Color.Green
                form.lbTimezoneState.Visible = True
            Else
                form.lbTimezoneState.Text = "FAIL"
                form.lbTimezoneState.ForeColor = Color.Red
                form.lbTimezoneState.Visible = True
            End If
        Else
            form.lbAutoTimezoneState.Text = "FAIL"
            form.lbAutoTimezoneState.ForeColor = Color.Red
            form.lbAutoTimezoneState.Visible = True
        End If
    End Sub

End Module
