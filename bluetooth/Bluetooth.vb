﻿Module Bluetooth

    Public Function GetDefaultState(ByRef info As ProjectInfo) As Boolean
        If "Android 13".Equals(info.AndroidVersion) Then
            Return AndroidTBluetooth.GetDefaultState(info)
        Else
            Return False
        End If
    End Function

    Public Function GetBluetoothName(ByRef info As ProjectInfo) As String
        If "Android 13".Equals(info.AndroidVersion) Then
            Return AndroidTBluetooth.GetBluetoothName(info)
        Else
            Return ""
        End If
    End Function

    Public Function SetDefaultState(ByRef info As ProjectInfo, ByVal isOpen As Boolean) As Boolean
        If "Android 13".Equals(info.AndroidVersion) Then
            Return AndroidTBluetooth.SetDefaultState(info, isOpen)
        Else
            Return False
        End If
    End Function

    Public Function SetBluetoothName(ByRef info As ProjectInfo, ByVal name As String) As Boolean
        If "Android 13".Equals(info.AndroidVersion) Then
            Return AndroidTBluetooth.SetBluetoothName(info, name)
        Else
            Return False
        End If
    End Function

End Module
