Imports System.ComponentModel
Imports MySql.Data.MySqlClient

Public Class frmMain
    Private Sub loadDataSKPD()
        Try
            SQL = "SELECT unit_id, urpeda FROM dftr_unit WHERE uid1<7 AND uid4>0 AND urpeda != '-'"
            With comDB
                .CommandText = SQL
                .ExecuteNonQuery()
            End With
            rdDB = comDB.ExecuteReader
            If rdDB.HasRows = True Then
                cmbSKPD.Items.Clear()
                While rdDB.Read()
                    cmbSKPD.Items.Add(rdDB("unit_id") & ". " & rdDB("urpeda"))
                End While
            End If
            rdDB.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub loadDataProg()
        Try
            SQL = "SELECT prog_id, progkeg FROM dftr_progkeg WHERE uid2<1 AND progkeg != '-'"
            With comDB
                .CommandText = SQL
                .ExecuteNonQuery()
            End With
            rdDB = comDB.ExecuteReader
            If rdDB.HasRows = True Then
                cmbProgram.Items.Clear()
                While rdDB.Read()
                    cmbProgram.Items.Add(rdDB("prog_id") & ". " & rdDB("progkeg"))
                End While
            End If
            rdDB.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub loadDataKeg()
        Try
            SQL = "SELECT prog_id, progkeg FROM dftr_progkeg WHERE uid2>01 AND progkeg != '-'"
            With comDB
                .CommandText = SQL
                .ExecuteNonQuery()
            End With
            rdDB = comDB.ExecuteReader
            If rdDB.HasRows = True Then
                cmbKegiatan.Items.Clear()
                While rdDB.Read()
                    cmbKegiatan.Items.Add(rdDB("prog_id") & ". " & rdDB("progkeg"))
                End While
            End If
            rdDB.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call conectDB()
        Call initCMD()
        Call loadDataSKPD()
        Call loadDataProg()
        Call loadDataKeg()
    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
    End Sub
    Private Sub cbBidang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSKPD.SelectedIndexChanged
        '
    End Sub

    Private Sub cbBidang_GotFocus(sender As Object, e As EventArgs) Handles cmbSKPD.GotFocus
        '
    End Sub

    Private Sub cmbSKPD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProgram.SelectedIndexChanged
        '
    End Sub

    Private Sub cmbSKPD_GotFocus(sender As Object, e As EventArgs) Handles cmbProgram.GotFocus
        '
    End Sub

End Class
