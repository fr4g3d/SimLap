Imports System.ComponentModel
Imports MySql.Data.MySqlClient

Public Class frmMain
    Private Sub loadDataUrusan()
        Try
            SQL = "SELECT urusan_id, urpeda FROM dftr_urusan WHERE uid1<=6 AND uid3>0 AND urpeda>'-'"
            With comDB
                .CommandText = SQL
                .ExecuteNonQuery()
            End With
            rdDB = comDB.ExecuteReader
            If rdDB.HasRows = True Then
                cmbBidang.Items.Clear()
                While rdDB.Read()
                    cmbBidang.Items.Add(rdDB("urusan_id") & ". " & rdDB("urpeda"))
                End While
            End If
            rdDB.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub loadDataSKPD()
        Try
            SQL = "SELECT unit_id, urpeda FROM dftr_unit WHERE uid1<7 AND uid4>0 AND uid5<1 AND urpeda != '-'"
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
    Private Sub loadDataUnit()
        Try
            SQL = "SELECT unit_id, urpeda FROM dftr_unit WHERE uid1<7 AND uid5>0 AND urpeda != '-'"
            With comDB
                .CommandText = SQL
                .ExecuteNonQuery()
            End With
            rdDB = comDB.ExecuteReader
            If rdDB.HasRows = True Then
                cmbUnit.Items.Clear()
                While rdDB.Read()
                    cmbUnit.Items.Add(rdDB("unit_id") & ". " & rdDB("urpeda"))
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
    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
    End Sub
    Private Sub cbBidang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBidang.SelectedIndexChanged
        'Call loadDataUrusan()
    End Sub

    Private Sub cbBidang_GotFocus(sender As Object, e As EventArgs) Handles cmbBidang.GotFocus
        Call loadDataUrusan()
    End Sub

    Private Sub cmbSKPD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSKPD.SelectedIndexChanged
        ''
    End Sub

    Private Sub cmbSKPD_GotFocus(sender As Object, e As EventArgs) Handles cmbSKPD.GotFocus
        Call loadDataSKPD()
    End Sub

    Private Sub cmbUnit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbUnit.SelectedIndexChanged
        ''
    End Sub

    Private Sub cmbUnit_GotFocus(sender As Object, e As EventArgs) Handles cmbUnit.GotFocus
        Call loadDataUnit()
    End Sub
End Class
