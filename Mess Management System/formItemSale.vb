Imports MySql.Data.MySqlClient
Public Class formItemSale
    Dim tableFont, titlefont, headfont As Font 'Used in Printing the Summary
    Dim con As New connection 'Mysql Connection used through the Form
    Dim flag As Integer = 0 'Before Prining, Checks if the Datagrid is filled
    Dim credit_total_sale As Double
    Dim sup_id As Integer = 0
    Dim flag_for_month_end As Boolean = False

    'Hanndles Various KeyPresses on Form
    Private Sub formItemSale_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        ElseIf e.KeyCode = Keys.F5 Then
            RELOAD()
        End If
    End Sub

    Private Sub RELOAD()
        Controls.Clear()
        InitializeComponent()
        TextBox1.Focus()
        Me.KeyPreview = True
        TextBox1.Focus()
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "dd - MM - yyyy / HH:mm:ss"
        DateTimePicker1.Value = Today.Date.ToString
        DateTimePicker1.Value = DateTimePicker1.Value.AddHours(7.0)
        DateTimePicker2.Format = DateTimePickerFormat.Custom
        DateTimePicker2.CustomFormat = "dd - MM - yyyy / HH:mm:ss"
        DateTimePicker2.Value = Today.Date.ToString
        DateTimePicker2.Value = DateTimePicker2.Value.AddHours(23.0)
    End Sub

    'On form Load
    Private Sub formItemSale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        TextBox1.Focus()
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "dd - MM - yyyy / HH:mm:ss"
        DateTimePicker1.Value = Today.Date.ToString
        DateTimePicker1.Value = DateTimePicker1.Value.AddHours(7.0)
        DateTimePicker2.Format = DateTimePickerFormat.Custom
        DateTimePicker2.CustomFormat = "dd - MM - yyyy / HH:mm:ss"
        DateTimePicker2.Value = Today.Date.ToString
        DateTimePicker2.Value = DateTimePicker2.Value.AddHours(23.0)
    End Sub

    'Handles Enter Pressed on Item_ID TB
    Private Sub Item_ID_keydown(sender As Object, e As KeyEventArgs) Handles ITEM_ID.KeyDown
        If e.KeyCode = Keys.Enter Then
            DateTimePicker1.Focus()
            If ITEM_ID.Text <> "" Then
                TextBox1.Enabled = False
            End If
        End If
    End Sub


    'Handles Submit Clicked
    'Draws the Proper Data into the Datagrid, if item_id blank ->gets all the Data, else Specific to an Item_Id
    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        DataGridView1.Columns.Clear()
        If flag_for_month_end = False Then
            Try
                con.connect()
                Dim query As String
                If ITEM_ID.Text <> "" And TextBox1.Text = "" Then
                    'MsgBox(DateTimePicker1.Value.ToString("yyyy-MM-dd hh:mm:ss"))
                    query = "SELECT DISTINCT ITEM_ID,Sum(qty) AS Total_Sales,Rate,SUM(qty*rate) as TOTAL_SALES_AMOUNT FROM student_takes where item_id = '" + ITEM_ID.Text.ToString + "' and dor >= '" + DateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss") + "' and dor <= '" + DateTimePicker2.Value.ToString("yyyy-MM-dd HH:mm:ss") + "' GROUP BY Item_id"
                    'query = "SELECT DISTINCT ITEM_ID,Sum(qty) AS Total_Sales,Rate FROM student_takes where item_id = '" + ITEM_ID.Text + "' and datediff(dor,'" + DateTimePicker1.Value.ToString("yyyy-MM-dd") + "')>= 0 and datediff(dor,'" + DateTimePicker2.Value.ToString("yyyy-MM-dd") + "') <= 0 GROUP BY Item_id"
                ElseIf ITEM_ID.Text = "" And TextBox1.Text <> "" Then
                    'query = "SELECT DISTINCT ITEM_ID,Sum(qty) AS Total_Sales,Rate FROM student_takes where dor >= '" + DateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss") + "' and dor <= '" + DateTimePicker2.Value.ToString("yyyy-MM-dd HH:mm:ss") + "' GROUP BY Item_id"
                    query = "SELECT DISTINCT student_takes.ITEM_ID, student_takes.Rate as RATE, Sum(Student_takes.qty) AS Total_Sales, SUM(student_takes.qty*student_takes.rate) As TOTAL_SALE_AMOUNT from student_takes inner join item  inner join supplier_master where item.sup_id = supplier_master.sup_id and item.item_id = student_takes.item_id and supplier_master.sup_id = '" + TextBox1.Text.ToString + "' and  dor >= '" + DateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss") + "' and dor <= '" + DateTimePicker2.Value.ToString("yyyy-MM-dd HH:mm:ss") + "' GROUP BY student_takes.Item_id"

                    'query = "SELECT DISTINCT ITEM_ID,Sum(qty) AS Total_Sales,Rate FROM student_takes where datediff(dor,'" + DateTimePicker1.Value.ToString("yyyy-MM-dd") + "')>= 0 and datediff(dor,'" + DateTimePicker2.Value.ToString("yyyy-MM-dd") + "') <= 0 GROUP BY Item_id"
                Else
                    query = "SELECT DISTINCT ITEM_ID,Sum(qty) AS Total_Sales,Rate, SUM(student_takes.qty*student_takes.rate) as TOTAL_SALES_AMOUNT FROM student_takes where dor >= '" + DateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss") + "' and dor <= '" + DateTimePicker2.Value.ToString("yyyy-MM-dd HH:mm:ss") + "' GROUP BY Item_id"
                End If

                Dim comm As New MySqlCommand(query, con.conn)
                Dim dr As MySqlDataReader
                Dim dt As New DataTable
                dr = comm.ExecuteReader
                dt.Load(dr)
                DataGridView1.DataSource = dt
                dr.Close()
                Dim col1, col2, col3 As New DataGridViewTextBoxColumn
                col1.DataPropertyName = "Item_Name"
                col1.HeaderText = "Item Name"
                col1.Name = "Item_Name"
                col1.Width = 65
                DataGridView1.Columns.Add(col1)
                'col2.DataPropertyName = "SP"
                'col2.HeaderText = "SP"
                'col2.Name = "SP"
                'col2.Width = 65
                'DataGridView1.Columns.Add(col2)
                'col3.DataPropertyName = "TOT_ITEM_AMT"
                'col3.Width = 65
                'col3.HeaderText = "Sale Amt."
                'col3.Name = "TOT_ITEM_AMT"
                'DataGridView1.Columns.Add(col3)
                For a As Integer = 0 To DataGridView1.Rows.Count - 1
                    Try
                        con.connect()
                        Dim query1 As String = "SELECT NAME from ITEM WHERE ITEM_ID = '" + DataGridView1.Rows(a).Cells(0).Value.ToString + "'"
                        Dim comm1 As New MySqlCommand(query1, con.conn)
                        Dim dr1 As MySqlDataReader
                        dr1 = comm1.ExecuteReader
                        dr1.Read()
                        Dim item_name As String
                        If CStr(dr1.Item(0)).Length > 12 Then
                            item_name = CStr(dr1.Item("NAME")).Substring(0, 3) + "..." + CStr(dr1.Item("NAME")).Substring(CStr(dr1.Item("NAME")).Length - 6, 6)
                        Else
                            item_name = dr1.Item(0)
                        End If
                        DataGridView1.Rows(a).Cells(4).Value = item_name
                        'DataGridView1.Rows(a).Cells(4).Value = dr1.Item(1)
                        dr1.Close()
                    Catch ex As Exception
                        MsgBox("Error Occured ! Please Try Again !")
                        MsgBox(ex.Message.ToString)
                    End Try
                Next
                For n As Integer = 0 To DataGridView1.Columns.Count - 1
                    Dim column As DataGridViewColumn = DataGridView1.Columns(n)
                    column.Width = 70
                Next
                calculate_total_sale()
                calculate_Grand_sale()
                flag = 1
            Catch ex As MySqlException
                MsgBox("Error Occured ! Please Try Again!111")
                MsgBox(ex.Message.ToString)
            End Try
        Else
            month_end_summary()
        End If

    End Sub


    'Handles Cancel Clicked
    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub


    'Handles Enter Pressed, moves cursor to next datetimepicker
    Private Sub DateTimePicker1_KeyDown(sender As Object, e As KeyEventArgs) Handles DateTimePicker1.KeyDown
        If e.KeyCode = Keys.Enter Then
            DateTimePicker2.Focus()
        End If
    End Sub

    'Handles Enter Pressed, moves cursor to Submit Button
    Private Sub DateTimePicker2_KeyDown(sender As Object, e As KeyEventArgs) Handles DateTimePicker2.KeyDown
        If e.KeyCode = Keys.Enter Then
            Submit.Focus()
        End If
    End Sub

    'Calculates the Total Sale of every Item in the DataGrid
    Private Sub calculate_total_sale()
        Dim tot As Double
        For a As Integer = 0 To DataGridView1.Rows.Count - 1
            '    tot = DataGridView1.Rows(a).Cells(1).Value * DataGridView1.Rows(a).Cells(2).Value
            '   DataGridView1.Rows(a).Cells(4).Value = tot
        Next
        calc_credit_total()
    End Sub

    'Calculates the Grand Total Sale Amt
    Private Sub calculate_Grand_sale()
        Dim tot As Single
        If flag_for_month_end = False Then
            For a As Integer = 0 To DataGridView1.Rows.Count - 1
                tot = tot + DataGridView1.Rows(a).Cells(3).Value
            Next

            Label8.Text = tot.ToString
        Else
            For a As Integer = 0 To DataGridView1.Rows.Count - 1
                tot = tot + DataGridView1.Rows(a).Cells(4).Value
            Next

            Label8.Text = tot.ToString
        End If
    End Sub

    'Prints All the Data in the Datagrid
    Private Sub print_bill(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Try
            Dim start_date, end_date As String
            Dim a As Integer

            'dat = Now.Day.ToString + "/" + Now.Month.ToString + "/" + Now.Year.ToString + "     " + Now.Hour.ToString + ":" + Now.Minute.ToString + ":" + Now.Second.ToString
            headfont = New Font("Courier New", 12, FontStyle.Bold)
            tableFont = New Font("Courier New", 10, FontStyle.Bold)
            Dim Datefont = New Font("Courier New", 7.5, FontStyle.Bold)
            e.Graphics.DrawString("ITEM SALE SUMMARY", headfont, Brushes.Black, 60, 0)
            e.Graphics.DrawString("*****************", headfont, Brushes.Black, 60, 15)
            
            If flag_for_month_end = False Then
                start_date = DateTimePicker1.Value
                end_date = DateTimePicker2.Value
                con.connect()
                If TextBox1.Text <> "" Then
                    Dim query5 = "Select Name from SUpplier_master where sup_Id = '" + TextBox1.Text.ToString + "'"
                    Dim comm5 As New MySqlCommand(query5, con.conn)
                    Dim dr5 As MySqlDataReader = comm5.ExecuteReader
                    dr5.Read()
                    e.Graphics.DrawString("Supplier ID : " + CStr(sup_id) + "   Supplier Name : " + dr5.Item(0), Datefont, Brushes.Black, 5, 35)

                Else


                End If
                e.Graphics.DrawString(start_date + " TO", Datefont, Brushes.Black, 0, 55)
                e.Graphics.DrawString(end_date, Datefont, Brushes.Black, 150, 55)
                e.Graphics.DrawString("--------------------------------------", tableFont, Brushes.Black, -20, 65)
                e.Graphics.DrawString("--------------------------------------", tableFont, Brushes.Black, -20, 70)

                e.Graphics.DrawString("Item Name", tableFont, Brushes.Black, 10, 90)
                e.Graphics.DrawString("Rate", tableFont, Brushes.Black, 130, 90)
                e.Graphics.DrawString("Qty", tableFont, Brushes.Black, 180, 90)
                e.Graphics.DrawString("Total", tableFont, Brushes.Black, 220, 90)

                For n As Integer = 0 To DataGridView1.Rows.Count - 1
                    Dim item_name As String
                    If CStr(DataGridView1.Rows(n).Cells(4).Value).Length > 12 Then
                        item_name = CStr(DataGridView1.Rows(n).Cells(4).Value).Substring(0, 3) + "..." + CStr(DataGridView1.Rows(n).Cells(4).Value).Substring(CStr(DataGridView1.Rows(n).Cells(3).Value).Length - 6, 6)
                    Else
                        item_name = DataGridView1.Rows(n).Cells(4).Value
                    End If
                    If TextBox1.Text = "" Then
                        e.Graphics.DrawString(item_name, tableFont, Brushes.Black, 0, 110 + 20 * n)
                        e.Graphics.DrawString(DataGridView1.Rows(n).Cells(2).Value, tableFont, Brushes.Black, 130, 110 + 20 * n)
                        e.Graphics.DrawString(DataGridView1.Rows(n).Cells(1).Value, tableFont, Brushes.Black, 180, 110 + 20 * n)
                        e.Graphics.DrawString(DataGridView1.Rows(n).Cells(3).Value, tableFont, Brushes.Black, 220, 110 + 20 * n)
                    Else
                        e.Graphics.DrawString(item_name, tableFont, Brushes.Black, 0, 110 + 20 * n)
                        e.Graphics.DrawString(DataGridView1.Rows(n).Cells(1).Value, tableFont, Brushes.Black, 130, 110 + 20 * n)
                        e.Graphics.DrawString(DataGridView1.Rows(n).Cells(2).Value, tableFont, Brushes.Black, 180, 110 + 20 * n)
                        e.Graphics.DrawString(DataGridView1.Rows(n).Cells(3).Value, tableFont, Brushes.Black, 220, 110 + 20 * n)
                    End If
                Next
            Else
                If TextBox1.Text <> "" Then
                    Dim query5 = "Select Name from SUpplier_master where sup_Id = '" + TextBox1.Text.ToString + "'"
                    Dim comm5 As New MySqlCommand(query5, con.conn)
                    Dim dr5 As MySqlDataReader = comm5.ExecuteReader
                    dr5.Read()
                    e.Graphics.DrawString("Supplier ID : " + CStr(sup_id) + "   Supplier Name : " + dr5.Item(0), Datefont, Brushes.Black, 5, 35)
                Else

                End If
                start_date = "2014-" + DateTimePicker1.Value.ToString("MM") + "-01 12:00:00"
                end_date = "2014-" + DateTimePicker1.Value.ToString("MM") + "-31 12:00:00"
                e.Graphics.DrawString(start_date + " TO", Datefont, Brushes.Black, 0, 55)
                e.Graphics.DrawString(end_date, Datefont, Brushes.Black, 150, 55)
                e.Graphics.DrawString("--------------------------------------", tableFont, Brushes.Black, -20, 65)
                e.Graphics.DrawString("--------------------------------------", tableFont, Brushes.Black, -20, 70)


                e.Graphics.DrawString("Item Name", tableFont, Brushes.Black, 10, 90)
                e.Graphics.DrawString("Rate", tableFont, Brushes.Black, 140, 90)
                e.Graphics.DrawString("Qty", tableFont, Brushes.Black, 190, 90)
                e.Graphics.DrawString("Total", tableFont, Brushes.Black, 240, 90)

                For n As Integer = 0 To DataGridView1.Rows.Count - 1
                    'MsgBox(DataGridView1.Rows(n).Cells(1).Value)
                    Dim item_name As String
                    If CStr(DataGridView1.Rows(n).Cells(1).Value).Length > 12 Then
                        item_name = CStr(DataGridView1.Rows(n).Cells(1).Value).Substring(0, 3) + "..." + CStr(DataGridView1.Rows(n).Cells(1).Value).Substring(CStr(DataGridView1.Rows(n).Cells(1).Value).Length - 6, 6)
                    Else
                        item_name = DataGridView1.Rows(n).Cells(1).Value
                    End If
                    e.Graphics.DrawString(item_name, tableFont, Brushes.Black, 10, 110 + 20 * n)

                    If TextBox1.Text = "" Then
                        e.Graphics.DrawString(item_name, tableFont, Brushes.Black, 10, 110 + 20 * n)
                        e.Graphics.DrawString(DataGridView1.Rows(n).Cells(2).Value, tableFont, Brushes.Black, 130, 110 + 20 * n)
                        e.Graphics.DrawString(DataGridView1.Rows(n).Cells(1).Value, tableFont, Brushes.Black, 180, 110 + 20 * n)
                        e.Graphics.DrawString(DataGridView1.Rows(n).Cells(3).Value, tableFont, Brushes.Black, 220, 110 + 20 * n)
                    Else
                        e.Graphics.DrawString(item_name, tableFont, Brushes.Black, 10, 110 + 20 * n)
                        e.Graphics.DrawString(DataGridView1.Rows(n).Cells(1).Value, tableFont, Brushes.Black, 130, 110 + 20 * n)
                        e.Graphics.DrawString(DataGridView1.Rows(n).Cells(2).Value, tableFont, Brushes.Black, 180, 110 + 20 * n)
                        e.Graphics.DrawString(DataGridView1.Rows(n).Cells(3).Value, tableFont, Brushes.Black, 220, 110 + 20 * n)
                    End If
                Next
            End If
                a = DataGridView1.Rows.Count - 1
                calc_credit_total()

                e.Graphics.DrawString("--------------------------------------", tableFont, Brushes.Black, -20, 110 + 20 * (a + 1))
                e.Graphics.DrawString("--------------------------------------", tableFont, Brushes.Black, -20, 115 + 20 * (a + 1))
            e.Graphics.DrawString("Cash Total Sale : " + CStr(CInt(CDbl(Label8.Text) - credit_total_sale)), headfont, Brushes.Black, 10, 100 + 20 * (a + 3) + 20)
            e.Graphics.DrawString("Credit Total Sale : " + CStr(CInt(credit_total_sale)), headfont, Brushes.Black, 0, 100 + 20 * (a + 3) + 40)
            e.Graphics.DrawString("Grand Total Sale : " + CStr(CInt(Label8.Text.ToString)), headfont, Brushes.Black, 10, 100 + 20 * (a + 3) + 60)
        Catch ex As Exception
            MsgBox("Could not Print ! Error Occured")
            MsgBox(ex.Message.ToString)
        End Try

    End Sub

    'Handles Print Command
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Print.Click
        If flag = 1 Then
            PrintDocument1.Print()
        Else
            MsgBox("No Data Selected")
        End If
    End Sub

    Private Sub calc_credit_total()
        Try
            con.connect()
            Dim query1 As String
            If TextBox1.Text = "" Then
                If flag_for_month_end = False Then
                    query1 = "SELECT SUM(QTY*(RATE)) from Student_takes WHERE s_id != '" + My.Settings.Cash_ID.ToString + "' and dor >= '" + DateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss") + "' and dor <= '" + DateTimePicker2.Value.ToString("yyyy-MM-dd HH:mm:ss") + "'"
                Else
                    query1 = "SELECT SUM(QTY*(RATE)) FROM STUDENT_TAKES WHERE S_ID != '" + My.Settings.Cash_ID.ToString + "' and DOR >= '" + DateTimePicker2.Value.ToString("yyyy-MM-dd HH:mm:ss") + "' AND DOR <= '" + DateTimePicker2.Value.ToString("yyyy-MM-dd HH:mm:ss") + "'"
                End If
            Else
                If flag_for_month_end = False Then
                    query1 = "SELECT SUM(Student_takes.QTY*(Student_takes.RATE)) from Student_takes inner join item  inner join supplier_master where item.sup_id = supplier_master.sup_id and item.item_id = student_takes.item_id AND STUDENT_TAKES.s_id != '" + My.Settings.Cash_ID.ToString + "' and STUDENT_TAKES.dor >= '" + DateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss") + "' and STUDENT_TAKES.dor <= '" + DateTimePicker2.Value.ToString("yyyy-MM-dd HH:mm:ss") + "' AND SUPPLIER_MASTER.SUP_ID = '" + TextBox1.Text.ToString + "'"
                Else
                    query1 = "SELECT SUM(Student_takes.QTY*(Student_takes.RATE)) from Student_takes inner join item  inner join supplier_master where item.sup_id = supplier_master.sup_id and item.item_id = student_takes.item_id AND STUDENT_TAKES.s_id != '" + My.Settings.Cash_ID.ToString + "' and DOR >= '2014-" + DateTimePicker1.Value.ToString("MM") + "-01 12:00:00' AND DOR <= '2014-" + DateTimePicker1.Value.ToString("MM") + "-31 12:00:00' AND SUPPLIER_MASTER.SUP_ID = '" + TextBox1.Text.ToString + "'"
                End If
            End If


            Dim comm1 As New MySqlCommand(query1, con.conn)
            Dim dr1 As MySqlDataReader
            dr1 = comm1.ExecuteReader

            If dr1.Read And Not IsDBNull(dr1.Item(0)) Then
                credit_total_sale = CDbl(dr1.Item(0))
            Else
                credit_total_sale = 0
            End If
            'MsgBox(credit_total_sale.ToString)
            dr1.Close()
        Catch ex As Exception
            MsgBox("Error Occured ! Please Try Again !")
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            'DateTimePicker1.Enabled = False
            'DateTimePicker2.Enabled = False
            flag_for_month_end = True
        Else
            'DateTimePicker1.Enabled = True
            'DateTimePicker2.Enabled = True
            flag_for_month_end = False
        End If

    End Sub


    Private Sub month_end_summary()
        Try
            Dim col1, col2, col3, col4 As New DataGridViewTextBoxColumn
            con.connect()
            Dim query As String
            If TextBox1.Text <> "" Then
                query = "SELECT ITEM.ITEM_ID,ITEM.NAME,ITEM.SP FROM ITEM INNER JOIN SUPPLIER_MASTER WHERE ITEM.SUP_ID = '" + TextBox1.Text + "'"
            Else
                query = "SELECT ITEM_ID, NAME, SP FROM ITEM"
            End If

            Dim dr As MySqlDataReader
            Dim comm As New MySqlCommand(query, con.conn)
            dr = comm.ExecuteReader
            Dim i As Integer = 0
            Dim dtt As New DataTable
            dtt.Load(dr)
            DataGridView1.DataSource = dtt
            DataGridView1.Columns.Add(col4)
            col4.DataPropertyName = "Quantity Sold"
            col4.HeaderText = "Quantity Sold"
            col4.Name = "Quantity Sold"
            col4.Width = 95
            DataGridView1.Columns.Add(col2)
            col2.DataPropertyName = "Amount"
            col2.HeaderText = "Amount"
            col2.Name = "Amount"
            col2.Width = 95
            dr.Close()
            For a As Integer = 0 To DataGridView1.Rows.Count - 1
                'MsgBox(dr.Item(0))
                'MsgBox(DataGridView1.Rows(a).Cells(0).Value.ToString)
                Dim query1 As String = "SELECT SUM(QTY), SUM(QTY*(RATE)) FROM STUDENT_TAKES WHERE ITEM_ID = '" + DataGridView1.Rows(a).Cells(0).Value.ToString + "' and DOR >= '" + DateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss") + " ' AND DOR <= '" + DateTimePicker2.Value.ToString("yyyy-MM-dd HH:mm:ss") + "'"
                Dim dr1 As MySqlDataReader

                Dim comm1 As New MySqlCommand(query1, con.conn)
                dr1 = comm1.ExecuteReader
                'MsgBox(dr1)
                dr1.Read()
                If IsDBNull(dr1.Item(0)) Then
                    DataGridView1.Rows(a).Cells(3).Value = 0
                    DataGridView1.Rows(a).Cells(4).Value = 0
                Else
                    DataGridView1.Rows(a).Cells(3).Value = dr1.Item(0)
                    DataGridView1.Rows(a).Cells(4).Value = dr1.Item(1)
                End If

                dr1.Close()
            Next
            For n As Integer = 0 To DataGridView1.Columns.Count - 1
                Dim column As DataGridViewColumn = DataGridView1.Columns(n)
                column.Width = 72
            Next
            flag = 1
            calculate_Grand_sale()
        Catch ex As Exception
            MsgBox("Error! Please Try Again1!")
            MsgBox(ex.Message.ToString)
            Controls.Clear()
            InitializeComponent()
            ITEM_ID.Focus()
        End Try
    End Sub


    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            DateTimePicker1.Format = DateTimePickerFormat.Custom
            DateTimePicker1.CustomFormat = "dd - MM - yyyy / HH:mm:ss"
            DateTimePicker2.Format = DateTimePickerFormat.Custom
            DateTimePicker2.CustomFormat = "dd - MM - yyyy / HH:mm:ss"
            Try
                If TextBox1.Text <> "" Then
                    ITEM_ID.Enabled = False
                    DateTimePicker1.Focus()
                End If
                con.connect()
                Dim query As String = "Select * from Supplier_master where sup_id = '" + TextBox1.Text.ToString + "'"
                Dim comm As New MySqlCommand(query, con.conn)
                Dim dr As MySqlDataReader
                dr = comm.ExecuteReader
                If dr.Read() Then
                    sup_id = CInt(TextBox1.Text.ToString)
                Else
                    MsgBox("Error! No Such Supplier Found!")
                    RELOAD()

                End If
            Catch ex As Exception
                MsgBox("Error Occured ! Please Try Again!")
                MsgBox(ex.Message.ToString)
                Controls.Clear()
                InitializeComponent()
                TextBox1.Focus()
            End Try
        End If
    End Sub



End Class


