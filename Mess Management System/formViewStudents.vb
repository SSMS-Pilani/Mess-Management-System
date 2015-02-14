Imports MySql.Data.MySqlClient
Public Class formViewStudents
    Dim con As New connection 'Mysql Connection used through the Form


    'Handles various KeyPResses on the Form
    Private Sub formViewStudents_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        ElseIf e.KeyCode = Keys.F5 Then
            Controls.Clear()
            InitializeComponent()
            fill()
        End If
    End Sub

    'On FOrm Load
    Private Sub formViewStudents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        fill()
        S_ID.Focus()
    End Sub


    'Handles TextChanged in S_ID tb
    'Fills the Datagrid with all the Revelant Data
    Private Sub S_ID_TextChanged(sender As Object, e As EventArgs) Handles S_ID.TextChanged
        Try
            con.connect()
            Dim query As String
            If SNAME.Text = "" Then
                query = "Select S_ID,IDNO,NAME,BHAWAN,ROOM from Student where S_ID like '%" + S_ID.Text.ToString + "%'"
            Else
                query = "Select S_ID,IDNO,NAME,BHAWAN,ROOM from Student where S_id like '%" + S_ID.Text.ToString + "%' and name like '%" + SNAME.Text.ToString + "%'"
            End If
            Dim comm As New MySqlCommand(query, con.conn)
            Dim dr As MySqlDataReader
            dr = comm.ExecuteReader
            Dim dt As New DataTable
            dt.Load(dr)
            DataGridView1.DataSource = dt
            For a As Integer = 0 To DataGridView1.Columns.Count - 1
                Dim col As DataGridViewColumn = DataGridView1.Columns(a)
                col.Width = 160
            Next
        Catch ex As Exception
            MsgBox("Error Occured! Please Try Again")
            MsgBox(ex.Message.ToString)
            S_ID.Text = ""
            SNAME.Text = ""
            S_ID.Focus()
        End Try
    End Sub

    'Fills the DataGrid with all the Students in the Student Table
    Private Sub fill()
        Try
            con.connect()
            Dim query As String
            query = "Select S_ID,IDNO,NAME,BHAWAN,ROOM from Student"
            Dim comm As New MySqlCommand(query, con.conn)
            Dim dr As MySqlDataReader
            dr = comm.ExecuteReader
            Dim dt As New DataTable
            dt.Load(dr)
            DataGridView1.DataSource = dt
            For a As Integer = 0 To DataGridView1.Columns.Count - 1
                Dim col As DataGridViewColumn = DataGridView1.Columns(a)
                col.Width = 160
            Next
        Catch ex As Exception
            MsgBox("Error Occured! Please Try Again")
            MsgBox(ex.Message.ToString)
            S_ID.Text = ""
            SNAME.Text = ""
            S_ID.Focus()
        End Try
    End Sub

    'Handles TextChanged in SName tb
    'Fills the Datagrid with all the Revelant Data
    Private Sub SNAME_TextChanged(sender As Object, e As EventArgs) Handles SNAME.TextChanged
        Try
            con.connect()
            Dim query As String
            If S_ID.Text = "" Then
                query = "Select S_ID,IDNO,NAME,BHAWAN,ROOM from Student where NAME like '%" + SNAME.Text.ToString + "%'"
            Else
                query = "Select S_ID,IDNO,NAME,BHAWAN,ROOM from Student where NAME like '%" + SNAME.Text.ToString + "%' and S_ID like '%" + S_ID.Text.ToString + "%'"
            End If
            Dim comm As New MySqlCommand(query, con.conn)
            Dim dr As MySqlDataReader
            dr = comm.ExecuteReader
            Dim dt As New DataTable
            dt.Load(dr)
            DataGridView1.DataSource = dt
            For a As Integer = 0 To DataGridView1.Columns.Count - 1
                Dim col As DataGridViewColumn = DataGridView1.Columns(a)
                col.Width = 160
            Next
        Catch ex As Exception
            MsgBox("Error Occured! Please Try Again")
            MsgBox(ex.Message.ToString)
            S_ID.Text = ""
            SNAME.Text = ""
            S_ID.Focus()
        End Try
    End Sub

End Class