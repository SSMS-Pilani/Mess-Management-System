Imports MySql.Data.MySqlClient
Public Class formBlock
    Dim con As New connection 'Mysql Connection Used through the Form

    'On Form Load
    Private Sub formBlock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Controls.Clear()
        InitializeComponent()
        fill()
        S_ID.Focus()
        Me.KeyPreview = True
    End Sub

    'Handles KeyEvents on the Form
    Private Sub formBlock_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    'Fills the DataGrid with the Proper Data of the Blocked Students
    Private Sub fill()
        Try
            con.connect()
            Dim query As String = "Select S_ID,NAME,IDNO,ROOM,BHAWAN from Student where Block = True"
            Dim comm As New MySqlCommand(query, con.conn)
            Dim dr As MySqlDataReader
            dr = comm.ExecuteReader
            Dim dt As New DataTable
            dt.Load(dr)
            DataGridView1.DataSource = dt
            dr.Close()

            'Adjust Width of all the Columns
            For n As Integer = 0 To 4
                Dim column As DataGridViewColumn = DataGridView1.Columns(n)
                column.Width = 83
            Next
        Catch ex As Exception
            MsgBox("Error Occured !")
            MsgBox(ex.Message.ToString)
            Controls.Clear()
            InitializeComponent()
            S_ID.Focus()
        End Try
    End Sub

    'Handles KeyPress on S_ID textbox
    Private Sub S_ID_KeyDown(sender As Object, e As KeyEventArgs) Handles S_ID.KeyDown
        If e.KeyCode = Keys.Enter Then
            If S_ID.Text.Length = 5 Then
                S_ID.Text = "F20" + S_ID.Text + "P"
            ElseIf S_ID.Text.Length = 6 And (S_ID.Text.Contains("H") Or S_ID.Text.Contains("h")) Then
                S_ID.Text = S_ID.Text.Substring(0, 1) + "20" + S_ID.Text.Substring(1, 5) + "P"
            ElseIf S_ID.Text.Length = 6 And (S_ID.Text.Contains("P") Or S_ID.Text.Contains("p")) Then
                S_ID.Text = S_ID.Text.Substring(0, 1) + "20" + S_ID.Text.Substring(1, 5) + "P"
            End If
            If S_ID.Text = "" Then
                MsgBox("Enter Proper S_ID")
                S_ID.Focus()
            Else
                Block.Focus()
            End If
        End If
    End Sub

    'Handles Block Clicked. Executes Update Blocked Query
    Private Sub Block_Click(sender As Object, e As EventArgs) Handles Block.Click
        If S_ID.Text <> "" Then
            Try
                con.connect()
                Dim query As String = "UPDATE Student SET block = true where s_id = '" + S_ID.Text + "'"
                Dim comm As New MySqlCommand(query, con.conn)
                comm.ExecuteNonQuery()
                MsgBox("Student Blocked Successfully")
                fill()
                S_ID.Focus()
                S_ID.Text = ""
            Catch ex As MySqlException
                MsgBox("Error Occured ! Please Try Again")
                MsgBox(ex.Message.ToString)
                fill()
                S_ID.Focus()
                S_ID.Text = ""
            End Try
        End If
    End Sub

    'Handles UnBlock Clicked. Executes Update UnBlocked Query
    Private Sub Unblock_Click(sender As Object, e As EventArgs) Handles Unblock.Click
        If S_ID.Text <> "" Then
            Try
                con.connect()
                Dim query As String = "UPDATE Student SET block = false where s_id = '" + S_ID.Text + "'"
                Dim comm As New MySqlCommand(query, con.conn)
                comm.ExecuteNonQuery()
                MsgBox("Student Unblocked Successfully")
                fill()
                S_ID.Focus()
                S_ID.Text = ""
            Catch ex As MySqlException
                MsgBox("Error Occured ! Please Try Again")
                MsgBox(ex.Message.ToString)
                fill()
                S_ID.Focus()
                S_ID.Text = ""
            End Try
        End If
    End Sub

    'Handles Cancel Clicked
    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub


End Class