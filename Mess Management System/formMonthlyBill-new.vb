'Imports Microsoft.Office.Interop.Excel

Imports Microsoft.VisualBasic
Imports MySql.Data.MySqlClient
Public Class formMonthlyBill
    Dim con1 As New connection 'Mysql Connection 1 used thorugh the Form
    Dim con2, con3, con4 As New connection 'Mysql Connection 2 used thorugh the Form


    'All the Excel Stuff
    Dim oExcel As Object
    Dim oBook As Object
    Dim oSheet As Object = ""
    Dim filename As Object

    Dim total As Integer 'For No. Of Students To Be Billed, Used in Progress Bar

    Dim row As Integer = 0 'For Current Row 


    'Calculates No. Of Students To Be Billed, Used in Progress Bar
    Private Sub cal_total()
        Try
            con1.connect()
            Dim query6 As String = "Select count(*) from student"
            Dim comm4 As New MySqlCommand(query6, con1.conn)
            Dim dr6 As MySqlDataReader = comm4.ExecuteReader
            dr6.Read()
            total = dr6.Item(0) + 2

            con1.disconnect()
        Catch ex As Exception
            MsgBox("Error Occured! Please Try Again")
            MsgBox(ex.Message.ToString)
        End Try
    End Sub


    'Generates the Monthly Bill Excel File 
    Private Sub generate_all() 'Handles BackgroundWorker1.DoWork 'Handles Gen_Excel.Click

        Try
            Dim month, year As String
            month = InputBox("Enter Month Name : ")
            Year = InputBox("Enter Year : ")
            con1.connect()
            Dim comm1 As New MySqlCommand("SELECT * FROM STUDENT ORDER BY BHAWAN,ROOM ", con1.conn)

            filename = "D:" + "\" + My.Settings.messName.ToString + "_" + month + "_" + year + ".xlsx"
            'Me.Text = filename

            oExcel = CreateObject("Excel.Application")
            oBook = oExcel.Workbooks.Add
            oSheet = oBook.worksheets.add
            oSheet.range("A1").Value = "Id No."
            oSheet.RANGE("B1").VALUE = "Name"
            oSheet.RANGE("C1").VALUE = "Room No."
            oSheet.RANGE("D1").VALUE = "Bhawan"
            oSheet.RANGE("E1").VALUE = "No of days"
            oSheet.RANGE("F1").VALUE = "Basic per day"
            oSheet.RANGE("G1").VALUE = "Monthly Items Total"
            oSheet.RANGE("H1").VALUE = "Extras Total"
            oSheet.RANGE("I1").VALUE = "Rebate Days"
            oSheet.RANGE("J1").VALUE = "Rebate Total"
            oSheet.RANGE("K1").VALUE = "Special Meal"
            oSheet.RANGE("L1").VALUE = "ANC Bill"
            oSheet.RANGE("M1").VALUE = "Total Payable"


            Dim iter As Int16
            iter = 1
            'con1.disconnect()
            con1.connect()
            'con2.disconnect()
            con2.connect()
            'con2.disconnect()
            con3.connect()
            'con4.disconnect()
            con4.connect()


            Dim dr1, dr2, dr3 As MySqlDataReader
            Dim tm, tmr, item0_amt, item1_amt, item2_amt, item3_amt, item4_amt, item5_amt, rebate_days As Integer
            Dim mthly, xtra, nv As Double
            Dim sun_amt, mon_amt, wed_amt, thurs_amt, fri_amt, sat_amt As Integer
            Dim rebate_amount, mess_daily_amount, item0, item1, item2, item3, item4, item5 As Double
            Dim sun, mon, wed, thurs, fri, sat As Integer

            row = 2

            dr1 = comm1.ExecuteReader()


            Dim comm2 As New MySqlCommand("SELECT * from MONTHLY_MASTER where MONTH_YEAR like '" + MonthCalendar1.SelectionRange.Start.Year.ToString + "-" + MonthCalendar1.SelectionRange.Start.Month.ToString("00") + "%'", con2.conn)

            dr2 = comm2.ExecuteReader()

            If dr2.Read() Then
                rebate_amount = dr2.Item(2)
                mess_daily_amount = dr2.Item(1)
                item0 = dr2.Item(3)
                item1 = dr2.Item(4)
                item2 = dr2.Item(5)
                item3 = dr2.Item(6)
                item4 = dr2.Item(7)
                item5 = dr2.Item(8)
                sun = dr2.Item(9)
                mon = dr2.Item(10)
                wed = dr2.Item(11)
                thurs = dr2.Item(12)
                fri = dr2.Item(13)
                sat = dr2.Item(14)

            Else
                rebate_amount = 0
                mess_daily_amount = 0
                item0 = 0
                item1 = 0
                item2 = 0
                item3 = 0
                item4 = 0
                item5 = 0
                sun = 0
                mon = 0
                wed = 0
                thurs = 0
                fri = 0
                sat = 0

            End If

            If dr1.HasRows Then
                While dr1.Read()

                    Dim idno As String = dr1.Item("IDNO").ToString
                    Dim name As String = dr1.Item("NAME").ToString
                    Dim room As String = dr1.Item("ROOM").ToString
                    Dim bhawan As String = dr1.Item("BHAWAN").ToString

                    Dim comm3 As New MySqlCommand("SELECT * from MONTHLY_DETAILS where s_id = '" + dr1.Item(0).ToString + "' and MONTH_YEAR = '" + MonthCalendar1.SelectionRange.Start.Year.ToString + "-" + MonthCalendar1.SelectionRange.Start.Month.ToString("00") + "-00'", con3.conn)

                    dr3 = comm3.ExecuteReader

                    If dr3.Read() Then
                        rebate_days = dr3.Item(2)
                        item0_amt = dr3.Item(3)
                        item1_amt = dr3.Item(4)
                        item2_amt = dr3.Item(5)
                        item3_amt = dr3.Item(6)
                        item4_amt = dr3.Item(7)
                        item5_amt = dr3.Item(8)
                        sun_amt = dr3.Item(9)
                        mon_amt = dr3.Item(10)
                        wed_amt = dr3.Item(11)
                        thurs_amt = dr3.Item(12)
                        fri_amt = dr3.Item(13)
                        sat_amt = dr3.Item(14)
                        dr3.Close()
                    Else
                        item0_amt = 0
                        rebate_days = 0
                        item1_amt = 0
                        item2_amt = 0
                        item3_amt = 0
                        item4_amt = 0
                        item5_amt = 0
                        sun_amt = 0
                        mon_amt = 0
                        wed_amt = 0
                        thurs_amt = 0
                        fri_amt = 0
                        sat_amt = 0
                        dr3.Close()
                    End If

                    mthly = CInt((item0_amt * item0) + (item1_amt * item1) + (item2_amt * item2) + (item3_amt * item3) + (item4_amt * item4) + (item5_amt * item5) + (sun * sun_amt) + (mon * mon_amt) + (wed * wed_amt) + (thurs * thurs_amt) + (fri * fri_amt) + (sat * sat_amt))
                    Dim comm4 As New MySqlCommand("SELECT coalesce(SUM(qty*(rate)), 0) AS tot FROM student_takes WHERE s_id ='" + dr1.Item(0).ToString + "' AND (dor >= '" + DateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss") + "' and dor <= '" + DateTimePicker2.Value.ToString("yyyy-MM-dd HH:mm:ss") + "')", con4.conn)

                    xtra = comm4.ExecuteScalar()
                    If IsDBNull(xtra) Then
                        xtra = 0
                    End If

                    xtra = xtra + nv
                    tmr = 0
                    tm = 0

                    If dr1.Item(0) = My.Settings.Cash_ID Then
                        mthly = 0
                        rebate_days = 0
                    End If

                    oSheet.RANGE("A" + row.ToString).Value = idno
                    oSheet.RANGE("B" + row.ToString).VALUE = name
                    oSheet.RANGE("C" + row.ToString).VALUE = room
                    oSheet.RANGE("D" + row.ToString).VALUE = bhawan
                    oSheet.RANGE("E" + row.ToString).VALUE = System.DateTime.DaysInMonth(MonthCalendar1.SelectionRange.Start.Year, MonthCalendar1.SelectionRange.Start.Month)
                    oSheet.RANGE("L" + row.ToString).VALUE = mess_daily_amount.ToString
                    oSheet.RANGE("G" + row.ToString).VALUE = mthly.ToString

                    oSheet.RANGE("I" + row.ToString).VALUE = rebate_days.ToString

                    If dr1.Item("S_ID") = My.Settings.Cash_ID Then
                        oSheet.RANGE("E" + row.ToString).VALUE = 0
                    End If
                    If (Rebate.Text <> "" Or rebate_amount > 0) Then
                        If rebate_amount > 0 Then
                            oSheet.RANGE("J" + row.ToString).VALUE = "=(I" + row.ToString + "*" + rebate_amount.ToString + ")"
                        Else
                            oSheet.RANGE("J" + row.ToString).VALUE = "=(I" + row.ToString + "*" + Rebate.Text.ToString + ")"
                        End If
                    Else
                        oSheet.RANGE("J" + row.ToString).VALUE = "=(I" + row.ToString + "*0)"
                    End If

                    oSheet.RANGE("K" + row.ToString).VALUE = "0"
                    If My.Settings.Extras_Location = "ANC" Then
                        oSheet.RANGE("L" + row.ToString).VALUE = xtra.ToString
                    ElseIf My.Settings.Extras_Location = "MESS" Then
                        oSheet.RANGE("H" + row.ToString).VALUE = xtra.ToString
                    End If


                    oSheet.RANGE("M" + row.ToString).VALUE = "=(E" + row.ToString + " * F" + row.ToString + ")+G" + row.ToString + "+H" + row.ToString + "-J" + row.ToString + "+K" + row.ToString + "+L" + row.ToString
                    row += 1

                    BackgroundWorker1.ReportProgress(CInt((row / 5) * 100))

                End While
            End If

            oSheet.RANGE("G" + row.ToString).VALUE = "=SUM(G2:G" + (row - 1).ToString + ")"
            oSheet.RANGE("H" + row.ToString).VALUE = "=SUM(H2:H" + (row - 1).ToString + ")"
            oSheet.RANGE("J" + row.ToString).VALUE = "=SUM(J2:J" + (row - 1).ToString + ")"
            oSheet.RANGE("K" + row.ToString).VALUE = "=SUM(K2:K" + (row - 1).ToString + ")"
            oSheet.RANGE("L" + row.ToString).VALUE = "=SUM(L2:L" + (row - 1).ToString + ")"
            oSheet.RANGE("M" + row.ToString).VALUE = "=SUM(M2:M" + (row - 1).ToString + ")"

            oSheet.RANGE("G" + row.ToString).INTERIOR.COLORINDEX = 46
            oSheet.RANGE("G" + row.ToString).FONT.SIZE = 20

            oSheet.RANGE("H" + row.ToString).INTERIOR.COLORINDEX = 43
            oSheet.RANGE("H" + row.ToString).FONT.SIZE = 20

            oSheet.RANGE("J" + row.ToString).INTERIOR.COLORINDEX = 46
            oSheet.RANGE("J" + row.ToString).FONT.SIZE = 20

            oSheet.RANGE("K" + row.ToString).INTERIOR.COLORINDEX = 43
            oSheet.RANGE("K" + row.ToString).FONT.SIZE = 20

            oSheet.RANGE("L" + row.ToString).INTERIOR.COLORINDEX = 46
            oSheet.RANGE("L" + row.ToString).FONT.SIZE = 20

            oSheet.RANGE("M" + row.ToString).INTERIOR.COLORINDEX = 43
            oSheet.RANGE("M" + row.ToString).FONT.SIZE = 20

            dr1.Close()
            con1.disconnect()
            con2.disconnect()
            con3.disconnect()
            con4.disconnect()
            dr2.Close()
            'dr3.Close()


            oSheet.Columns("A:Z").autofit()
            'oBook.SaveAs(filename, Password:="asd")
            oBook.SaveAs(filename)
            oExcel.Quit()

        Catch ex As Exception
            MsgBox("Error Occured! PLease Try again!")
            MsgBox(ex.Message.ToString)

        End Try
    End Sub

    'Handles Keypresses on the Form
    Private Sub formMonthlyBill_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        ElseIf e.KeyCode = Keys.F5 Then
            Controls.Clear()
            InitializeComponent()
            Rebate.Focus()
        End If
    End Sub

    'On Form load
    Private Sub formMonthlyBill_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Rebate.Focus()
        Me.KeyPreview = True
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "dd - MM - yyyy / HH:mm:ss"

        DateTimePicker1.Value = Now.AddHours(6 - Now.Hour)

        DateTimePicker2.Format = DateTimePickerFormat.Custom
        DateTimePicker2.CustomFormat = "dd - MM - yyyy / HH:mm:ss"

        DateTimePicker2.Value = Now.AddHours(23 - Now.Hour)
    End Sub

    'Handles Enter Pressed on Rebate Tb
    Private Sub Rebate_KeyDown(sender As Object, e As KeyEventArgs) Handles Rebate.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Rebate.Text <> "" Then
                Gen_Excel.Focus()
            Else
                MsgBox("No Value For Rebate Entered!! Value 0(ZERO) Assumed!!")
                Gen_Excel.Focus()
            End If
        End If
    End Sub

    Private Sub My_BgWorker_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        generate_all()
        BackgroundWorker1.ReportProgress(CInt((row / total) * 100))
    End Sub


    Private Sub My_BgWorker_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        'BackgroundWorker1.ReportProgress(99)
        MsgBox("Monthly Bill SAVED at : " + filename.ToString)
        Me.Close()
    End Sub

    Private Sub My_BgWorker_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        ' Update the progress bar
        If e.ProgressPercentage >= 0 And e.ProgressPercentage <= 100 Then
            ProgressBar1.Value = e.ProgressPercentage
        End If

    End Sub

    Private Sub Gen_Excel_Click(sender As Object, e As EventArgs) Handles Gen_Excel.Click

        ProgressBar1.Visible = True
        cal_total()
        'generate_all()
        'BackgroundWorker1.RunWorkerAsync()
        Try
            BackgroundWorker1.RunWorkerAsync()
        Catch ex As Exception

            BackgroundWorker1.Dispose()
            MsgBox("Error OCcured in Background Worker!")

            MsgBox(ex.Message.ToString)
        End Try
    End Sub
End Class