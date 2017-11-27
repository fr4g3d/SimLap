Imports MySql.Data.MySqlClient.MySqlConnection
Imports System.Data

Module MySqlConnection_Mod
    '-- MySQL Connection
    Public connDB As New MySql.Data.MySqlClient.MySqlConnection
    Public comDB As New MySql.Data.MySqlClient.MySqlCommand
    Public comBuilderDB As New MySql.Data.MySqlClient.MySqlCommandBuilder
    Public rdDB As MySql.Data.MySqlClient.MySqlDataReader
    Public da As MySql.Data.MySqlClient.MySqlDataAdapter
    Public dt As New DataTable
    Public myError As MySql.Data.MySqlClient.MySqlError
    Public SQL As String
    Public Item As ListViewItem

    Public Sub conecDB()
        'This is the connection for your MySQL
        Dim strServer As String = "localhost"
        Dim strPort As String = "3366"
        Dim strDbase As String = "simadmin_simlap"   'Database name
        Dim strUser As String = "simadmin_simlap"                'Database user
        Dim strPass As String = "simlap123"     'Database password

        'MySQL Connection String
        If connDB.State <> ConnectionState.Open Then connDB.ConnectionString = "server=" & strServer.Trim & "; port=" & strPort.Trim & ";database=" & strDbase.Trim & ";user=" & strUser.Trim & ";password=" & strPass & ";"
        If connDB.State <> ConnectionState.Open Then connDB.Open()
    End Sub

    'Close the connection from database
    Public Sub closeDB()
        If connDB.State <> ConnectionState.Closed Then connDB.Close()
    End Sub

    'Initialize the sql command object
    Public Sub initCMD()
        With comDB
            .Connection = connDB
            .CommandType = CommandType.Text
            .CommandTimeout = 5
        End With
    End Sub

End Module
