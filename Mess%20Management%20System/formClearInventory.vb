Imports MySql.Data.MySqlClient
Public Class formClearInventory
    Dim con As New connection 'Mysql Connection used within the Form
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try



            con.connect()
            Dim query As String = "set sql_safe_updates = 0 ;update mess_store set QTY = 0;"
            Dim comm As New MySqlCommand(query, con.conn)
            comm.ExecuteNonQuery()
            MsgBox("Inventory Cleared")



        Catch ex As Exception
            MsgBox("Error Occured ! Please contact SSMS Tech Team !!")
            MsgBox(ex.Message.ToString)

        End Try
    End Sub
End Class