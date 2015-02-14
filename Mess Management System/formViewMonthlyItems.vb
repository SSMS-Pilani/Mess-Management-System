Imports MySql.Data.MySqlClient
Public Class formViewMonthlyItems

    Private Sub formViewMonthlyItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        fill()
    End Sub

    Private Sub fill()
        Try
            Dim con As New connection
            con.connect()
            Dim query As String = "SELECT student.S_ID, NAME, BHAWAN, student.ROOM,ITEM_0, ITEM_1, ITEM_2, ITEM_3,ITEM_4,ITEM_5,SUNDAY,MONDAY,WEDNESDAY,THURSDAY,FRIDAY,SATURDAY FROM monthly_details inner join student where monthly_details.S_ID = student.s_id and month_year like '" + MonthCalendar1.SelectionRange.Start.ToString("yyyy-MM") + "%' order by student.bhawan,student.room"
            Dim comm As New MySqlCommand(query, con.conn)
            Dim dr As MySqlDataReader
            Dim dt As New DataTable
            dr = comm.ExecuteReader
            dt.Load(dr)
            DataGridView1.DataSource = dt
            dr.Close()
            For n As Integer = 0 To DataGridView1.Columns.Count - 1
                Dim column As DataGridViewColumn = DataGridView1.Columns(n)
                column.Width = 75
            Next
        Catch ex As Exception
            MsgBox("Error Occurred! Please Try Again!")
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    'Handles various KeyPResses on the Form
    Private Sub formViewMonthlyItems_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        ElseIf e.KeyCode = Keys.F5 Then
            Controls.Clear()
            InitializeComponent()
            fill()
        End If
    End Sub


    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        fill()
    End Sub
End Class