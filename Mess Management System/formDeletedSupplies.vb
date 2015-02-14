Imports MySql.Data.MySqlClient
Public Class formDeletedSupplies
    Dim con As New connection 'Mysql Connection to be used through the Form

    'On Form Load
    Private Sub formDeletedSupplies_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        fill()
    End Sub


    'Handles KeyPresses on the Form
    Private Sub formDeletedSupplies_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    'Fills the DataGrid view with the Data regarding Deleted Supplies Entries
    Private Sub fill()
        Try
            con.connect()
            Dim query As String = "Select * from Mess_takes_delete order by creation_date desc"
            Dim comm As New MySqlCommand(query, con.conn)
            Dim dr As MySqlDataReader
            Dim dt As New DataTable
            dr = comm.ExecuteReader
            dt.Load(dr)
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox("Error Occured ! Please Try Again")
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

End Class