Imports MySql.Data.MySqlClient
Public Class formStudentAccount
    Dim con As New connection 'Mysql Connection used through the Form

    'Handles Various KeyPresses on the Form
    Private Sub formStudentAccount_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        ElseIf e.KeyCode = Keys.F12 Then
            reload()
        End If
    End Sub

    'On Form Load
    Private Sub StudentAccount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load 'Once Loaded
        Me.KeyPreview = True
        'fill()
        S_ID.Focus()
    End Sub

    'Refreshes the Form
    Private Sub reload()
        Controls.Clear()
        InitializeComponent()
        S_ID.Focus()
        fill()
        S_ID.Focus()
    End Sub

    'Fills up the DataGrid on Form Load with all the Queries on this Month(irrescpective of any student)
    Private Sub fill()
        Try
            con.connect()
            Dim query As String = "SELECT student_takes.BILL_ID, student_takes.T_ID, student_takes.S_ID, item.NAME, student_takes.QTY, student_takes.DOR, student_takes.RATE, student_takes.E_ID, student_takes.TAX from student_takes INNER JOIN item ON item.ITEM_ID=student_takes.ITEM_ID  where date_format(Date(DOR),'%d-%m-%Y') like '%" + MonthCalendar1.SelectionRange.Start.Month.ToString + "-" + MonthCalendar1.SelectionRange.Start.Year.ToString + "' order by dor desc"
            'where date_format(Date(DOR),'%d-%m-%Y') like '%" + MonthCalendar1.SelectionRange.Start.Month.ToString + "-" + MonthCalendar1.SelectionRange.Start.Year.ToString + "' ORDER BY DOR DESC"
            Dim comm As New MySqlCommand(query, con.conn)
            Dim dr As MySqlDataReader
            Dim dt As New DataTable
            dr = comm.ExecuteReader
            dt.Load(dr)
            DataGridView1.DataSource = dt
            dr.Close()
        Catch ex As Exception
            MsgBox("Error Occured ! Please try Again ! ")
            MsgBox(ex.Message.ToString)
            Me.Close()
        End Try
        S_ID.Focus()
    End Sub

    'Handles the KeyPress on S_ID tb
    Private Sub S_ID_KeyDown(sender As Object, e As KeyEventArgs) Handles S_ID.KeyDown
        If e.KeyCode = Keys.Enter Then
            If S_ID.Text.Length = 5 Then
                S_ID.Text = "F20" + S_ID.Text + "P"
            ElseIf S_ID.Text.Length = 6 And (S_ID.Text.Contains("H") Or S_ID.Text.Contains("h")) Then
                S_ID.Text = S_ID.Text.Substring(0, 1) + "20" + S_ID.Text.Substring(1, 5) + "P"
            ElseIf S_ID.Text.Length = 6 And (S_ID.Text.Contains("P") Or S_ID.Text.Contains("p")) Then
                S_ID.Text = S_ID.Text.Substring(0, 1) + "20" + S_ID.Text.Substring(1, 5) + "P"
            End If
            Try
                con.connect()
                Dim query As String = "SELECT * FROM STUDENT WHERE S_ID = '" + S_ID.Text.ToString + "'"
                Dim dr As MySqlDataReader
                Dim comm As New MySqlCommand(query, con.conn)
                dr = comm.ExecuteReader
                If dr.Read() Then
                    lblNAME.Text = dr.Item("NAME")
                    lblBHAWAN.Text = dr.Item("BHAWAN")
                    lblROOM.Text = dr.Item("ROOM")
                    lblIDNO.Text = dr.Item("IDNO")
                    calc_Account(S_ID.Text.ToString)
                    fill_appro(S_ID.Text.ToString)
                    S_ID.SelectAll()
                End If
                dr.Close()
            Catch ex As Exception
                MsgBox("Error ! Please Try Again !123")
                MsgBox(ex.Message.ToString)
                reload()
            End Try
        End If
    End Sub

    'Calculates the Total Extras for a Given Student for this Month and shows it on the Proper Label
    Private Sub calc_Account(sid As String)
        Try
            con.connect()
            Dim query As String = "select sum(QTY*(RATE*(1+(TAX/100)))) from student_takes where date_format(Date(DOR),'%d-%m-%Y') like '%" + MonthCalendar1.SelectionRange.Start.Month.ToString + "-" + MonthCalendar1.SelectionRange.Start.Year.ToString + "'" + " and s_id='" + sid.ToString + "'"
            Dim dr As MySqlDataReader
            Dim comm As New MySqlCommand(query, con.conn)
            dr = comm.ExecuteReader
            If dr.Read() And Not IsDBNull(dr.Item(0)) Then
                lblStudent_Account.Text = dr.Item(0)
            ElseIf IsDBNull(dr.Item(0)) Then
                MsgBox("No Record Found for this Student for this Month!!")
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox("Error Occured ! Please Try Again!")
            MsgBox(ex.Message.ToString)
            reload()
        End Try

    End Sub

    'Gets all the Transactions for a Given Student for this month and shows it in the DataGrid
    Private Sub fill_appro(sid As String)
        Try
            con.connect()
            Dim query As String = "SELECT student_takes.BILL_ID, student_takes.T_ID, student_takes.S_ID, item.NAME, student_takes.QTY, student_takes.DOR, student_takes.RATE, student_takes.E_ID, student_takes.TAX from student_takes INNER JOIN item ON item.ITEM_ID=student_takes.ITEM_ID  where date_format(Date(DOR),'%d-%m-%Y') like '%" + MonthCalendar1.SelectionRange.Start.Month.ToString + "-" + MonthCalendar1.SelectionRange.Start.Year.ToString + "' " + "and s_id='" + sid.ToString + "'"
            '"select * from student_takes where date_format(Date(DOR),'%d-%m-%Y') like '%" + MonthCalendar1.SelectionRange.Start.Month.ToString + "-" + MonthCalendar1.SelectionRange.Start.Year.ToString + "'" + "and s_id='" + sid + "'"
            Dim comm As New MySqlCommand(query, con.conn)
            Dim dr1 As MySqlDataReader
            Dim dt As New DataTable
            dr1 = comm.ExecuteReader
            If Not IsDBNull(dr1) Then
                dt.Load(dr1)
                DataGridView1.DataSource = dt
                dr1.Close()
            ElseIf IsDBNull(dr1) Then
                MsgBox("No Record Found for this Student for this Month!!")
            End If
        Catch ex As Exception
            MsgBox("Error ! Please Try again! ")
            MsgBox(ex.Message.ToString)
            reload()
        End Try
    End Sub

    'Recalculates the Extras total and Refills the datagrid when the Date is Changed
    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        If S_ID.Text <> "" Then
            fill_appro(S_ID.Text.ToString)
            calc_Account(S_ID.Text.ToString)
        Else
            fill()
        End If
    End Sub
End Class