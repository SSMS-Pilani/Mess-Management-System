Imports MySql.Data.MySqlClient
Public Class formDeletedExtras
    Dim con As New connection 'Mysql Connection used through the Form

    'On Form Load
    Private Sub formDeletedExtras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fill()
    End Sub

    'Fills the DataGrid with the Proper Data of Deleted Extras
    Private Sub fill()
        Try
            con.connect()
            Dim query As String = "Select * from Student_takes_delete order by creation_date desc"
            Dim comm As New MySqlCommand(query, con.conn)
            Dim dr As MySqlDataReader
            Dim dt As New DataTable
            dr = comm.ExecuteReader
            dt.Load(dr)
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox("Error Occured! Please Try Again")
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    'Handles KeyDown on the Form
    Private Sub formDeletedExtras_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
End Class