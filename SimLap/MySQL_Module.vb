Imports MySql.Data.MySqlClient
Imports System.Data
Module MySQL_Module
    Public connDB As New MySql.Data.MySqlClient.MySqlConnection
    Public comDB As New MySql.Data.MySqlClient.MySqlCommand
    Public comBuilderDB As New MySql.Data.MySqlClient.MySqlCommandBuilder
    Public rdDB As MySql.Data.MySqlClient.MySqlDataReader
    Public da As MySql.Data.MySqlClient.MySqlDataAdapter
    Public dt As New DataTable
    Public myError As MySql.Data.MySqlClient.MySqlError
    Public SQL As String
    Public Item As ListViewItem

    Public Sub conectDB()
        Dim File = Application.StartupPath + "\Setting.ini"
        Dim Section As String = "Settings", HostName As String = "HostName", PortNum As String = "Port", DBName As String = "DBName", UDBName As String = "UDBName", UPassDB As String = "UPassDB"
        Dim strServer = ReadIni(File, Section, HostName, "")
        Dim strPort = ReadIni(File, Section, PortNum, "")
        Dim strDbase = ReadIni(File, Section, DBName, "")
        Dim strUser = ReadIni(File, Section, UDBName, "")
        Dim strPass = ReadIni(File, Section, UPassDB, "")
        'Dim strServer As String = "localhost"
        'Dim strPort As String = "3366"
        'Dim strDbase As String = "simadmin_simlap"
        'Dim strUser As String = "simadmin_simlap"
        'Dim strPass As String = "simlap123"
        If connDB.State <> ConnectionState.Open Then connDB.ConnectionString = "server=" & strServer.Trim & "; port=" & strPort.Trim & ";database=" & strDbase.Trim & ";user=" & strUser.Trim & ";password=" & strPass & ";"
        If connDB.State <> ConnectionState.Open Then connDB.Open()
    End Sub

    Public Sub closeDB()
        If connDB.State <> ConnectionState.Closed Then connDB.Close()
    End Sub

    Public Sub initCMD()
        With comDB
            .Connection = connDB
            .CommandType = CommandType.Text
            .CommandTimeout = 5
        End With
    End Sub
End Module
