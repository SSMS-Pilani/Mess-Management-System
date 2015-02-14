Imports MySql.Data.MySqlClient

Public Class formMonthly
    Dim con As New connection 'Mysql Connection used thru the Form
    Dim visiblilty As Integer = 0 'Bool for the Visibility of Change/Add Price
    Dim numsun, numsat, numfri, numthurs, numwed, numtues, nummon As Integer



    'Various Bools for Setting the Items
    Dim item0 As Integer = 0
    Dim item1 As Integer = 0
    Dim item2 As Integer = 0
    Dim item3 As Integer = 0
    Dim item4 As Integer = 0
    Dim item5 As Integer = 0

    Dim sunday As Integer = 0
    Dim monday As Integer = 0
    Dim saturday As Integer = 0
    Dim wednesday As Integer = 0
    Dim thursday As Integer = 0
    Dim friday As Integer = 0

    'Handles On lOading the Form
    Private Sub formMonthly_Load(sender As Object, e As EventArgs) Handles Me.Load
        S_ID.Focus()
        Me.KeyPreview = True
        calc_no_of_days()
        calc_total()
    End Sub

    Private Sub calc_total()
        Try

            Dim query_1 As String = "Select count(S_ID) from monthly_details where month_year like '" + Today.ToString("yyyy-MM") + "%' and item_1 != 0"
            Dim query_2 As String = "Select count(S_ID) from monthly_details where month_year like '" + Today.ToString("yyyy-MM") + "%' and item_2 != 0"
            Dim query_3 As String = "Select count(S_ID) from monthly_details where month_year like '" + Today.ToString("yyyy-MM") + "%' and item_3 != 0"
            Dim query_4 As String = "Select count(S_ID) from monthly_details where month_year like '" + Today.ToString("yyyy-MM") + "%' and item_4 != 0"
            Dim comm_1 As New MySqlCommand(query_1, con.conn)
            Dim comm_2 As New MySqlCommand(query_2, con.conn)
            Dim comm_3 As New MySqlCommand(query_3, con.conn)
            Dim comm_4 As New MySqlCommand(query_4, con.conn)

            Dim item_1_count, item_2_count, item_3_count, item_4_count As Integer

            con.connect()
            item_1_count = comm_1.ExecuteScalar
            item_2_count = comm_2.ExecuteScalar
            item_3_count = comm_3.ExecuteScalar
            item_4_count = comm_4.ExecuteScalar

            Label12.Text = Label12.Text + " " + item_1_count.ToString
            Label13.Text = Label13.Text + " " + item_2_count.ToString
            Label15.Text = Label15.Text + " " + item_3_count.ToString
            Label14.Text = Label14.Text + " " + item_4_count.ToString

        Catch ex As Exception
            MsgBox("Error Occured! Please try again!!")
            MsgBox(ex.Message.ToString)
        End Try

    End Sub


    'Handles Keypresses on the FOrm
    Private Sub formMonthly_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        ElseIf e.KeyCode = Keys.F5 Then
            reload()
        End If
    End Sub

    'Reloads the FOrm
    Private Sub Clear_Click(sender As Object, e As EventArgs)
        reload()
    End Sub

    'Changes the Visiblity of Change/ Add Price Group Box
    Private Sub Change_Price_Click(sender As Object, e As EventArgs)
        GroupBox1.Visible = True
        tbItemId.Focus()
    End Sub

    'Handles keypress on tbItem_ID
    Private Sub tbItem_ID_KeyDown(sender As Object, e As KeyEventArgs) Handles tbItemId.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                con.connect()
                Dim query As String = "SELECT * FROM MONTHLY_MASTER WHERE MONTH_YEAR LIKE '" + Format(Today.Date, "yyyy-MM").ToString + "-00'"
                Dim comm As New MySqlCommand(query, con.conn)
                Dim dr As MySqlDataReader
                dr = comm.ExecuteReader
                If dr.Read Then
                    If CInt(tbItemId.Text) <> 11 And CInt(tbItemId.Text) <> 12 And CInt(tbItemId.Text) < 6 Then
                        TextBox5.Text = dr.Item(CInt(tbItemId.Text) + 3)
                    ElseIf CInt(tbItemId.Text) = 11 Then
                        TextBox5.Text = dr.Item(1)
                    ElseIf CInt(tbItemId.Text) = 12 Then
                        TextBox5.Text = dr.Item(2)
                    ElseIf CInt(tbItemId.Text) > 12 Then
                        TextBox5.Text = dr.Item(CInt(tbItemId.Text) - 4)
                    End If
                    proceedAndEnable(tbItemId, tbNewPrice)
                ElseIf Not IsNumeric(tbItemId.Text) Then
                    MsgBox("Error! Enter Proper Monthly Item Number (0-9) or (11-20)")
                    tbItemId.Text = ""
                    tbItemId.Focus()
                ElseIf (IsNumeric(tbItemId.Text) And ((CInt(tbItemId.Text) >= 0) And (CInt(tbItemId.Text) <= 20))) Then
                    MsgBox("The Details for this Month have not been Updated ! Please update it now!!")
                    TextBox5.Text = ""
                    proceedAndEnable(tbItemId, tbNewPrice)
                End If
            Catch ex As Exception
                tbItemId.Text = ""
                MsgBox("Error Occured! Please Try Again!!!")
                MsgBox(ex.Message.ToString)
            End Try
        End If
    End Sub

    'Refreshes the Form
    Public Sub reload()
        'Controls.Clear()
        'InitializeComponent()
        'S_ID.Focus()
        'calc_total()
        Dim newform As New formMonthly
        Me.Hide()
        newform.Show()
        Me.Close()
    End Sub

    'Handles Key Press on TbNewPrice
    Private Sub tbNewPrice_KeyDown(sender As Object, e As KeyEventArgs) Handles tbNewPrice.KeyDown
        If e.KeyCode = Keys.Enter Then
            If tbNewPrice.Text <> "" And IsNumeric(tbNewPrice.Text) Then
                Confirm_Change.Focus()
            Else
                MsgBox("Enter Proper Value for New Price")
            End If
        End If
    End Sub

    'Confirms the New Prices.
    Private Sub Confirm_Change_Click(sender As Object, e As EventArgs) Handles Confirm_Change.Click
        Try
            con.connect()
            Dim query As String = 0
            If CInt(tbItemId.Text) <> 11 And CInt(tbItemId.Text) <> 12 And CInt(tbItemId.Text) < 7 Then
                query = "INSERT INTO MONTHLY_MASTER(ITEM_" + tbItemId.Text + ", MONTH_YEAR) VALUES('" + tbNewPrice.Text + "','" + Format(Today.Date, "yyyy-MM").ToString + "-00') ON DUPLICATE KEY UPDATE ITEM_" + tbItemId.Text + " = '" + tbNewPrice.Text.ToString + "'"
            ElseIf CInt(tbItemId.Text) = 11 Then
                query = "INSERT INTO MONTHLY_MASTER(MEAL_AMOUNT, MONTH_YEAR) VALUES('" + tbNewPrice.Text + "','" + Format(Today.Date, "yyyy-MM").ToString + "-00') ON DUPLICATE KEY UPDATE MEAL_AMOUNT = '" + tbNewPrice.Text.ToString + "'"
            ElseIf CInt(tbItemId.Text) = 12 Then
                query = "INSERT INTO MONTHLY_MASTER(REBATE_AMOUNT, MONTH_YEAR) VALUES('" + tbNewPrice.Text + "','" + Format(Today.Date, "yyyy-MM").ToString + "-00') ON DUPLICATE KEY UPDATE REBATE_AMOUNT = '" + tbNewPrice.Text.ToString + "'"
            ElseIf CInt(tbItemId.Text) = 13 Then
                query = "INSERT INTO MONTHLY_MASTER(SUNDAY, MONTH_YEAR) VALUES('" + tbNewPrice.Text + "','" + Format(Today.Date, "yyyy-MM").ToString + "-00') ON DUPLICATE KEY UPDATE SUNDAY = '" + tbNewPrice.Text.ToString + "'"
            ElseIf CInt(tbItemId.Text) = 14 Then
                query = "INSERT INTO MONTHLY_MASTER(MONDAY, MONTH_YEAR) VALUES('" + tbNewPrice.Text + "','" + Format(Today.Date, "yyyy-MM").ToString + "-00') ON DUPLICATE KEY UPDATE MONDAY = '" + tbNewPrice.Text.ToString + "'"
            ElseIf CInt(tbItemId.Text) = 15 Then
                query = "INSERT INTO MONTHLY_MASTER(WEDNESDAY, MONTH_YEAR) VALUES('" + tbNewPrice.Text + "','" + Format(Today.Date, "yyyy-MM").ToString + "-00') ON DUPLICATE KEY UPDATE WEDNESDAY = '" + tbNewPrice.Text.ToString + "'"
            ElseIf CInt(tbItemId.Text) = 16 Then
                query = "INSERT INTO MONTHLY_MASTER(THURSDAY, MONTH_YEAR) VALUES('" + tbNewPrice.Text + "','" + Format(Today.Date, "yyyy-MM").ToString + "-00') ON DUPLICATE KEY UPDATE THURSDAY = '" + tbNewPrice.Text.ToString + "'"
            ElseIf CInt(tbItemId.Text) = 17 Then
                query = "INSERT INTO MONTHLY_MASTER(FRIDAY, MONTH_YEAR) VALUES('" + tbNewPrice.Text + "','" + Format(Today.Date, "yyyy-MM").ToString + "-00') ON DUPLICATE KEY UPDATE FRIDAY = '" + tbNewPrice.Text.ToString + "'"
            ElseIf CInt(tbItemId.Text) = 18 Then
                query = "INSERT INTO MONTHLY_MASTER(SATURDAY, MONTH_YEAR) VALUES('" + tbNewPrice.Text + "','" + Format(Today.Date, "yyyy-MM").ToString + "-00') ON DUPLICATE KEY UPDATE SATURDAY = '" + tbNewPrice.Text.ToString + "'"
            End If

            Dim comm As New MySqlCommand(query, con.conn)
            comm.ExecuteNonQuery()
            MsgBox("Price Changed!!")
            reload()
        Catch ex As Exception
            MsgBox("Error Occured Please Try Again!!")
            MsgBox(ex.Message.ToString)
            tbItemId.Text = ""
            tbItemId.Focus()
            tbNewPrice.Text = ""
            TextBox5.Text = ""
        End Try
    End Sub

    'Confirms the Details and Runs the INSERT Query on Monthly_Details
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Confirm_Details.Click
        'System.Diagnostics.Process.Start("C:\test.bat")    
        Dim days_in_month = System.DateTime.DaysInMonth(DateTimePicker1.Value.Year, DateTimePicker1.Value.Month)
        Try
            con.connect()
            item0 = item0 * days_in_month
            item1 = item1 * days_in_month
            item2 = item2 * days_in_month
            item3 = item3 * days_in_month
            item4 = item4 * days_in_month
            item5 = item5 * days_in_month

            Dim query As String = "INSERT INTO MONTHLY_DETAILS(S_ID, MONTH_YEAR, ITEM_0, ITEM_1, ITEM_2, ITEM_3, ITEM_4, ITEM_5, SUNDAY, MONDAY, WEDNESDAY,THURSDAY, FRIDAY, SATURDAY) VALUES('" + S_ID.Text.ToString + "', '" + DateTimePicker1.Value.Year.ToString + "-" + DateTimePicker1.Value.Month.ToString + "-00','" + item0.ToString + "','" + item1.ToString + "','" + item2.ToString + "','" + item3.ToString + "','" + item4.ToString + "','" + item5.ToString + "','" + (sunday * numsun).ToString + "','" + (monday * nummon).ToString + "','" + (wednesday * numwed).ToString + "','" + (thursday * numthurs).ToString + "','" + (friday * numfri).ToString + "','" + (saturday * numsat).ToString + "'" + ") ON DUPLICATE KEY UPDATE item_0 = '" + item0.ToString + "', item_1 = '" + item1.ToString + "',item_2 = '" + item2.ToString + "',item_3 = '" + item3.ToString + "',item_4 = '" + item4.ToString + "',item_5 = '" + item5.ToString + "',sunday = '" + (sunday * numsun).ToString + "',monday = '" + (monday * nummon).ToString + "',wednesday = '" + (wednesday * numwed).ToString + "',thursday = '" + (thursday * numthurs).ToString + "',friday = '" + (friday * numfri).ToString + "',saturday = '" + (saturday * numsat).ToString + "'"
            Dim comm As New MySqlCommand(query, con.conn)
            comm.ExecuteNonQuery()

            MsgBox("Monthly Details added Successfully!")
            reload()
        Catch ex As Exception
            MsgBox("Error Occured Please Try Again!!")
            MsgBox(ex.Message.ToString)
            tbItemId.Text = ""
            tbItemId.Focus()
            tbNewPrice.Text = ""
            TextBox5.Text = ""
        End Try
    End Sub

    'Changes the Visibility of Change/Add price when clicked
    Private Sub change_visiblity_Click(sender As Object, e As EventArgs) Handles change_visiblity.Click
        If visiblilty = 0 Then
            visiblilty = 1
            GroupBox1.Visible = True
            tbItemId.Focus()
        Else
            'GroupBox1.Visible = False
            S_ID.Focus()
            visiblilty = 0
        End If

    End Sub

    'Handles KeypResses on TbS_ID
    Private Sub S_ID_KeyPress(sender As Object, e As KeyEventArgs) Handles S_ID.KeyDown
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
                Dim query As String = "SELECT * FROM Student where S_ID = '" + S_ID.Text + "'"
                Dim comm As New MySqlCommand(query, con.conn)
                Dim dr As MySqlDataReader
                dr = comm.ExecuteReader
                If dr.Read Then
                    sname.Text = dr.Item(2)
                    room.Text = "     " + dr.Item(4).ToString + "  " + dr.Item(3).ToString

                Else
                    MsgBox("Error! Enter Proper S_ID")
                    S_ID.Text = ""
                    S_ID.Focus()
                End If
            Catch ex As Exception
                tbItemId.Text = ""
                MsgBox("Error Occured! Please Try Again!")
                MsgBox(ex.Message.ToString)
            End Try

            Try
                con.connect()
                Dim query As String = "SELECT * FROM MONTHLY_DETAILS where S_ID = '" + S_ID.Text + "' and MONTH_YEAR = '" + DateTimePicker1.Value.Year.ToString + "-" + DateTimePicker1.Value.Month.ToString + "-00'"
                Dim comm As New MySqlCommand(query, con.conn)
                Dim dr As MySqlDataReader
                dr = comm.ExecuteReader
                If dr.Read Then
                    If Not dr.Item(3) = 0 Then
                        item_0.BackColor = Color.Orange
                        item0 = 1
                    End If
                    If Not dr.Item(4) = 0 Then
                        item_1.BackColor = Color.Orange
                        item1 = 1
                    End If
                    If Not dr.Item(5) = 0 Then
                        item_2.BackColor = Color.Orange
                        item2 = 1
                    End If
                    If Not dr.Item(6) = 0 Then
                        item_3.BackColor = Color.Orange
                        item3 = 1
                    End If
                    If Not dr.Item(7) = 0 Then
                        item_4.BackColor = Color.Orange
                        item4 = 1
                    End If
                    If Not dr.Item(9) = 0 Then
                        SundayButton.BackColor = Color.Orange
                        sunday = 1
                    End If
                    If Not dr.Item(10) = 0 Then
                        MondayButton.BackColor = Color.Orange
                        monday = 1
                    End If
                    If Not dr.Item(11) = 0 Then
                        WednesdayButton.BackColor = Color.Orange
                        wednesday = 1
                    End If
                    If Not dr.Item(12) = 0 Then
                        ThursdayButton.BackColor = Color.Orange
                        thursday = 1
                    End If
                    If Not dr.Item(13) = 0 Then
                        FridayButton.BackColor = Color.Orange
                        friday = 1
                    End If
                    If Not dr.Item(14) = 0 Then
                        SaturdayButton.BackColor = Color.Orange
                        saturday = 1
                    End If
                    If Not dr.Item(8) = 0 Then
                        item_5.BackColor = Color.Orange
                        item5 = 1
                    End If

                Else
                    dr.Close()
                    Dim query1 As String = "SELECT * FROM Student where S_ID = '" + S_ID.Text + "'"
                    Dim comm1 As New MySqlCommand(query1, con.conn)
                    Dim dr1 As MySqlDataReader
                    dr1 = comm1.ExecuteReader
                    If dr1.Read Then
                        item_0.Focus()
                    Else
                        MsgBox("Enter Proper S_ID!!")
                        S_ID.Text = ""
                        S_ID.Focus()
                    End If
                End If
                item_0.Focus()
            Catch ex As Exception
                tbItemId.Text = ""
                MsgBox("Error Occured! Please Try Again!")
                MsgBox(ex.Message.ToString)
            End Try

        End If
    End Sub


    'Functions Below change the Boolean Appropirately when the corresponding button is clicked


    Private Sub item_0_Click(sender As Object, e As EventArgs) Handles item_0.Click
        If item0 = 0 Then
            item0 = 1
            item_0.BackColor = Color.Orange
        Else
            item0 = 0
            item_0.BackColor = Color.Red
        End If


    End Sub

    Private Sub item_1_Click(sender As Object, e As EventArgs) Handles item_1.Click
        If item1 = 0 Then
            item1 = 1
            item_1.BackColor = Color.Orange
        Else
            item1 = 0
            item_1.BackColor = Color.Red
        End If
    End Sub

    Private Sub item_2_Click(sender As Object, e As EventArgs) Handles item_2.Click
        If item2 = 0 Then
            item2 = 1
            item_2.BackColor = Color.Orange
        Else
            item2 = 0
            item_2.BackColor = Color.Red
        End If
    End Sub

    Private Sub item_3_Click(sender As Object, e As EventArgs) Handles item_3.Click
        If item3 = 0 Then
            item3 = 1
            item_3.BackColor = Color.Orange
        Else
            item3 = 0
            item_3.BackColor = Color.Red
        End If
    End Sub

    Private Sub item_4_Click(sender As Object, e As EventArgs) Handles item_4.Click
        If item4 = 0 Then
            item4 = 1
            item_4.BackColor = Color.Orange
        Else
            item4 = 0
            item_4.BackColor = Color.Red
        End If
    End Sub

    Private Sub item_5_Click(sender As Object, e As EventArgs) Handles item_5.Click
        If item5 = 0 Then
            item5 = 1
            item_5.BackColor = Color.Orange
        Else
            item5 = 0
            item_5.BackColor = Color.Red
        End If
    End Sub



    
    Private Sub calc_no_of_days()
        'Dim month As Integer = 8
        'Dim year As Integer = 2014

        'Calculate the Start and end of the month
        Dim current As New DateTime(DateTimePicker1.Value.Year, DateTimePicker1.Value.Month, 1)
        Dim ending As New DateTime(DateTimePicker1.Value.Year, DateTimePicker1.Value.Month, 1)
        ending = ending.AddMonths(1)

        Dim dateDiff As Integer = (ending.Date - current.Date).Days

        Dim firstDay As DayOfWeek = (current).DayOfWeek

        Dim secondDay As DayOfWeek = (current.AddDays(1)).DayOfWeek

        Dim thirdDay As DayOfWeek = (current.AddDays(2)).DayOfWeek

        'Dim numsun, numsat, numfri, numthurs, numwed, numtues, nummon As Integer
        numfri = 4
        nummon = 4
        numsat = 4
        numsun = 4
        numthurs = 4
        numtues = 4
        numwed = 4

        Dim days_in_month = System.DateTime.DaysInMonth(DateTimePicker1.Value.Year, DateTimePicker1.Value.Month)

        If days_in_month = 31 Then
            Select Case firstDay
                Case DayOfWeek.Sunday
                    nummon = nummon + 1
                    numtues = numtues + 1
                    numsun = numsun + 1
                Case DayOfWeek.Saturday
                    nummon = nummon + 1
                    numsat = numsat + 1
                    numsun = numsun + 1
                Case DayOfWeek.Friday
                    numfri = numfri + 1
                    numsat = numsat + 1
                    numsun = numsun + 1
                Case DayOfWeek.Thursday
                    numfri = numfri + 1
                    numsat = numsat + 1
                    numthurs = numthurs + 1
                Case DayOfWeek.Wednesday
                    numthurs = numthurs + 1
                    numfri = numfri + 1
                    numwed = numwed + 1
                Case DayOfWeek.Tuesday
                    numthurs = numthurs + 1
                    numtues = numtues + 1
                    numwed = numwed + 1
                Case DayOfWeek.Monday
                    nummon = nummon + 1
                    numtues = numtues + 1
                    numwed = numwed + 1
            End Select
        End If

        If days_in_month = 30 Then
            Select Case firstDay
                Case DayOfWeek.Sunday
                    nummon = nummon + 1
                    numsun = numsun + 1
                Case DayOfWeek.Saturday
                    numsat = numsat + 1
                    numsun = numsun + 1
                Case DayOfWeek.Friday
                    numfri = numfri + 1
                    numsat = numsat + 1
                Case DayOfWeek.Thursday
                    numfri = numfri + 1
                    numthurs = numthurs + 1
                Case DayOfWeek.Wednesday
                    numthurs = numthurs + 1
                    numwed = numwed + 1
                Case DayOfWeek.Tuesday
                    numtues = numtues + 1
                    numwed = numwed + 1
                Case DayOfWeek.Monday
                    nummon = nummon + 1
                    numtues = numtues + 1
            End Select
        End If


        If days_in_month = 29 Then
            Select Case firstDay
                Case DayOfWeek.Sunday
                    numsun = numsun + 1
                Case DayOfWeek.Saturday
                    numsat = numsat + 1
                Case DayOfWeek.Friday
                    numfri = numfri + 1
                Case DayOfWeek.Thursday
                    numthurs = numthurs + 1
                Case DayOfWeek.Wednesday
                    numwed = numwed + 1
                Case DayOfWeek.Tuesday
                    numtues = numtues + 1
                Case DayOfWeek.Monday
                    nummon = nummon + 1
            End Select
        End If


        'MsgBox(nummon)
        'MsgBox(numtues)
        'MsgBox(numwed)
        'MsgBox(numthurs)
        'MsgBox(numfri)
        'MsgBox(numsat)
        'MsgBox(numsun)

    End Sub

    Private Sub SundayButton_Click(sender As Object, e As EventArgs) Handles SundayButton.Click
        If sunday = 0 Then
            sunday = 1
            SundayButton.BackColor = Color.Orange
        Else
            sunday = 0
            SundayButton.BackColor = Color.Red
        End If
    End Sub


    Private Sub MondayButton_Click(sender As Object, e As EventArgs) Handles MondayButton.Click
        If monday = 0 Then
            monday = 1
            MondayButton.BackColor = Color.Orange
        Else
            monday = 0
            MondayButton.BackColor = Color.Red
        End If
    End Sub


    Private Sub WednesdayButton_Click(sender As Object, e As EventArgs) Handles WednesdayButton.Click
        If wednesday = 0 Then
            wednesday = 1
            WednesdayButton.BackColor = Color.Orange
        Else
            wednesday = 0
            WednesdayButton.BackColor = Color.Red
        End If
    End Sub


    Private Sub ThursdayButton_Click(sender As Object, e As EventArgs) Handles ThursdayButton.Click
        If thursday = 0 Then
            thursday = 1
            ThursdayButton.BackColor = Color.Orange
        Else
            thursday = 0
            ThursdayButton.BackColor = Color.Red
        End If
    End Sub


    Private Sub FridayButton_Click(sender As Object, e As EventArgs) Handles FridayButton.Click
        If friday = 0 Then
            friday = 1
            FridayButton.BackColor = Color.Orange
        Else
            friday = 0
            FridayButton.BackColor = Color.Red
        End If
    End Sub

    Private Sub SaturdayButton_Click(sender As Object, e As EventArgs) Handles SaturdayButton.Click
        If saturday = 0 Then
            saturday = 1
            SaturdayButton.BackColor = Color.Orange
        Else
            saturday = 0
            SaturdayButton.BackColor = Color.Red
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        formViewMonthlyItems.Show()
    End Sub
End Class