Module Utils

    Public Function IsEmptyText(Optional value As String = Nothing) As Boolean
        If value Is Nothing Or Len(value.Trim) = 0 Then
            Return True
        End If
        Return False
    End Function

End Module
