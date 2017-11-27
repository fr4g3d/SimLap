Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class MySQL_Conn_Class
    Dim dbCon As MySqlConnection

    Public Sub ManageConnection(ByVal CloseConnection As Boolean)
        Try
            'Prepare connection and query'
            dbCon = New MySqlConnection("Server=localhost; User Id = root; Pwd = 12345; Database = digitallibrary")
            If CloseConnection = False Then
                If dbCon.State = ConnectionState.Closed Then _
                        dbCon.Open()
            Else
                dbCon.Close()
            End If
        Catch ex As Exception
            MsgBox("FAIL")
        End Try

    End Sub

    Public Sub Insert(ByVal ln As String, ByVal fn As String, ByVal mn As String, ByVal user As String, ByVal email As String, ByVal bdate As String, ByVal jdate As String, ByVal jtime As String, ByVal pwd As String)
        Try
            ManageConnection(True) 'Open connection'

            Dim strQuery As String = "INSERT INTO user_tbl(user_ln,user_fn,user_mn,username,user_email,user_bdate, user_jdate, user_jtime)" &
                    "VALUES('" + ln + "','" + fn + "','" + mn + "','" + user + "','" + email + "','" + bdate + "','" + jdate + "','" + jtime + "' );" &
                    "INSERT INTO login_tbl(username,password)VALUES('" + user + "','" + pwd + "')"

            Dim SqlCmd As New MySqlCommand(strQuery, dbCon)
            SqlCmd.ExecuteNonQuery()

            ManageConnection(False) 'Close connection'

        Catch ex As Exception
            MsgBox("Error " & ex.Message)
        End Try
    End Sub
End Class
