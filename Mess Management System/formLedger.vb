Imports MySql.Data.MySqlClient
Public Class formLedger
    Dim con As New connection 'Mysql Connection used through the Form
    Dim dt As New DataTable
    Dim dt1 As New DataTable
    Dim flag As Integer = 0


    'On Form Load
    Private Sub formLedger_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        TbItem_ID.Focus()
        'fill_mess_takes()
    End Sub

    'Handles Esc pressed on the Form
    Private Sub formLedger_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        ElseIf e.KeyCode = Keys.F12 Then
            Controls.Clear()
            InitializeComponent()
            TbItem_ID.Focus()
        End If

    End Sub

    'Runs the Ledger Query and Populates Appropriate DataGrids
    Private Sub calc_ledger()
        'If MonthCalendar1.MaxDate.Date >= MonthCalendar2.MaxDate.Date Then
        If (MonthCalendar1.SelectionRange.Start.Date > MonthCalendar1.TodayDate Or MonthCalendar2.SelectionRange.Start.Date > MonthCalendar1.TodayDate Or MonthCalendar1.SelectionRange.Start.Date > MonthCalendar2.SelectionRange.Start.Date) Then
            MsgBox("Error ! Please Choose Proper Dates for 'FROM' and 'TO' ")
        Else
            Try
                con.connect()
                If flag = 0 Then
                    dt.Columns.Add("Date")
                    dt.Columns.Add("Opening Balance")
                    dt.Columns.Add("New Reciept")
                    dt.Columns.Add("Consumed")
                    dt.Columns.Add("Closing Balance")
                    flag = 1
                End If
                Dim d As TimeSpan
                Dim DA As Date
                d = MonthCalendar2.SelectionRange.Start.Date.Subtract(MonthCalendar1.SelectionRange.Start.Date)

                DA = MonthCalendar1.SelectionRange.Start.Date.ToString

                Dim LDATE As MySqlParameter = New MySqlParameter("LDATE", MySqlDbType.Date)
                Dim LOPENING As MySqlParameter = New MySqlParameter("LOPENING", MySqlDbType.Int64)
                Dim LCLOSING As MySqlParameter = New MySqlParameter("LCLOSING", MySqlDbType.Int64)
                Dim LSUPPLY As MySqlParameter = New MySqlParameter("LSUPPLY", MySqlDbType.Int64)
                Dim LCONSUMPTION As MySqlParameter = New MySqlParameter("LCONSUMPTION", MySqlDbType.Int64)

                Dim CALDATE As MySqlParameter = New MySqlParameter("CALDATE", MySqlDbType.VarChar)
                Dim ITEMCODE As MySqlParameter = New MySqlParameter("ITEMCODE", MySqlDbType.Int64)

                For I = 1 To d.Days + 1
                    Dim comm As New MySqlCommand
                    comm.Connection = con.conn
                    comm.CommandType = CommandType.StoredProcedure
                    comm.CommandText = "CALCULATELEDGER"
                    'MsgBox("Done")
                    comm.Parameters.Add(CALDATE).Value = DA.ToString("yyyy-MM-dd")
                    CALDATE.Direction = ParameterDirection.Input
                    comm.Parameters.Add(ITEMCODE).Value = TbItem_ID.Text.ToString
                    ITEMCODE.Direction = ParameterDirection.Input
                    comm.Parameters.Add(LDATE).Direction = ParameterDirection.Output
                    comm.Parameters.Add(LOPENING).Direction = ParameterDirection.Output
                    comm.Parameters.Add(LCLOSING).Direction = ParameterDirection.Output
                    comm.Parameters.Add(LSUPPLY).Direction = ParameterDirection.Output
                    comm.Parameters.Add(LCONSUMPTION).Direction = ParameterDirection.Output
                    'MsgBox("Done")
                    comm.ExecuteNonQuery()
                    'MsgBox(LDATE.Value.ToString + ", " + LOPENING.Value.ToString + "," + LSUPPLY.Value.ToString + "," + LCONSUMPTION.Value.ToString + "," + LCLOSING.Value.ToString)
                    
                    dt.LoadDataRow(New Object() {LDATE.Value.ToString(), LOPENING.Value.ToString, LSUPPLY.Value.ToString, LCONSUMPTION.Value.ToString, LCLOSING.Value.ToString}, True)

                    comm.Dispose()
                    comm.Parameters.Clear()
                    DA = DA.AddDays(1.0)
                Next I

                DataGridView1.DataSource = dt
                TbItem_ID.SelectAll()

            Catch ex As Exception
                MsgBox("Error Occured! Please Try again")
                MsgBox(ex.Message.ToString)
            End Try
        End If
    End Sub


    Private Sub fill_mess_takes(Optional item_id As Integer = 0)
        con.connect()
        Dim query As String
        If item_id = 0 Then
            query = "select * from Mess_Takes ORDER BY DOR DESC"
        Else
            query = "Select * from Mess_takes where item_id = '" + TbItem_ID.Text + "'"
        End If
        Dim DR As MySqlDataReader
        Dim comm As New MySqlCommand(query, con.conn)
        DR = comm.ExecuteReader()
        Dim DT2 As New DataTable
        DT2.Load(DR)
        DataGridView2.DataSource = DT2
        DR.Close()
        For a As Integer = 0 To DataGridView2.Columns.Count - 1
            Dim col As DataGridViewColumn = DataGridView2.Columns(a)
            col.Width = 77
        Next
    End Sub

    'Handles Key PResses on ITem_ID Textbox
    Private Sub Item_ID_KeyDown(sender As Object, e As KeyEventArgs) Handles TbItem_ID.KeyDown
        If e.KeyCode = Keys.Enter Then
            dt1.Clear()
            dt.Clear()
            If TbItem_ID.Text <> "" Then
                Try
                    con.connect()
                    Dim query As String = "Select * from Item where item_id = '" + TbItem_ID.Text + "'"
                    Dim comm As New MySqlCommand(query, con.conn)
                    Dim dr As MySqlDataReader
                    dr = comm.ExecuteReader
                    If dr.Read() And Not IsDBNull(dr.Item(0)) Then
                        Label3.Text = dr.Item(1)
                        fill_mess_takes(TbItem_ID.Text)
                        'calc_ledger()
                        Ledger_Calc()
                    ElseIf IsDBNull(dr.Item(0)) Then
                        MsgBox("Item ID not Found!")
                    End If
                Catch ex As Exception
                    MsgBox("Error Occured or Item ID Not found !! Please Try Again!")
                    MsgBox(ex.Message.ToString)
                End Try
            Else
                MsgBox("Enter Proper Item ID")
            End If
        End If
    End Sub

    'Checks if an Item ID has been entered or not
    Private Sub MonthCalendar2_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar2.DateChanged
        If TbItem_ID.Text <> "" Then
            'DataGridView1.DataSource = False
            'DataGridView1.Rows.Clear()
            dt.Clear()
            DataGridView1.Refresh()
            'calc_ledger()
            Ledger_Calc()
        Else
            MsgBox("Enter An Item ID")
            TbItem_ID.Focus()
        End If
    End Sub

    'Checks if an Item ID has been entered or not
    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        If TbItem_ID.Text <> "" Then
            'DataGridView1.DataSource = False
            'DataGridView1.Rows.Clear()
            dt.Clear()
            DataGridView1.Refresh()
            'calc_ledger()
            Ledger_Calc()
        Else
            MsgBox("Enter An Item ID")
            TbItem_ID.Focus()
        End If
    End Sub



    Private Sub Ledger_Calc()
        If (MonthCalendar1.SelectionRange.Start.Date > MonthCalendar1.TodayDate Or MonthCalendar2.SelectionRange.Start.Date > MonthCalendar1.TodayDate Or MonthCalendar1.SelectionRange.Start.Date > MonthCalendar2.SelectionRange.Start.Date) Then
            MsgBox("Error ! Please Choose Proper Dates for 'FROM' and 'TO' ")
        Else
            Dim d As TimeSpan
            Dim caldate As Date = MonthCalendar1.SelectionStart.Date.ToString("yyyy-MM-dd")
            d = MonthCalendar2.SelectionRange.Start.Date.Subtract(MonthCalendar1.SelectionRange.Start.Date)
            If flag = 0 Then
                dt.Columns.Add("Date")
                dt.Columns.Add("Opening Balance")
                dt.Columns.Add("New Reciept")
                dt.Columns.Add("Consumed")
                dt.Columns.Add("Closing Balance")
                flag = 1
            End If
            For I = 1 To d.Days + 1
                Try
                    Dim con1 As New connection
                    Dim con2 As New connection
                    Dim con3 As New connection
                    Dim con4 As New connection
                    Dim con5 As New connection
                    Dim con6 As New connection

                    con1.connect()
                    con2.connect()
                    con3.connect()
                    con4.connect()
                    con5.connect()
                    con6.connect()

                    Dim start_qty As Integer = 0
                    Dim current_qty As Integer = 0
                    Dim total_supplies As Integer = 0
                    Dim total_consumption As Integer = 0
                    Dim lsupply As Integer = 0
                    Dim lconsumption As Integer = 0

                    'caldate = caldate.AddDays(1)
                    'MsgBox(caldate)
                    '                    MsgBox(caldate.AddDays(1).ToString("yyyy-MM-dd"))
                    Dim query1 As String = "SELECT GREATEST(SUM(QTY),0) FROM MESS_TAKES WHERE ITEM_ID='" + TbItem_ID.Text.ToString + "' AND (DATE(DOR) >= '" + caldate.ToString("yyyy-MM-dd") + "' AND DATE(DOR) < '" + caldate.AddDays(1).ToString("yyyy-MM-dd") + "')"

                    Dim query2 As String = "SELECT GREATEST(SUM(QTY),0) FROM STUDENT_TAKES WHERE ITEM_ID='" + TbItem_ID.Text.ToString + "' AND (DATE(DOR) >= '" + caldate.ToString("yyyy-MM-dd") + "' AND DATE(DOR) < '" + caldate.AddDays(1).ToString("yyyy-MM-dd") + "')"

                    Dim query3 As String = "SELECT GREATEST(QTY,0) FROM MESS_STORE WHERE ITEM_ID='" + TbItem_ID.Text.ToString + "'"

                    Dim query4 As String = "SELECT GREATEST(SUM(QTY),0) FROM MESS_TAKES WHERE ITEM_ID='" + TbItem_ID.Text.ToString + "' AND DATE(DOR) >= '" + caldate.ToString("yyyy-MM-dd") + "'"

                    'Dim query5 As String = "SELECT GREATEST(SUM(QTY),0) FROM MESS_TAKES WHERE ITEM_ID='" + TbItem_ID.Text.ToString + "' AND (DATE(DOR) >= '" + caldate.ToString("yyyy-MM-dd") + "' AND DATE(DOR) < '" + caldate.AddDays(1).ToString("yyyy-MM-dd") + "')"

                    Dim query6 As String = "SELECT GREATEST(SUM(QTY),0) FROM STUDENT_TAKES WHERE ITEM_ID='" + TbItem_ID.Text.ToString + "' AND DATE(DOR) >= '" + caldate.ToString("yyyy-MM-dd") + "'"

                    Dim comm1 As New MySqlCommand(query1, con1.conn)

                    Dim comm2 As New MySqlCommand(query2, con2.conn)

                    Dim comm3 As New MySqlCommand(query3, con3.conn)
                    Dim comm4 As New MySqlCommand(query4, con4.conn)
                    'Dim comm5 As New MySqlCommand(query5, con5.conn)
                    Dim comm6 As New MySqlCommand(query6, con6.conn)

                    Dim dr1, dr2, dr3, dr4, dr5, dr6 As MySqlDataReader

                    'dr1 = comm1.ExecuteReader
                    'MsgBox("1")

                    'Total Consumption
                    dr2 = comm6.ExecuteReader
                    'MsgBox("1")

                    'Current Qty
                    dr3 = comm3.ExecuteReader
                    'MsgBox("1")

                    'Total Supplies
                    dr4 = comm4.ExecuteReader
                    'MsgBox("1")

                    'Lsupply
                    dr5 = comm1.ExecuteReader
                    'MsgBox("1")

                    'Lconsumption
                    dr6 = comm2.ExecuteReader
                    'MsgBox("1")

                    start_qty = 0
                    'MsgBox(start_qty.ToString)

                    If dr2.Read Then
                        If Not IsDBNull(dr2.Item(0)) Then
                            total_consumption = dr2.Item(0)
                        Else
                            total_consumption = 0
                        End If
                    Else
                        total_consumption = 0
                    End If
                    If dr3.Read Then
                        If Not IsDBNull(dr3.Item(0)) Then
                            current_qty = dr3.Item(0)
                        Else
                            current_qty = 0
                        End If
                    Else
                        current_qty = 0
                    End If
                    If dr4.Read Then
                        If Not IsDBNull(dr4.Item(0)) Then
                            total_supplies = dr4.Item(0)
                        Else
                            total_supplies = 0
                        End If
                    Else
                        total_supplies = 0
                    End If
                    If dr5.Read Then
                        If Not IsDBNull(dr5.Item(0)) Then
                            lsupply = dr5.Item(0)
                        Else
                            lsupply = 0
                        End If
                    Else
                        lsupply = 0
                    End If

                    If dr6.Read Then
                        If Not IsDBNull(dr6.Item(0)) Then
                            lconsumption = dr6.Item(0)
                        Else
                            lconsumption = 0
                        End If
                    Else
                        lconsumption = 0
                    End If
                    Dim lopening As Integer = current_qty - total_supplies + total_consumption
                    Dim lclosing As Integer = lopening + lsupply - lconsumption

                    

                    dt.LoadDataRow(New Object() {caldate.ToString(), lopening.ToString, lsupply.ToString, lconsumption.ToString, lclosing.ToString}, True)

                    caldate = caldate.AddDays(1)
                    con1.disconnect()
                    con2.disconnect()
                    con3.disconnect()
                    con4.disconnect()
                    con5.disconnect()
                    con6.disconnect()

                Catch ex As Exception
                    MsgBox("Error OCcured! Please Try again!")
                    MsgBox(ex.Message.ToString)
                End Try
            Next I
            DataGridView1.DataSource = dt
        End If
    End Sub
End Class