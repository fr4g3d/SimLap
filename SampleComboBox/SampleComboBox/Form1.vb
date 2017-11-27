Public Class Form1
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call conecDB()      'Open the connection to database
        Call initCMD()      'Initialize the sqlclient command object
        'Call LoadDataCmbSupplier()
    End Sub

    Private Sub LoadDataCmbSupplier()
        Try
            'Tampilkan User Akses Group Pada Combo Box
            SQL = "SELECT urusan_id, urpeda FROM dftr_urusan "

            With comDB
                .CommandText = SQL
                .ExecuteNonQuery()
            End With
            rdDB = comDB.ExecuteReader
            If rdDB.HasRows = True Then
                cmbSupplier.Items.Clear()
                While rdDB.Read()
                    cmbSupplier.Items.Add(rdDB("urusan_id") & " - " & rdDB("urpeda"))
                    'cmbSupplier.Items.Add(rdDB("urpeda"))
                End While
            End If
            rdDB.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub cmbSupplier_GotFocus(sender As Object, e As EventArgs) Handles cmbSupplier.GotFocus
        Call LoadDataCmbSupplier()
    End Sub
End Class
