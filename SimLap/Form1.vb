﻿Imports System.ComponentModel
Public Class frmMain
    Dim File = Application.StartupPath + "\Setting.ini"
    Dim Section As String = "Settings", HostName As String = "HostName", PortNum As String = "Port", DBName As String = "DBName", UDBName As String = "UDBName", UPassDB As String = "UPassDB"
    Dim getHostName = ReadIni(File, Section, HostName, "")
    Dim getPortNum = ReadIni(File, Section, PortNum, "")
    Dim getDBName = ReadIni(File, Section, DBName, "")
    Dim getUDBName = ReadIni(File, Section, UDBName, "")
    Dim getUPassDB = ReadIni(File, Section, UPassDB, "")
    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Call closeMySQL()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call connMySQL(“SERVER = " + getHostName + "; PORT = " + getPortNum + "; USERID = " + getUDBName + "; PASSWORD = " + getUPassDB + "; DATABASE = " + getDBName + "; Convert Zero Datetime=True; Allow Zero Datetime=True;”)
    End Sub

    Private Sub SettingToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frmSetting.MdiParent = Me
        frmSetting.TopMost = True
        frmSetting.Show()
    End Sub
End Class