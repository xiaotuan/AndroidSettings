Imports System.IO
Imports System.Runtime.Intrinsics.Arm
Imports System.Text.Json
Imports System.Text.Json.Nodes

Module AndroidProjectInit

    Public Class ProjectComparer
        Implements IComparer

        ' Calls CaseInsensitiveComparer.Compare with the parameters reversed.
        Public Function Compare(ByVal x As Object, ByVal y As Object) As Integer _
         Implements IComparer.Compare
            Dim xo = TryCast(x, ProjectInfo)
            Dim yo = TryCast(y, ProjectInfo)
            Return xo.ProjectId.CompareTo(yo.ProjectId)
        End Function 'IComparer.Compare

    End Class

    Public Sub Init(ByRef form As AndroidSettingsForm)
        Debug.WriteLine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments))
        Dim MyDocumentFloderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\AndroidProjectConfig"
        If Not Directory.Exists(MyDocumentFloderPath) Then
            Directory.CreateDirectory(MyDocumentFloderPath)
        End If
        Dim ConfigFilePath = MyDocumentFloderPath & "\config.json"
        If Not File.Exists(ConfigFilePath) Then
            Dim DefaultConfigPath = Application.StartupPath & "\config.json"
            Debug.WriteLine("DefaultConfigPath: " & DefaultConfigPath)
            File.Copy(DefaultConfigPath, ConfigFilePath, True)
        End If
        Dim JsonString = File.ReadAllText(ConfigFilePath)
        Dim RootNode = JsonDocument.Parse(JsonString).RootElement
        For Each item As JsonProperty In RootNode.EnumerateObject()
            If item.NameEquals("Projects") Then
                InitProject(form, item.Value)
            ElseIf item.NameEquals("AndroidVersions") Then
                InitVersion(form, item.Value)
            ElseIf item.NameEquals("ProjectPaths") Then
                InitProjectPath(form, item.Value)
            ElseIf item.NameEquals("PublicDirNames") Then
                InitPublicDirName(form, item.Value)
            ElseIf item.NameEquals("MssiDirNames") Then
                InitMssiDirName(form, item.Value)
            ElseIf item.NameEquals("DriveDirNames") Then
                InitDriveDirName(form, item.Value)
            ElseIf item.NameEquals("CustomDirNames") Then
                InitCustomDirName(form, item.Value)
            ElseIf item.NameEquals("ChiperMakers") Then
                InitChiperMaker(form, item.Value)
            ElseIf item.NameEquals("ChiperModels") Then
                InitChiperModel(form, item.Value)
            ElseIf item.NameEquals("Languages") Then
                InitLanguage(form, item.Value)
            ElseIf item.NameEquals("Timezones") Then
                InitTimezone(form, item.Value)
            End If
        Next
    End Sub

    Public Sub InitProject(ByRef form As AndroidSettingsForm, ByRef projectElement As JsonElement)
        For Each project As JsonElement In projectElement.EnumerateArray()
            Debug.WriteLine("[AndroidProjectInit] InitProject=>project: " & project.ToString)
            Dim info = New ProjectInfo()
            For Each item As JsonProperty In project.EnumerateObject()
                If item.NameEquals("ProjectId") Then
                    info.ProjectId = item.Value.GetString
                ElseIf item.NameEquals("AndroidVersion") Then
                    info.AndroidVersion = item.Value.GetString
                ElseIf item.NameEquals("ProjectPath") Then
                    info.ProjectPath = item.Value.GetString
                ElseIf item.NameEquals("PublicDirName") Then
                    info.PublicDirName = item.Value.GetString
                ElseIf item.NameEquals("MssiDirName") Then
                    info.MssiDirName = item.Value.GetString
                ElseIf item.NameEquals("DriveDirName") Then
                    info.DriveDirName = item.Value.GetString
                ElseIf item.NameEquals("CustomDirName") Then
                    info.CustomDirName = item.Value.GetString
                ElseIf item.NameEquals("Gms") Then
                    info.Gms = item.Value.GetInt32
                ElseIf item.NameEquals("Go") Then
                    info.Go = item.Value.GetInt32
                ElseIf item.NameEquals("ChiperMaker") Then
                    info.ChiperMaker = item.Value.GetString
                ElseIf item.NameEquals("ChiperModel") Then
                    info.ChiperModel = item.Value.GetString
                End If
            Next
            Debug.WriteLine("[AndroidProjectInit] InitProject=>info: " & info.ToString)
            form.Projects.Add(info)
        Next
        form.Projects.Sort(New ProjectComparer())
    End Sub

    Public Sub InitVersion(ByRef form As AndroidSettingsForm, ByRef versionElement As JsonElement)
        For Each item As JsonElement In versionElement.EnumerateArray()
            Debug.WriteLine("[AndroidProjectInit] InitVersion=>item: " & item.GetString)
            form.Versions.Add(item.GetString)
        Next
        form.Versions.Sort()
    End Sub

    Public Sub InitProjectPath(ByRef form As AndroidSettingsForm, ByRef pathElement As JsonElement)
        For Each item As JsonElement In pathElement.EnumerateArray()
            Debug.WriteLine("[InitProjectPath] InitProjectPath=>item: " & item.GetString)
            form.ProjectPaths.Add(item.GetString)
        Next
        form.ProjectPaths.Sort()
    End Sub

    Public Sub InitPublicDirName(ByRef form As AndroidSettingsForm, ByRef publicDirNameElement As JsonElement)
        For Each item As JsonProperty In publicDirNameElement.EnumerateObject()
            Dim Names As ArrayList = New ArrayList()
            Debug.WriteLine("[InitProjectPath] InitPublicDirName=>item name: " & item.Name)
            For Each name As JsonElement In item.Value().EnumerateArray()
                Debug.WriteLine("[InitProjectPath] InitPublicDirName=>name: " & name.GetString)
                Names.Add(name.GetString)
            Next
            Names.Sort()
            form.PublicNames.Add(item.Name, Names)
        Next
    End Sub

    Public Sub InitMssiDirName(ByRef form As AndroidSettingsForm, ByRef mssiDirNameElement As JsonElement)
        For Each item As JsonProperty In mssiDirNameElement.EnumerateObject()
            Dim Names As ArrayList = New ArrayList()
            Debug.WriteLine("[InitProjectPath] InitMssiDirName=>item name: " & item.Name)
            For Each name As JsonElement In item.Value().EnumerateArray()
                Debug.WriteLine("[InitProjectPath] InitMssiDirName=>name: " & name.GetString)
                Names.Add(name.GetString)
            Next
            Names.Sort()
            form.MssiNames.Add(item.Name, Names)
        Next
    End Sub

    Public Sub InitDriveDirName(ByRef form As AndroidSettingsForm, ByRef driveDirName As JsonElement)
        For Each item As JsonProperty In driveDirName.EnumerateObject()
            Dim DriveNames As Hashtable = New Hashtable()
            For Each otherItem As JsonProperty In item.Value.EnumerateObject()
                Dim Names As ArrayList = New ArrayList()
                Debug.WriteLine("[InitProjectPath] InitDriveDirName=>item name: " & otherItem.Name)
                For Each name As JsonElement In otherItem.Value().EnumerateArray()
                    Debug.WriteLine("[InitProjectPath] InitDriveDirName=>name: " & name.GetString)
                    Names.Add(name.GetString)
                Next
                Names.Sort()
                DriveNames.Add(otherItem.Name, Names)
            Next
            form.DriveNames.Add(item.Name, DriveNames)
        Next
    End Sub

    Public Sub InitCustomDirName(ByRef form As AndroidSettingsForm, ByRef customDirNameElement As JsonElement)
        For Each item As JsonProperty In customDirNameElement.EnumerateObject()
            Dim DriveNames As Hashtable = New Hashtable()
            For Each otherItem As JsonProperty In item.Value.EnumerateObject()
                Dim Names As ArrayList = New ArrayList()
                Debug.WriteLine("[InitProjectPath] InitCustomDirName=>item name: " & otherItem.Name)
                For Each name As JsonElement In otherItem.Value().EnumerateArray()
                    Debug.WriteLine("[InitProjectPath] InitCustomDirName=>name: " & name.GetString)
                    Names.Add(name.GetString)
                Next
                Names.Sort()
                DriveNames.Add(otherItem.Name, Names)
            Next
            form.CustomNames.Add(item.Name, DriveNames)
        Next
    End Sub

    Public Sub InitChiperMaker(ByRef form As AndroidSettingsForm, ByRef chiperMakerElement As JsonElement)
        For Each item As JsonElement In chiperMakerElement.EnumerateArray()
            Debug.WriteLine("[AndroidProjectInit] InitChiperMaker=>item: " & item.GetString)
            form.ChiperMakers.Add(item.GetString)
        Next
        form.ChiperMakers.Sort()
    End Sub

    Public Sub InitChiperModel(ByRef form As AndroidSettingsForm, ByRef chiperModelElement As JsonElement)
        For Each item As JsonProperty In chiperModelElement.EnumerateObject()
            Dim Names As ArrayList = New ArrayList()
            Debug.WriteLine("[InitProjectPath] InitChiperModel=>item name: " & item.Name)
            For Each name As JsonElement In item.Value().EnumerateArray()
                Debug.WriteLine("[InitProjectPath] InitChiperModel=>name: " & name.GetString)
                Names.Add(name.GetString)
            Next
            Names.Sort()
            form.ChiperModels.Add(item.Name, Names)
        Next
    End Sub

    Public Sub InitLanguage(ByRef form As AndroidSettingsForm, ByRef languageElement As JsonElement)
        For Each item As JsonElement In languageElement.EnumerateArray()
            Debug.WriteLine("[AndroidProjectInit] InitLanguage=>item: " & item.GetString)
            form.Languages.Add(item.GetString)
        Next
        form.Languages.Sort()
    End Sub

    Public Sub InitTimezone(ByRef form As AndroidSettingsForm, ByRef timezoneElement As JsonElement)
        For Each item As JsonElement In timezoneElement.EnumerateArray()
            Debug.WriteLine("[AndroidProjectInit] InitTimezone=>item: " & item.GetString)
            form.Timezones.Add(item.GetString)
        Next
        form.Timezones.Sort()
    End Sub

End Module
