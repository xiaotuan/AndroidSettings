﻿Module ProjectConfigControler

    Public Sub UpdateAndroidProjectConfigFromProjectId(ConfigForm As AndroidSettingsForm, ProjectId As String)
        Dim Found As Boolean = False
        For Each Project As ProjectInfo In ConfigForm.Projects
            If Project.ProjectId.Equals(ProjectId) Then
                Found = True
                ConfigForm.CbAndroidVersion.Text = Project.AndroidVersion
                ConfigForm.CbPublicName.Text = Project.PublicDirName
                ConfigForm.CbMssiName.Text = Project.MssiDirName
                ConfigForm.CbDriveName.Text = Project.DriveDirName
                ConfigForm.CbCustomName.Text = Project.CustomDirName
                ConfigForm.CbChiperMaker.Text = Project.ChiperMaker
                ConfigForm.CbChiperModel.Text = Project.ChiperModel
                Select Case Project.Gms
                    Case 0
                        ConfigForm.RbNotGms.Checked = True
                        ConfigForm.RbGms.Checked = False
                    Case 1
                        ConfigForm.RbNotGms.Checked = False
                        ConfigForm.RbGms.Checked = True
                End Select
                Select Case Project.Go
                    Case 0
                        ConfigForm.RbNotGo.Checked = True
                        ConfigForm.RbOneGbGo.Checked = False
                        ConfigForm.RbTwoGbGo.Checked = False
                    Case 1
                        ConfigForm.RbNotGo.Checked = False
                        ConfigForm.RbOneGbGo.Checked = True
                        ConfigForm.RbTwoGbGo.Checked = False
                    Case 2
                        ConfigForm.RbNotGo.Checked = False
                        ConfigForm.RbOneGbGo.Checked = False
                        ConfigForm.RbTwoGbGo.Checked = True
                End Select
                ConfigForm.MyProjectInfo.ProjectId = Project.ProjectId
                ConfigForm.MyProjectInfo.PublicDirName = Project.PublicDirName
                ConfigForm.MyProjectInfo.MssiDirName = Project.MssiDirName
                ConfigForm.MyProjectInfo.DriveDirName = Project.DriveDirName
                ConfigForm.MyProjectInfo.CustomDirName = Project.CustomDirName
                ConfigForm.MyProjectInfo.ChiperMaker = Project.ChiperMaker
                ConfigForm.MyProjectInfo.ChiperModel = Project.ChiperModel
                ConfigForm.MyProjectInfo.Gms = Project.Gms
                ConfigForm.MyProjectInfo.Go = Project.Go

                ConfigForm.InitPublicNameComboBox()
                ConfigForm.InitMssiNameComboBox()
                ConfigForm.InitDriveNameComboBox()
                ConfigForm.InitCustomNameComboBox()
                ConfigForm.InitChiperModelComboBox()
            End If
        Next

    End Sub

End Module
