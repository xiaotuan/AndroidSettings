Module TimezoneController

    Public Sub UpdateTimezone(ByRef form As AndroidSettingsForm)
        form.lbTimezoneState.Visible = False
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

    Public Sub SetTimezone(ByRef form As AndroidSettingsForm)
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
    End Sub

End Module
