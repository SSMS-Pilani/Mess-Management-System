Imports MySql.Data.MySqlClient
Public Class formRebate
    Dim con As New connection 'Mysql Connection used through the Form

    'Handles Various KeyPresses
    Private Sub formRebate_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        ElseIf e.KeyCode = Keys.F5 Then
            reload()
        End If
    End Sub

    'On Form Load
    Private Sub formRebate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        S_ID.Focus()
        fill()
    End Sub


    Private Sub fill()
        Try
            con.connect()
            Dim query As String = "SELECT monthly_details.S_ID, student.NAME ,monthly_details.MEALS_NOT_TAKEN, " _
                                  + "student.ROOM, student.BHAWAN from monthly_details INNER JOIN student " _
                                  + "ON student.s_Id = monthly_details.S_ID where MONTH_YEAR LIKE '" _
                                  + MonthCalendar1.SelectionRange.Start.Date.ToString("yyyy-MM") _
                                  + "%' ORDER BY student.BHAWAN,student.ROOM"
            Dim DR As MySqlDataReader
            Dim comm As New MySqlCommand(query, con.conn)
            DR = comm.ExecuteReader()
            Dim DT As New DataTable
            DT.Load(DR)
            DataGridView1.DataSource = DT
            DR.Close()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
            reload()
        End Try

    End Sub


    'Handles Enter Pressed on S_ID tb
    Private Sub S_ID_KeyDown(sender As Object, e As KeyEventArgs) Handles S_ID.KeyDown
        If e.KeyCode = Keys.Enter Then
            If S_ID.Text = "" Then
                MsgBox("Enter Proper S_ID")
                S_ID.Focus()
            Else
                If S_ID.Text.Length = 5 Then
                    S_ID.Text = "F20" + S_ID.Text + "P"
                ElseIf S_ID.Text.Length = 6 And (S_ID.Text.Contains("H") Or S_ID.Text.Contains("h")) Then
                    S_ID.Text = S_ID.Text.Substring(0, 1) + "20" + S_ID.Text.Substring(1, 5) + "P"
                ElseIf S_ID.Text.Length = 6 And (S_ID.Text.Contains("P") Or S_ID.Text.Contains("p")) Then
                    S_ID.Text = S_ID.Text.Substring(0, 1) + "20" + S_ID.Text.Substring(1, 5) + "P"
                End If

	         Try
                    con.connect()
                    Dim query As String = "Select NAME from student where s_id = '" + S_ID.Text.ToString + "'"
                    Dim comm As New MySqlCommand(query, con.conn)
                    Dim dr As MySqlDataReader = comm.ExecuteReader()
                    If dr.Read() Then
                        tbName.Text = dr.Item(0)
                        proceedAndEnable(S_ID, tb_Meals_not_taken)
                    Else
                        MsgBox("Cannot Find Student ID!! Please Enter Proper S_ID !!")
                        S_ID.Text = ""
                    End If
                Catch ex As Exception
                    MsgBox("Error Occured ! Please Try Again!")
                    MsgBox(ex.Message.ToString)
                End Try
            End If
        End If
    End Sub



    'Handles Confirm Clicked, Inserts query into Rebate Table in DB
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Confirm.Click
	IF tb_Meals_not_taken.Text > My.Settings.Rebate_Min_days Then
            
            Dim test_if_exists_query As String
            test_if_exists_query = "SELECT * FROM MONTHLY_DETAILS WHERE S_ID = '" + S_ID.Text.ToString _
                + "' AND MONTH_YEAR = '" + Format(Today.Date, "yyyy-MM").ToString + "-00'"
            Dim test_comm As New MySqlCommand(test_if_exists_query, con.conn)
            con.connect()
            Dim test_dr As MySqlDataReader = test_comm.ExecuteReader()
            Dim orig_rebate As Integer = 0


            ' If Student rebate for the month is already added, add new rebate to previous
            ' and if Not Insert a new row for the student
            If test_dr.Read() Then
                orig_rebate = test_dr.Item(2)
                Try
                    test_dr.Close()
                    Dim query1 As String = "UPDATE MONTHLY_DETAILS SET MEALS_NOT_TAKEN = '" _
                        + (orig_rebate + CInt(tb_Meals_not_taken.Text)).ToString + "' WHERE S_ID = '" _
                        + S_ID.Text.ToString + "' AND " _
                        + "MONTH_YEAR = '" + Format(Today.Date, "yyyy-MM").ToString + "-00'"
                    Dim comm As New MySqlCommand(query1, con.conn)
                    comm.ExecuteNonQuery()
                    MsgBox("Rebate Added/ Updated")
                    reload()
                Catch ex As Exception
                    MsgBox("Error Occured! Please Try Again!")
                    MsgBox(ex.Message.ToString)
                End Try
            Else
                Try
                    test_dr.Close()
                    test_dr.Dispose()
                    con.connect()
                    Dim query As String = "INSERT INTO MONTHLY_DETAILS(S_ID,MONTH_YEAR,MEALS_NOT_TAKEN) VALUES('" _
                                          + S_ID.Text.ToString + "','" + Format(Today.Date, "yyyy-MM") + "-00','" _
                                          + tb_Meals_not_taken.Text + "') ON DUPLICATE KEY UPDATE MEALS_NOT_TAKEN = '" _
                                          + tb_Meals_not_taken.Text + "'"
                    Dim comm As New MySqlCommand(query, con.conn)
                    comm.ExecuteNonQuery()
                    MsgBox("Rebate Added")
                    reload()
                Catch ex As Exception
                    MsgBox("Error Occured! Please Try Again!")
                    MsgBox(ex.Message.ToString)
                End Try
            End If

        Else

            MsgBox("The Minimum Period for Rebates is 3 Days!! So, Data Not Inserted !!")
            reload()
        End If
    End Sub

    'Handles Cancel Clicked
    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    'Refreshes the Form
    Private Sub reload()
        Controls.Clear()
        InitializeComponent()
        S_ID.Focus()
        fill()
    End Sub


    Private Sub tb_Meals_not_taken_KeyDown(sender As Object, e As KeyEventArgs) Handles tb_Meals_not_taken.KeyDown
        If e.KeyCode = Keys.Enter Then
            If tb_Meals_not_taken.Text = "" Or Not IsNumeric(tb_Meals_not_taken.Text) Then
                MsgBox("Enter Proper No. of Days !!")
                tb_Meals_not_taken.Text = ""
            Else
                tb_Meals_not_taken.ReadOnly = True
                Confirm.Focus()
            End If
        End If
    End Sub
End Class
