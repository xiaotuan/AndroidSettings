Module Utils

    Public Function IsEmptyText(ByVal value As String) As Boolean
        If IsNothing(value) Or Len(value.Trim) = 0 Then
            Return True
        End If
        Return False
    End Function

End Module
