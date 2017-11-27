Imports MySql.Data.MySqlClient
Imports System.Data
Module MySQL_Module
    'Public Server As String = “SERVER = " + HostName + "; PORT = 3366; USERID = simadmin_simlap; PASSWORD = simlap123; DATABASE = simadmin_simlap; Convert Zero Datetime=True; Allow Zero Datetime=True;”
    Public sConnection As New MySqlConnection
    Public sqlCommand As New MySqlCommand
    Public sqlAdapter As New MySqlDataAdapter
    Public confirmMsgMySQL As MsgBoxResult
    Public DR As MySqlDataReader
    Public DT As New DataTable
    Public Sub connMySQL(svr As String)
        If sConnection.State = ConnectionState.Closed Then
            sConnection.ConnectionString = svr
            sConnection.Open()
        End If
    End Sub
    Public Sub closeMySQL()
        With sConnection
            .Dispose()
            .Close()
        End With
    End Sub
End Module
