'Imports Microsoft.Office.Interop.Excel
Imports Microsoft.VisualBasic
Imports MySql.Data.MySqlClient
Public Class formMonthlyBill
    Dim con1 As New connection 'Mysql Connection 1 used thorugh the Form
    Dim con2 As New connection 'Mysql Connection 2 used thorugh the Form
    Dim comm1, comm2 As New MySqlCommand ' Mysql Commands used in the Form

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
            Dim query6 As String = "Select count(distinct s_id) from student_takes"
            Dim comm4 As New MySqlCommand(query6, con1.conn)
            Dim dr6 As MySqlDataReader = comm4.ExecuteReader
            dr6.Read()
            total = dr6.Item(0) + 2
        Catch ex As Exception
            MsgBox("Error Occured! Please Try Again")
            MsgBox(ex.Message.ToString)
        End Try
    End Sub


    'Generates the Monthly Bill Excel File 
    Private Sub generate_all() 'Handles BackgroundWorker1.DoWork 'Handles Gen_Excel.Click
        Try

            filename = "D:" + "\Mess_Monthly_Bill_" + MonthName(MonthCalendar1.SelectionRange.Start.Month.ToString) + "_" + MonthCalendar1.SelectionRange.Start.Year.ToString + ".xlsx"
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

            'Dim row As Integer
            Dim iter As Int16
            iter = 1
            con1.disconnect()
            con1.connect()
            con2.disconnect()
            con2.connect()

            comm1.Connection = con1.conn
            comm2.Connection = con2.conn
            comm1.CommandText = "SELECT * FROM STUDENT ORDER BY BHAWAN,ROOM "

            Dim dr1, dr2, dr3 As MySqlDataReader
            Dim tm, tmr, item0_amt, item1_amt, item2_amt, item3_amt, item4_amt, item5_amt, rebate_days As Integer
            Dim mthly, xtra, nv As Double
            Dim rebate_amount, mess_daily_amount, item0, item1, item2, item3, item4, item5 As Double
            'Dim anc_bill As Double
            row = 2

            dr1 = comm1.ExecuteReader
            'MsgBox("'" + MonthCalendar1.SelectionRange.Start.Year.ToString + "-" + MonthCalendar1.SelectionRange.Start.Month.ToString + "-00'")
            comm2.CommandText = "SELECT * from MONTHLY_MASTER where MONTH_YEAR = '" + MonthCalendar1.SelectionRange.Start.Year.ToString + "-" + MonthCalendar1.SelectionRange.Start.Month.ToString("00") + "-00'"
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
                dr2.Close()
            Else
                rebate_amount = 0
                mess_daily_amount = 0
                item0 = 0
                item1 = 0
                item2 = 0
                item3 = 0
                item4 = 0
                item5 = 0
                dr2.Close()
            End If

            While (dr1.Read())
                'MsgBox(dr1.Item(0).ToString())
                'comm2.CommandText = "SELECT greatest(price, 0) FROM temp_monthly WHERE s_id ='" + dr1.Item(0).ToString + "'"
                'mthly = comm2.ExecuteScalar()

                comm2.CommandText = "SELECT * from MONTHLY_DETAILS where s_id = '" + dr1.Item(0).ToString + "' and MONTH_YEAR = '" + MonthCalendar1.SelectionRange.Start.Year.ToString + "-" + MonthCalendar1.SelectionRange.Start.Month.ToString("00") + "-00'"

                dr3 = comm2.ExecuteReader
                If dr3.Read() Then
                    rebate_days = dr3.Item(2)
                    item0_amt = dr3.Item(3)
                    item1_amt = dr3.Item(4)
                    item2_amt = dr3.Item(5)
                    item3_amt = dr3.Item(6)
                    item4_amt = dr3.Item(7)
                    item5_amt = dr3.Item(8)
                Else
                    item0_amt = 0
                    rebate_days = 0
                    item1_amt = 0
                    item2_amt = 0
                    item3_amt = 0
                    item4_amt = 0
                    item5_amt = 0
                End If
                mthly = item0_amt * item0 + item1_amt * item1 + item2_amt * item2 + item3_amt * item3 + item4_amt * item4 + item5_amt * item5
                dr3.Close()
                comm2.CommandText = "SELECT coalesce(SUM(qty*(rate*(1+(tax/100)))), 0) AS tot FROM student_takes WHERE s_id ='" + dr1.Item(0).ToString + "' AND (date_format(DOR,'%m')='" + MonthCalendar1.SelectionRange.Start.Month.ToString + "' OR date_format(DOR,'%m')='0" + MonthCalendar1.SelectionRange.Start.Month.ToString + "') AND date_format(DOR,'%Y')= '" + MonthCalendar1.SelectionRange.Start.Year.ToString + "'"
                xtra = comm2.ExecuteScalar()

                'comm2.CommandText = "SELECT NVL(Sum(NV_PRICE.PRICE*STUDENT_TAKES.QTY),0) FROM STUDENT_TAKES, NV_PRICE WHERE STUDENT_TAKES.ITEM_ID=999 AND STUDENT_TAKES.S_ID='" + dr1.Item(0).ToString + "' AND TO_CHAR(NV_PRICE.DOR) = TO_CHAR(STUDENT_TAKES.DOR) AND (TO_CHAR(STUDENT_TAKES.DOR,'MM')='0" + MonthCalendar1.SelectionRange.Start.Month.ToString + "' OR TO_CHAR(STUDENT_TAKES.DOR,'MM')='" + MonthCalendar1.SelectionRange.Start.Month.ToString + "') AND TO_CHAR(STUDENT_TAKES.DOR,'YYYY')='" + MonthCalendar1.SelectionRange.Start.Year.ToString + "'"
                'nv = OracleCommand2.ExecuteScalar()

                'OracleCommand2.CommandText = "SELECT NVL(ANC_BILL,0) FROM MONTHLY_SPCL WHERE S_ID='" + dr1.Item(0).ToString + "' AND MONTH='" + MonthCalendar1.SelectionRange.Start.Month.ToString + "'"
                'anc_bill = OracleCommand2.ExecuteScalar()

                xtra = xtra + nv
                tmr = 0
                tm = 0

                If dr1.Item("NAME") = "CASH" Then
                    mthly = 0
                    rebate_days = 0
                End If

                oSheet.RANGE("A" + row.ToString).Value = dr1.Item("IDNO").ToString
                oSheet.RANGE("B" + row.ToString).VALUE = dr1.Item("NAME").ToString
                oSheet.RANGE("C" + row.ToString).VALUE = dr1.Item("ROOM").ToString
                oSheet.RANGE("D" + row.ToString).VALUE = dr1.Item("BHAWAN").ToString
                oSheet.RANGE("E" + row.ToString).VALUE = System.DateTime.DaysInMonth(MonthCalendar1.SelectionRange.Start.Year, MonthCalendar1.SelectionRange.Start.Month)
                oSheet.RANGE("F" + row.ToString).VALUE = mess_daily_amount
                oSheet.RANGE("G" + row.ToString).VALUE = mthly.ToString
                oSheet.RANGE("H" + row.ToString).VALUE = xtra.ToString
                oSheet.RANGE("I" + row.ToString).VALUE = rebate_days

                If dr1.Item("NAME") = "CASH" Then
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
                'oSheet.RANGE("L" + row.ToString).VALUE = anc_bill.ToString()
                oSheet.RANGE("M" + row.ToString).VALUE = "=(E" + row.ToString + " * F" + row.ToString + ")+G" + row.ToString + "+H" + row.ToString + "-J" + row.ToString + "+K" + row.ToString
                row += 1
                System.Threading.Thread.Sleep(1000)
                BackgroundWorker1.ReportProgress(CInt((row / 5) * 100))

            End While

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
            oSheet.Columns("A:Z").autofit()
            oBook.SaveAs(filename)
            oExcel.Quit()
            'MsgBox("Monthly Bill SAVED at : " + filename.ToString)
            'Me.Close()
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
        MsgBox("Monthly Bill SAVED at : " + filename.ToString)
        Me.Close()
    End Sub

    Private Sub My_BgWorker_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        ' Update the progress bar
        If e.ProgressPercentage >= 0 And e.ProgressPercentage <= 100 Then
            Me.ProgressBar1.Value = e.ProgressPercentage
        End If

    End Sub

    Private Sub Gen_Excel_Click(sender As Object, e As EventArgs) Handles Gen_Excel.Click
        ProgressBar1.Visible = True
        cal_total()
        Try
            BackgroundWorker1.RunWorkerAsync()
        Catch ex As Exception
            BackgroundWorker1.Dispose()
            MsgBox("Error OCcured in Background Worker!")

            MsgBox(ex.Message.ToString)
        End Try
    End Sub
End Class