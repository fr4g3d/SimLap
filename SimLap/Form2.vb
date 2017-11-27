Imports System.ComponentModel

Public Class frmSetting
    Dim File = Application.StartupPath + "\Setting.ini"
    Dim Section As String = "Settings", HostName As String = "HostName", PortNum As String = "Port", DBName As String = "DBName", UDBName As String = "UDBName", UPassDB As String = "UPassDB"
    Dim getHostName = ReadIni(File, Section, HostName, "")
    Dim getPortNum = ReadIni(File, Section, PortNum, "")
    Dim getDBName = ReadIni(File, Section, DBName, "")
    Dim getUDBName = ReadIni(File, Section, UDBName, "")
    Dim getUPassDB = ReadIni(File, Section, UPassDB, "")
    Private Sub frmSetting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If ReadIni(File, Section, HostName, "") = "" Then
            writeIni(File, Section, HostName, "localhost")
            writeIni(File, Section, PortNum, "3306")
            writeIni(File, Section, DBName, "simadmin_simlap")
            writeIni(File, Section, UDBName, "simadmin_simlap")
            writeIni(File, Section, UPassDB, "simlap123")
        End If
        tbHostName.Text = ReadIni(File, Section, HostName, "")
        tbPort.Text = ReadIni(File, Section, PortNum, "")
        tbDBName.Text = ReadIni(File, Section, DBName, "")
        tbUDBName.Text = ReadIni(File, Section, UDBName, "")
        tbUPassDB.Text = ReadIni(File, Section, UPassDB, "")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnReloadSetting.Click
        tbHostName.Text = ReadIni(File, Section, HostName, "")
        tbPort.Text = ReadIni(File, Section, PortNum, "")
        tbDBName.Text = ReadIni(File, Section, DBName, "")
        tbUDBName.Text = ReadIni(File, Section, UDBName, "")
        tbUPassDB.Text = ReadIni(File, Section, UPassDB, "")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSaveSetting.Click
        writeIni(File, Section, HostName, tbHostName.Text)
        writeIni(File, Section, PortNum, tbPort.Text)
        writeIni(File, Section, DBName, tbDBName.Text)
        writeIni(File, Section, UDBName, tbUDBName.Text)
        writeIni(File, Section, UPassDB, tbUPassDB.Text)
        MsgBox("Data Setting is Saved..!")
        Call closeDB()
        Call conectDB()
        Call closeDB()
    End Sub

    Private Sub frmSetting_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Call closeDB()
    End Sub
End Class