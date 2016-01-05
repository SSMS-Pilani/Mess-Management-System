Imports MySql.Data.MySqlClient
Public Class formExtras
    Public maxbid, new_bid As Integer
    Dim conn As New connection  'Mysql Connection used through the Form
    Dim S As String 'For Current Quantity of an Item -> Gets Converted to INT when Comparing
    Dim j As Integer 'For no. of Transactions on a Bill
    Dim tableFont, titlefont, headfont As Font 'Used in Printing the Reciept
    Dim bill_no As Integer 'Current Bill No
    Dim PIT As Integer

    'On Form Load
    Private Sub formExtras_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'If My.Settings.messShortName = "" Then
        'MsgBox("Please First Update the Mess ShortName Settings")
        'S_ID.Enabled = False
        'End If
        Me.KeyPreview = True
        'GroupBox2.Enabled = False
            countdown.Text = 6
        countdown.Hide()

        If My.Settings.Query_ON = True Then
            Button2.BackColor = Color.DarkGreen

        Else
            Button2.BackColor = Color.Red

        End If
        'CheckBox1.Checked = My.Settings.Query_ON
        fill()
        S_ID.Focus()

        For n As Integer = 0 To DataGridView1.Columns.Count - 1
            Dim column As DataGridViewColumn = DataGridView1.Columns(n)
            column.Width = 75
        Next
    End Sub

    'Handles Various KeyPresses  
    Private Sub formExtras_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown 'Handles Key Presses 
        Select Case e.KeyCode
            Case Keys.PageUp
                RadioButton2.Checked = False
                RadioButton1.Checked = True
                fill()
            Case Keys.PageDown
                RadioButton1.Checked = False
                RadioButton2.Checked = True
                fill()
            Case Keys.F1
                formViewInventory.Show()
                'Form4.DataGridView1.Visible = False
                'Form4.Label1.Visible = False
            Case Keys.F2
                formViewStudents.Show()
            Case Keys.Escape
                Me.Close()
            Case Keys.F5
                reload()
            Case Is = Keys.F9
                formDeleteStudentTakes.Show()
            Case Is = Keys.F8
                Button1_Click(sender, e)
        End Select
    End Sub

    'Fills up the Main DataGrid of all the Transactions
    Public Sub fill()
        Try
            conn.connect()
            If RadioButton1.Checked = True And My.Settings.Query_ON = True Then
                'MsgBox(MonthCalendar1.SelectionRange.Start.Date.ToString)
                'MsgBox(MonthCalendar1.SelectionRange.Start.Date.ToString("dd-MM-yyyy"))
                Dim query As String = "SELECT student_takes.BILL_ID, student_takes.T_ID, student_takes.S_ID, item.NAME, student_takes.QTY, student_takes.DOR, student_takes.RATE, student_takes.E_ID, student_takes.TAX from student_takes INNER JOIN item ON item.ITEM_ID=student_takes.ITEM_ID where date_format(Date(DOR),'%d-%m-%Y') = '" + MonthCalendar1.SelectionRange.Start.Date.ToString("dd-MM-yyyy") + "' ORDER BY DOR desc LIMIT 50"
                Dim DR As MySqlDataReader
                Dim comm As New MySqlCommand(query, conn.conn)
                DR = comm.ExecuteReader()
                Dim DT As New DataTable
                DT.Load(DR)
                DataGridView1.DataSource = DT
                DR.Close()


            ElseIf RadioButton2.Checked = True And My.Settings.Query_ON = True Then
                Dim query As String = "SELECT student_takes.BILL_ID, student_takes.T_ID, student_takes.S_ID, item.NAME, student_takes.QTY, student_takes.DOR, student_takes.RATE, student_takes.E_ID, student_takes.TAX from student_takes INNER JOIN item ON item.ITEM_ID=student_takes.ITEM_ID where date_format(Date(DOR),'%d-%m-%Y') like '%" + MonthCalendar1.SelectionRange.Start.Month.ToString + "-" + MonthCalendar1.SelectionRange.Start.Year.ToString + "' ORDER BY DOR DESC"
                Dim DR As MySqlDataReader
                Dim comm As New MySqlCommand(query, conn.conn)
                DR = comm.ExecuteReader()
                Dim DT As New DataTable
                DT.Load(DR)
                DataGridView1.DataSource = DT
                DR.Close()
            End If
        Catch ex As MySqlException
            MsgBox("Error Occured! Please Try Again!")
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    'Refreshes the Form 
    Public Sub reload()
        Controls.Clear()
        InitializeComponent()
        formExtras_Load(Me, Nothing)
        S_ID.Focus()
        S_ID.Enabled = True
        'MsgBox(formControlP.query_on_session.ToString)
        fill()
        j = 1
        'If My.Settings.messShortName = "" Then
        'MsgBox("Please First Update the Mess ShortName Settings")
        'S_ID.Enabled = False
        'End If
    End Sub
    Dim hour As String = DateTime.Now.ToString("%H")
    Dim minute As String= DateTime.Now.ToString("%mm")


    

    'Handles Enter Pressed on S_ID
    Private Sub s_id_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles S_ID.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If S_ID.Text.Length = 5 Then
                S_ID.Text = "F20" + S_ID.Text + "P"
            ElseIf S_ID.Text.Length = 6 And (S_ID.Text.Contains("H") Or S_ID.Text.Contains("h")) Then
                S_ID.Text = S_ID.Text.Substring(0, 1) + "20" + S_ID.Text.Substring(1, 5) + "P"
            ElseIf S_ID.Text.Length = 6 And (S_ID.Text.Contains("P") Or S_ID.Text.Contains("p")) Then
                S_ID.Text = S_ID.Text.Substring(0, 1) + "20" + S_ID.Text.Substring(1, 5) + "P"
            End If
            If My.Settings.Cash_On = True Then

                If S_ID.Text <> "" Then

                    S_ID.SelectAll()
                    Try
                        conn.connect()
                        Dim query1 As String = "SELECT s_ID FROM STUDENT WHERE s_id = '" + S_ID.Text.ToString + "' and BLOCK = True"
                        Dim comm As New MySqlCommand(query1, conn.conn)
                        Dim block As MySqlDataReader
                        block = comm.ExecuteReader

                        If (block.Read) Then
                            MsgBox("THIS STUDENT HAS BEEN BLOCKED", , "ALERT!")
                            reload()
                            block.Close()
                        Else
                            Try
                                conn.connect()
                                Dim dr As MySqlDataReader
                                Dim query As String
                                query = "SELECT * FROM STUDENT WHERE S_ID='" + S_ID.Text.ToString + "'"
                                Dim comm2 As New MySqlCommand(query, conn.conn)
                                dr = comm2.ExecuteReader
                                If dr.Read() And Not IsDBNull(dr.Item(0))Then
                                    ID.Text = dr.Item("IDNO")
                                    SNAME.Text = dr.Item("NAME")
                                    ROOM.Text = dr.Item("ROOM")
                                    BHAWAN.Text = dr.Item("BHAWAN")
                                    PictureBox1.ImageLocation = "D:\PHOTOS\" + ID.Text.ToString.Remove(11, 1) + ".png"
                                    'GroupBox2.Enabled = True
                                    SendKeys.Send("{TAB}")
                                    e.Handled = True
                                    S_ID.ReadOnly = True
                                    ICODE1.Enabled = True
                                ElseIf IsDBNull(dr.Item(0)) Then
                                    MsgBox("Student Not Found!! Please Enter Proper S_ID")
                                    S_ID.Text = ""
                                    ID.Text = "INVALID"
                                    SNAME.Text = "INVALID"
                                    ROOM.Text = "INVALID"
                                    BHAWAN.Text = "INVALID"
                                    PictureBox1.Image = PictureBox1.ErrorImage
                                    block.Dispose()

                                End If

                            Catch de As MySqlException
                                MsgBox("Error Occured! Please Try Again!")
                                MsgBox(de.Message.ToString)
                                S_ID.Text = ""
                                ID.Text = "INVALID"
                                SNAME.Text = "INVALID"
                                ROOM.Text = "INVALID"
                                BHAWAN.Text = "INVALID"
                                PictureBox1.Image = PictureBox1.ErrorImage
                                block.Dispose()
                            End Try
                        End If
                    Catch ex As MySqlException
                        MsgBox("Error Occured ! Please try Again !")
                        MsgBox(ex.Message.ToString)
                    End Try
                Else
                    Try
                        conn.connect()
                        Dim query As String = "Select * from Student where S_ID = '" + My.Settings.Cash_ID.ToString + "'"
                        Dim comm As New MySqlCommand(query, conn.conn)
                        Dim dr As MySqlDataReader
                        dr = comm.ExecuteReader
                        If dr.Read Then
                            S_ID.Text = My.Settings.Cash_ID.ToString
                            SNAME.Text = "CASH"
                            SendKeys.Send("{TAB}")
                            e.Handled = True
                            S_ID.ReadOnly = True
                            ICODE1.Enabled = True
                        Else
                            MsgBox("Cash Cannot Work As CASH ACCOUNT HAS NOT BEEN ADDED")
                        End If
                    Catch ex As Exception
                        MsgBox("Error Occured! Please Try Again!")
                        MsgBox(ex.Message.ToString)
                        S_ID.Text = ""
                        S_ID.Focus()
                    End Try
                End If
            Else
                If S_ID.Text <> "" Then
                    S_ID.SelectAll()
                    Try
                        conn.connect()
                        Dim query1 As String = "SELECT s_ID FROM STUDENT WHERE s_id = '" + S_ID.Text.ToString + "' and BLOCK = True"
                        Dim comm As New MySqlCommand(query1, conn.conn)
                        Dim block As MySqlDataReader
                        block = comm.ExecuteReader

                        If (block.Read) Then
                            MsgBox("THIS STUDENT HAS BEEN BLOCKED", , "ALERT!")
                            reload()
                            block.Close()
                        Else
                            Try
                                conn.connect()
                                Dim dr As MySqlDataReader
                                Dim query As String
                                query = "SELECT * FROM STUDENT WHERE S_ID='" + S_ID.Text.ToString + "'"
                                Dim comm2 As New MySqlCommand(query, conn.conn)
                                dr = comm2.ExecuteReader
                                If dr.Read() And Not IsDBNull(dr.Item(0)) Then
                                    ID.Text = dr.Item("IDNO")
                                    SNAME.Text = dr.Item("NAME")
                                    ROOM.Text = dr.Item("ROOM")
                                    BHAWAN.Text = dr.Item("BHAWAN")
                                    pit2.text = dr.item("PIT")
                                    PictureBox1.ImageLocation = "D:\PHOTOS\" + ID.Text.ToString.Remove(11, 1) + ".png"
                                    'GroupBox2.Enabled = True
                                    SendKeys.Send("{TAB}")
                                    e.Handled = True
                                    S_ID.ReadOnly = True
                                End If

                                If IsDBNull(dr.Item(0)) Then
                                    MsgBox("Student Not Found!! Please Enter Proper S_ID")
                                    S_ID.Text = ""
                                    ID.Text = "INVALID"
                                    SNAME.Text = "INVALID"
                                    ROOM.Text = "INVALID"
                                    BHAWAN.Text = "INVALID"
                                    PictureBox1.Image = PictureBox1.ErrorImage
                                    block.Dispose()
                                End If
                                If pit2.Text = 1 Then
                                    ICODE1.Enabled = True
                                End If
                                If pit2.Text = 2 And hour > 0 Then
                                    ICODE1.Enabled = True
                                End If
                                If pit2.Text = 2 And hour < 0 Then

                                    MsgBox("Pit stop timings over")

                                End If

                            Catch de As MySqlException
                                MsgBox("Error Occured! Please Try Again!")
                                MsgBox(de.Message.ToString)
                                S_ID.Text = ""
                                ID.Text = "INVALID"
                                SNAME.Text = "INVALID"
                                ROOM.Text = "INVALID"
                                BHAWAN.Text = "INVALID"
                                PictureBox1.Image = PictureBox1.ErrorImage
                                block.Dispose()
                            End Try
                        End If
                    Catch ex As MySqlException
                        MsgBox("Error Occured ! Please try Again !")
                        MsgBox(ex.Message.ToString)
                    End Try
                Else
                    MsgBox("Enter Proper S_ID")
                End If
            End If
        End If
    End Sub

    'Handles KeyPress on Item 1 Code
    Private Sub ICODE1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ICODE1.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If ICODE1.Text <> "" And IsNumeric(ICODE1.Text) Then
                Try
                    conn.connect()
                    Dim query As String = "SELECT NAME,SP,TAX FROM ITEM WHERE ITEM_ID='" + ICODE1.Text + "'"
                    Dim dr As MySqlDataReader
                    Dim comm As New MySqlCommand(query, conn.conn)
                    dr = comm.ExecuteReader
                    dr.Read()
                    INAME1.Text = dr.Item("NAME")
                    PRICE1.Text = dr.Item("SP")
                    TAX1.Text = dr.Item("TAX")
                    QTY1.Text = 1
                    QTY1.Enabled = True
                    SendKeys.Send("{TAB}")
                    e.Handled = True
                    ICODE1.ReadOnly = True

                Catch DE As MySqlException
                    ICODE1.Text = ""
                    MsgBox("Error Occured ! Please Try Again!")
                    MsgBox(DE.Message.ToString)
                End Try
            Else
                MsgBox("Enter Proper ITEM_ID")
                ICODE1.Text = ""
            End If
        End If
    End Sub

    'Handles KeyPress on QTY 1 Code
    Private Sub QTY1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles QTY1.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If QTY1.Text <> "" And IsNumeric(QTY1.Text) Then
                Try
                    If Convert.ToInt32(QTY1.Text) > 0 Then
                        conn.connect()
                        Dim query As String = "SELECT QTY FROM MESS_STORE WHERE ITEM_ID=" + ICODE1.Text
                        Dim comm As New MySqlCommand(query, conn.conn)
                        S = comm.ExecuteScalar
                        If (Convert.ToInt32(S) >= Convert.ToInt32(QTY1.Text)) Then
                            'err1.Visible = False
                            ICODE2.Enabled = True
                            QTY1.HideSelection = True
                            SendKeys.Send("{TAB}")
                            e.Handled = True
                            QTY1.ReadOnly = True
                            j = 1
                            calc_sub_total()
                        Else
                            'err1.Visible = True
                            lblQtyInStore.Visible = True
                            curr_qty1.Visible = True
                            Try
                                curr_qty1.Text = S.ToString
                                QTY1.SelectAll()
                                QTY1.Text = ""
                            Catch ex As Exception
                                curr_qty1.Text = "0"
                            End Try
                            QTY1.SelectAll()
                            QTY1.Text = ""
                        End If
                    Else
                        QTY1.SelectAll()
                    End If
                Catch DE As MySqlException
                    QTY1.Text = ""
                    MsgBox("Error Occured! PleaseTry again!")
                    MsgBox(DE.Message.ToString)
                End Try
            Else
                MsgBox("Enter Proper Quantity")
                QTY1.SelectAll()
            End If
        End If
    End Sub

    'Refreshes the Elements
    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear.Click
        reload()
    End Sub

    'Handles KeyPress on Item 2 Code
    Private Sub ICODE2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ICODE2.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If ICODE2.Text = "" Then
                Confirm.Focus()
                e.Handled = True
                ICODE2.ReadOnly = True

            ElseIf ICODE2.Text <> "" And IsNumeric(ICODE2.Text) Then
                Try
                    conn.connect()
                    Dim query As String = "SELECT NAME,SP,TAX FROM ITEM WHERE ITEM_ID='" + ICODE2.Text + "'"
                    Dim dr As MySqlDataReader
                    Dim comm As New MySqlCommand(query, conn.conn)
                    dr = comm.ExecuteReader
                    dr.Read()
                    INAME2.Text = dr.Item("NAME")
                    PRICE2.Text = dr.Item("SP")
                    QTY2.Text = 1
                    TAX2.Text = dr.Item("TAX")
                    QTY2.Enabled = True
                    SendKeys.Send("{TAB}")
                    e.Handled = True
                    ICODE2.ReadOnly = True

                Catch DE As MySqlException
                    ICODE2.Text = ""
                    MsgBox("Error Occured ! Please Try Again!")
                    MsgBox(DE.Message.ToString)
                End Try
            Else
                MsgBox("Enter Proper Item_ID")
                ICODE2.Text = ""
            End If
        End If
    End Sub

    'Handles KeyPress on QTY2 
    Private Sub QTY2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles QTY2.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If QTY2.Text <> "" And IsNumeric(QTY2.Text) Then
                Try
                    If Convert.ToInt32(QTY2.Text) > 0 Then
                        conn.connect()
                        Dim query As String = "SELECT QTY FROM MESS_STORE WHERE ITEM_ID=" + ICODE2.Text
                        Dim comm As New MySqlCommand(query, conn.conn)
                        S = comm.ExecuteScalar
                        If (Convert.ToInt32(S) >= Convert.ToInt32(QTY2.Text)) Then
                            'err1.Visible = False
                            ICODE3.Enabled = True
                            QTY2.HideSelection = True
                            SendKeys.Send("{TAB}")
                            e.Handled = True
                            QTY2.ReadOnly = True
                            j = 2
                            calc_sub_total()
                        Else
                            'err1.Visible = True
                            lblQtyInStore.Visible = True
                            curr_qty2.Visible = True
                            Try
                                curr_qty2.Text = S.ToString
                                QTY2.SelectAll()
                                QTY2.Text = ""
                            Catch ex As Exception
                                curr_qty2.Text = "0"
                            End Try
                        End If
                    Else
                        QTY2.SelectAll()
                    End If
                Catch DE As MySqlException
                    QTY2.Text = ""
                    MsgBox(DE.Message.ToString)
                End Try
            Else
                MsgBox("Enter Proper Quantity")
                QTY2.SelectAll()
            End If
        End If
    End Sub

    'Handles KeyPress on Item 3 Code
    Private Sub ICODE3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ICODE3.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If ICODE3.Text = "" Then
                Confirm.Focus()
                e.Handled = True
                ICODE3.ReadOnly = True

            ElseIf ICODE3.Text <> "" And IsNumeric(ICODE1.Text) Then
                Try
                    conn.connect()
                    Dim query As String = "SELECT NAME,SP,TAX FROM ITEM WHERE ITEM_ID='" + ICODE3.Text + "'"
                    Dim dr As MySqlDataReader
                    Dim comm As New MySqlCommand(query, conn.conn)
                    dr = comm.ExecuteReader
                    dr.Read()
                    INAME3.Text = dr.Item("NAME")
                    PRICE3.Text = dr.Item("SP")
                    TAX3.Text = dr.Item("TAX")
                    QTY3.Text = 1
                    QTY3.Enabled = True
                    SendKeys.Send("{TAB}")
                    e.Handled = True
                    ICODE3.ReadOnly = True

                Catch DE As MySqlException
                    ICODE3.Text = ""
                    MsgBox("Error Occured ! Please Try Again!")
                    MsgBox(DE.Message.ToString)

                End Try
            Else
                MsgBox("Enter Proper ITEM_ID")
                ICODE3.Text = ""
            End If
        End If
    End Sub

    'Handles KeyPress on QTY3
    Private Sub QTY3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles QTY3.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If QTY3.Text <> "" And IsNumeric(QTY3.Text) Then
                Try
                    If Convert.ToInt32(QTY3.Text) > 0 Then
                        conn.connect()
                        Dim query As String = "SELECT QTY FROM MESS_STORE WHERE ITEM_ID=" + ICODE3.Text
                        Dim comm As New MySqlCommand(query, conn.conn)
                        S = comm.ExecuteScalar
                        If (Convert.ToInt32(S) >= Convert.ToInt32(QTY3.Text)) Then
                            'err1.Visible = False
                            ICODE4.Enabled = True
                            QTY3.HideSelection = True
                            SendKeys.Send("{TAB}")
                            e.Handled = True
                            QTY3.ReadOnly = True
                            j = 3
                            calc_sub_total()
                        Else
                            'err1.Visible = True
                            QTY3.SelectAll()
                            QTY3.Text = ""
                            lblQtyInStore.Visible = True
                            curr_qty3.Visible = True
                            Try
                                curr_qty3.Text = S.ToString
                                QTY3.SelectAll()
                                QTY3.Text = ""
                            Catch ex As Exception
                                curr_qty3.Text = "0"
                            End Try
                        End If
                    Else
                        QTY3.SelectAll()

                    End If
                Catch DE As MySqlException
                    QTY3.Text = ""
                    MsgBox(DE.Message.ToString)
                End Try
            Else
                MsgBox("Enter Proper Quantity")
                QTY3.SelectAll()
            End If
        End If
    End Sub

    'Handles KeyPress on Item 4 Code
    Private Sub ICODE4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ICODE4.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If ICODE4.Text = "" Then
                Confirm.Focus()
                e.Handled = True
                ICODE4.ReadOnly = True

            ElseIf ICODE4.Text <> "" And IsNumeric(ICODE4.Text) Then
                Try
                    conn.connect()
                    Dim query As String = "SELECT NAME,SP,TAX FROM ITEM WHERE ITEM_ID='" + ICODE4.Text + "'"
                    Dim dr As MySqlDataReader
                    Dim comm As New MySqlCommand(query, conn.conn)
                    dr = comm.ExecuteReader
                    dr.Read()
                    INAME4.Text = dr.Item("NAME")
                    PRICE4.Text = dr.Item("SP")
                    TAX4.Text = dr.Item("TAX")
                    QTY4.Text = 1
                    QTY4.Enabled = True
                    SendKeys.Send("{TAB}")
                    e.Handled = True
                    ICODE4.ReadOnly = True

                Catch DE As MySqlException
                    ICODE4.Text = ""
                    MsgBox("Error Occured ! Please Try Again!")
                    MsgBox(DE.Message.ToString)
                End Try
            Else
                MsgBox("Enter Proper ITEM_ID")
                ICODE4.Text = ""
            End If
        End If
    End Sub

    'Handles KeyPress on QTY4
    Private Sub QTY4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles QTY4.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If QTY4.Text <> "" And IsNumeric(QTY4.Text) Then
                Try
                    If Convert.ToInt32(QTY4.Text) > 0 Then
                        conn.connect()
                        Dim query As String = "SELECT QTY FROM MESS_STORE WHERE ITEM_ID=" + ICODE4.Text
                        Dim comm As New MySqlCommand(query, conn.conn)
                        S = comm.ExecuteScalar
                        If (Convert.ToInt32(S) >= Convert.ToInt32(QTY4.Text)) Then
                            'err1.Visible = False
                            ICODE5.Enabled = True
                            QTY4.HideSelection = True
                            SendKeys.Send("{TAB}")
                            e.Handled = True
                            QTY4.ReadOnly = True
                            j = 4
                            calc_sub_total()
                        Else
                            'err1.Visible = True
                            lblQtyInStore.Visible = True
                            curr_qty4.Visible = True
                            Try
                                curr_qty4.Text = S.ToString
                                QTY4.SelectAll()
                                QTY4.Text = ""
                            Catch ex As Exception
                                curr_qty4.Text = "0"
                            End Try
                            QTY4.SelectAll()
                            QTY4.Text = ""
                        End If
                    Else
                        QTY4.SelectAll()
                    End If
                Catch DE As MySqlException
                    QTY4.Text = ""
                    MsgBox(DE.Message.ToString)
                End Try
            Else
                MsgBox("Enter Proper Quantity")
                QTY4.SelectAll()
            End If
        End If
    End Sub

    'Handles KeyPress on Item 5 Code
    Private Sub ICODE5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ICODE5.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If ICODE5.Text = "" Then
                Confirm.Focus()
                e.Handled = True
                ICODE5.ReadOnly = True

            ElseIf ICODE5.Text <> "" And IsNumeric(ICODE5.Text) Then
                Try
                    conn.connect()
                    Dim query As String = "SELECT NAME,SP,TAX FROM ITEM WHERE ITEM_ID='" + ICODE5.Text + "'"
                    Dim dr As MySqlDataReader
                    Dim comm As New MySqlCommand(query, conn.conn)
                    dr = comm.ExecuteReader
                    dr.Read()
                    INAME5.Text = dr.Item("NAME")
                    PRICE5.Text = dr.Item("SP")
                    TAX5.Text = dr.Item("TAX")
                    QTY5.Text = 1
                    QTY5.Enabled = True
                    SendKeys.Send("{TAB}")
                    e.Handled = True
                    ICODE5.ReadOnly = True

                Catch DE As MySqlException
                    ICODE5.Text = ""
                    MsgBox("Error Occured ! Please Try Again!")
                    MsgBox(DE.Message.ToString)

                End Try
            Else
                MsgBox("Enter Proper Item_ID")
                ICODE5.Text = ""

            End If
        End If
    End Sub

    'Handles KeyPress on QTY5
    Private Sub QTY5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles QTY5.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If QTY5.Text <> 0 And IsNumeric(QTY5.Text) Then
                Try
                    If Convert.ToInt32(QTY5.Text) > 0 Then
                        conn.connect()
                        Dim query As String = "SELECT QTY FROM MESS_STORE WHERE ITEM_ID=" + ICODE5.Text
                        Dim comm As New MySqlCommand(query, conn.conn)
                        S = comm.ExecuteScalar
                        If (Convert.ToInt32(S) >= Convert.ToInt32(QTY5.Text)) Then
                            'err1.Visible = False
                            'ICODE4.Enabled = True
                            QTY5.HideSelection = True
                            SendKeys.Send("{TAB}")
                            e.Handled = True
                            QTY5.ReadOnly = True
                            j = 5
                            calc_sub_total()
                        Else
                            'err1.Visible = True
                            lblQtyInStore.Visible = True
                            curr_qty5.Visible = True
                            Try
                                curr_qty5.Text = S.ToString
                                QTY5.SelectAll()
                                QTY5.Text = ""
                            Catch ex As Exception
                                curr_qty5.Text = "0"
                            End Try
                            QTY5.SelectAll()
                            QTY5.Text = ""
                        End If
                    Else
                        QTY5.SelectAll()
                    End If
                Catch DE As MySqlException
                    QTY5.Text = ""
                    MsgBox(DE.Message.ToString)
                End Try
            Else
                MsgBox("Enter Proper Quantity")
                QTY5.SelectAll()
            End If
        End If
    End Sub


    Private Sub Confirm_Click(sender As Object, e As EventArgs) Handles Confirm.Click
        If S_ID.Text = My.Settings.Cash_ID Then
            Dim myNum As Double

            Try

                myNum = InputBox("Enter Cash given : ")
                If CDbl(myNum) < CDbl(Sub_total.Text) Then
                    MsgBox("Cash Insufficient!!")
                    Me.Confirm_Click(sender, e)
                Else
                    MsgBox("Return Rs. " + CStr(CDbl(myNum) - CDbl(Sub_total.Text)) + " ")
                    billing()
                End If

            Catch
                MsgBox("Please input proper Cash given!.")
                Me.reload()
            End Try
        Else
            billing()
        End If
    End Sub

    'Handles the Final Entry into DB
    'First Sees the MAX BILL_ID to deicde the current BILL_ID
    'And Inserts this Queries accordingly
    Public Sub billing()
        Try
            'MsgBox(Format(Today.Date, "yyyy-MM").ToString)

            'Dim inter_query1 As String = "Select sum(QTY*(RATE*(1+(TAX/100)))) from student_takes where S_ID = '" + S_ID.Text + "' and DOR like '%" + Format(Today.Date, "yyyy-MM").ToString + "%'"
            'Dim inter_query2 As String = "Select CAP from monthly_cap where S_ID = '" + S_ID.Text + "' and Month_year = '" + Format(Today.Date, "yyyy-MM").ToString + "-00'"
            'Dim inter_comm2 As New MySqlCommand(inter_query2, conn.conn)
            'Dim inter_comm1 As New MySqlCommand(inter_query1, conn.conn)
            'Dim curr_tot As Double
            'Dim cap As Double

            'If Not IsDBNull(inter_comm1.ExecuteScalar) Then
            'curr_tot = inter_comm1.ExecuteScalar
            'Else
            'curr_tot = 0
            'End If


            Dim final_query As String
            'If (curr_tot + CInt(Sub_total.Text) <= cap) Or (curr_tot <= cap And curr_tot = 0) Then

            Dim query As String = "SELECT MAX(BILL_ID) FROM STUDENT_TAKES"
            Try
                conn.connect()
                Dim comm As New MySqlCommand(query, conn.conn)
                Dim dr As MySqlDataReader = comm.ExecuteReader
                Dim i, k As Integer
                dr.Read()
                If Not IsDBNull(dr.Item(0)) Then
                    i = dr.Item(0)
                Else
                    i = 0
                End If
                dr.Close()
                query = "Select MAX(BILL_ID) FROM STUDENT_TAKES_DELETE"
                Dim commk As New MySqlCommand(query, conn.conn)
                Dim dr2 As MySqlDataReader
                dr2 = commk.ExecuteReader
                dr2.Read()
                If Not IsDBNull(dr2.Item(0)) Then
                    k = dr2.Item(0)
                Else
                    k = 0
                End If
                dr2.Close()
                If i < k Then
                    maxbid = k
                Else
                    maxbid = i
                End If
                new_bid = maxbid + 1
                If j >= 1 Then
                    final_query = "INSERT INTO STUDENT_TAKES(BILL_ID,T_ID,S_ID,E_ID,ITEM_ID,QTY,RATE,TAX) VALUES('" + new_bid.ToString + "','" + "1','" + S_ID.Text.ToString + "','" + formControlP.Logged_User + "','" + ICODE1.Text.ToString + "','" + QTY1.Text.ToString + "','" + PRICE1.Text.ToString + "','" + TAX1.Text.ToString + "')"
                    Dim comm1 As New MySqlCommand(final_query, conn.conn)
                    comm1.ExecuteNonQuery()
                End If
                If j >= 2 Then
                    final_query = "INSERT INTO STUDENT_TAKES(BILL_ID,T_ID,S_ID,E_ID,ITEM_ID,QTY,RATE,TAX) VALUES('" + new_bid.ToString + "','" + "2','" + S_ID.Text.ToString + "','" + formControlP.Logged_User + "','" + ICODE2.Text.ToString + "','" + QTY2.Text.ToString + "','" + PRICE2.Text.ToString + "','" + TAX2.Text.ToString + "')"
                    Dim comm2 As New MySqlCommand(final_query, conn.conn)
                    comm2.ExecuteNonQuery()
                End If
                If j >= 3 Then
                    final_query = "INSERT INTO STUDENT_TAKES(BILL_ID,T_ID,S_ID,E_ID,ITEM_ID,QTY,RATE,TAX) VALUES('" + new_bid.ToString + "','" + "3','" + S_ID.Text.ToString + "','" + formControlP.Logged_User + "','" + ICODE3.Text.ToString + "','" + QTY3.Text.ToString + "','" + PRICE3.Text.ToString + "','" + TAX3.Text.ToString + "')"
                    Dim comm3 As New MySqlCommand(final_query, conn.conn)
                    comm3.ExecuteNonQuery()
                End If
                If j >= 4 Then
                    final_query = "INSERT INTO STUDENT_TAKES(BILL_ID,T_ID,S_ID,E_ID,ITEM_ID,QTY,RATE,TAX) VALUES('" + new_bid.ToString + "','" + "4','" + S_ID.Text.ToString + "','" + formControlP.Logged_User + "','" + ICODE4.Text.ToString + "','" + QTY4.Text.ToString + "','" + PRICE4.Text.ToString + "','" + TAX4.Text.ToString + "')"
                    Dim comm4 As New MySqlCommand(final_query, conn.conn)
                    comm4.ExecuteNonQuery()
                End If
                If j >= 5 Then
                    final_query = "INSERT INTO STUDENT_TAKES(BILL_ID,T_ID,S_ID,E_ID,ITEM_ID,QTY,RATE,TAX) VALUES('" + new_bid.ToString + "','" + "5','" + S_ID.Text.ToString + "','" + formControlP.Logged_User + "','" + ICODE5.Text.ToString + "','" + QTY5.Text.ToString + "','" + PRICE5.Text.ToString + "','" + TAX5.Text.ToString + "')"
                    Dim comm5 As New MySqlCommand(final_query, conn.conn)
                    comm5.ExecuteNonQuery()
                End If
                PrintDocument1.Print()
                Me.Focus()
                'Me.reload()
                Me.reload()
                j = 1
            Catch ex As MySqlException
                MsgBox("Error Occured ! Please Try Again! 1")
                MsgBox(ex.Message.ToString)
            End Try
            'Else
            'MsgBox("Current Cap : " + cap.ToString)
            'MsgBox("ErroR !! The MONTHLY CAP WILL GET EXCEEDED !!")
            'MsgBox("Last Bill NOT EXCECUTED !!")
            'reload()
            'End If
        Catch ex As MySqlException
            MsgBox("Error Occured!! Please Try Again! 1")
            MsgBox(ex.Message.ToString)
            reload()
        End Try
    End Sub

    'for Showing the Delete Order Form
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        formDeleteStudentTakes.Show()
    End Sub

    'Fills it up for Month-wise
    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        fill()
    End Sub

    'Fills it up for Month-wise
    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        fill()
    End Sub

    'Fills it up for Day-wise
    Private Sub MonthCalendar1_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        fill()
    End Sub

    'Prints the Current Bill
    
            Private Sub print_bill(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim dat As String
        Dim tot As Double
        Dim sid As String = S_ID.Text.ToString
        dat = Now.Day.ToString + "/" + Now.Month.ToString + "/" + Now.Year.ToString + "     " + Now.Hour.ToString + ":" + Now.Minute.ToString + ":" + Now.Second.ToString
        Try
            headfont = New Font("Courier New", 12, FontStyle.Bold)
            tableFont = New Font("Courier New", 10, FontStyle.Bold)
            e.Graphics.DrawString(My.Settings.messName.ToString, headfont, Brushes.Black, 90, 0)
            e.Graphics.DrawString("*****************", headfont, Brushes.Black, 90, 15)
            e.Graphics.DrawString("BILL NO. : " + new_bid.ToString, tableFont, Brushes.Black, 30, 35)
            e.Graphics.DrawString("ID No:" + ID.Text, tableFont, Brushes.Black, 200, 35)
            e.Graphics.DrawString(dat, tableFont, Brushes.Black, 0, 50)
            e.Graphics.DrawString("EMP No: " + formControlP.Logged_User.ToString, tableFont, Brushes.Black, 200, 50)

            e.Graphics.DrawString("----------------------------------------------", tableFont, Brushes.Black, -20, 65)
            e.Graphics.DrawString("----------------------------------------------", tableFont, Brushes.Black, -20, 70)
            e.Graphics.DrawString("SNo", tableFont, Brushes.Black, 0, 90)
            e.Graphics.DrawString("Item Name", tableFont, Brushes.Black, 30, 90)
            e.Graphics.DrawString("Rate", tableFont, Brushes.Black, 190, 90)
            e.Graphics.DrawString("Qty", tableFont, Brushes.Black, 240, 90)
            e.Graphics.DrawString("Tax(%)", tableFont, Brushes.Black, 270, 90)
            e.Graphics.DrawString("Amount", tableFont, Brushes.Black, 320, 90)

            e.Graphics.DrawString("1", tableFont, Brushes.Black, 0, 115)
            Dim item_name As String
            If CStr(INAME1.text).Length > 10 Then
                item_name = CStr(INAME1.text).Substring(0, 3) + "..." + CStr(INAME1.text).Substring(CStr(INAME1.text).Length - 6, 6)
            Else
                item_name = INAME1.text

            End If
            e.Graphics.DrawString(item_name, tableFont, Brushes.Black, 30, 115)
            e.Graphics.DrawString(PRICE1.Text, tableFont, Brushes.Black, 190, 115)
            e.Graphics.DrawString(QTY1.Text, tableFont, Brushes.Black, 240, 115)
            e.Graphics.DrawString(TAX1.Text, tableFont, Brushes.Black, 270, 115)
            e.Graphics.DrawString(Convert.ToString(CDbl(PRICE1.Text) * (1 + (TAX1.Text) / 100) * CDbl(QTY1.Text)), tableFont, Brushes.Black, 320, 115)

            If (ICODE2.Text = "") Then
                e.Graphics.DrawString("----------------------------------------------", tableFont, Brushes.Black, -20, 130)
                conn.connect()
                e.Graphics.DrawString("Bill Grand Total : " + Sub_total.Text, tableFont, Brushes.Black, 140, 145)
                Dim query As String = "select sum(QTY*(RATE*(1+(TAX/100)))) from student_takes where date_format(Date(DOR),'%d-%m-%Y') like '%" + MonthCalendar1.SelectionRange.Start.Month.ToString + "-" + MonthCalendar1.SelectionRange.Start.Year.ToString + "'" + "and s_id='" + sid + "'"
                Dim comm As New MySqlCommand(query, conn.conn)
                tot = comm.ExecuteScalar
                e.Graphics.DrawString("TOTAL " + My.Settings.Extras_Location + " EXTRAS FOR THIS MONTH : " + tot.ToString, tableFont, Brushes.Black, 0, 160)
                e.Graphics.DrawString("VALID THROUGH THE MEAL", tableFont, Brushes.Black, 70, 175)
                e.Graphics.DrawString("Thank You !! Have Fun !!", tableFont, Brushes.Black, 70, 190)
            Else
                If CStr(INAME2.text).Length > 10 Then
                    item_name = CStr(INAME2.text).Substring(0, 3) + "..." + CStr(INAME2.text).Substring(CStr(INAME2.text).Length - 6, 6)
                Else
                    item_name = INAME2.text
                End If








                e.Graphics.DrawString("2", tableFont, Brushes.Black, 0, 130)
                e.Graphics.DrawString(item_name, tableFont, Brushes.Black, 30, 130)
                e.Graphics.DrawString(PRICE2.Text, tableFont, Brushes.Black, 190, 130)
                e.Graphics.DrawString(QTY2.Text, tableFont, Brushes.Black, 240, 130)
                e.Graphics.DrawString(TAX1.Text, tableFont, Brushes.Black, 270, 130)
                e.Graphics.DrawString(Convert.ToString(CDbl(PRICE2.Text) * (1 + (TAX2.Text) / 100) * CDbl(QTY2.Text)), tableFont, Brushes.Black, 320, 130)


            End If






            If (ICODE3.Text = "") Then
                e.Graphics.DrawString("--------------------------------------------", tableFont, Brushes.Black, -20, 145)
                conn.connect()
                e.Graphics.DrawString("Bill Grand Total : " + Sub_total.Text, tableFont, Brushes.Black, 140, 160)
                Dim query As String = "select sum(QTY*(RATE*(1+(TAX/100)))) from student_takes where date_format(Date(DOR),'%d-%m-%Y') like '%" + MonthCalendar1.SelectionRange.Start.Month.ToString + "-" + MonthCalendar1.SelectionRange.Start.Year.ToString + "'" + "and s_id='" + sid + "'"
                Dim comm As New MySqlCommand(query, conn.conn)
                tot = comm.ExecuteScalar
                e.Graphics.DrawString("TOTAL  " + My.Settings.Extras_Location + "  EXTRAS FOR THIS MONTH : " + tot.ToString, tableFont, Brushes.Black, 0, 175)
                e.Graphics.DrawString("VALID THROUGH THE MEAL", tableFont, Brushes.Black, 70, 190)
                e.Graphics.DrawString("Thank You !! Have Fun !!", tableFont, Brushes.Black, 70, 205)
            Else

                If CStr(INAME3.text).Length > 10 Then
                    item_name = CStr(INAME3.text).Substring(0, 3) + "..." + CStr(INAME3.text).Substring(CStr(INAME3.text).Length - 6, 6)
                Else
                    item_name = INAME3.text
                End If



                e.Graphics.DrawString("3", tableFont, Brushes.Black, 0, 145)
                e.Graphics.DrawString(item_name, tableFont, Brushes.Black, 30, 145)
                e.Graphics.DrawString(PRICE3.Text, tableFont, Brushes.Black, 190, 145)
                e.Graphics.DrawString(QTY3.Text, tableFont, Brushes.Black, 240, 145)
                e.Graphics.DrawString(TAX1.Text, tableFont, Brushes.Black, 270, 145)
                e.Graphics.DrawString(Convert.ToString(CDbl(PRICE3.Text) * (1 + (TAX3.Text) / 100) * CDbl(QTY3.Text)), tableFont, Brushes.Black, 320, 145)
            End If



            If (ICODE4.Text = "") Then
                e.Graphics.DrawString("--------------------------------------------", tableFont, Brushes.Black, -20, 160)
                conn.connect()
                e.Graphics.DrawString("Bill Grand Total : " + Sub_total.Text, tableFont, Brushes.Black, 140, 175)
                Dim query As String = "select sum(QTY*(RATE*(1+(TAX/100)))) from student_takes where date_format(Date(DOR),'%d-%m-%Y') like '%" + MonthCalendar1.SelectionRange.Start.Month.ToString + "-" + MonthCalendar1.SelectionRange.Start.Year.ToString + "'" + "and s_id='" + sid + "'"
                Dim comm As New MySqlCommand(query, conn.conn)
                tot = comm.ExecuteScalar
                e.Graphics.DrawString("TOTAL  " + My.Settings.Extras_Location + "  EXTRAS FOR THIS MONTH : " + tot.ToString, tableFont, Brushes.Black, 0, 190)
                e.Graphics.DrawString("VALID THROUGH THE MEAL", tableFont, Brushes.Black, 70, 205)
                e.Graphics.DrawString("Thank You !! Have Fun !!", tableFont, Brushes.Black, 70, 220)
            Else
                If CStr(INAME4.text).Length > 10 Then
                    item_name = CStr(INAME4.text).Substring(0, 3) + "..." + CStr(INAME4.text).Substring(CStr(INAME4.text).Length - 6, 6)
                Else
                    item_name = INAME4.text

                End If
                e.Graphics.DrawString("4", tableFont, Brushes.Black, 0, 160)
                e.Graphics.DrawString(item_name, tableFont, Brushes.Black, 30, 160)
                e.Graphics.DrawString(PRICE4.Text, tableFont, Brushes.Black, 190, 160)
                e.Graphics.DrawString(QTY4.Text, tableFont, Brushes.Black, 240, 160)
                e.Graphics.DrawString(TAX1.Text, tableFont, Brushes.Black, 270, 160)
                e.Graphics.DrawString(Convert.ToString(CDbl(PRICE4.Text) * (1 + (TAX4.Text) / 100) * CDbl(QTY4.Text)), tableFont, Brushes.Black, 320, 160)
            End If


            If (ICODE5.Text = "") Then
                e.Graphics.DrawString("--------------------------------------------", tableFont, Brushes.Black, -20, 175)
                conn.connect()
                Dim query As String = "select sum(QTY*(RATE*(1+(TAX/100)))) from student_takes where date_format(Date(DOR),'%d-%m-%Y') like '%" + MonthCalendar1.SelectionRange.Start.Month.ToString + "-" + MonthCalendar1.SelectionRange.Start.Year.ToString + "'" + "and s_id='" + sid + "'"
                Dim comm As New MySqlCommand(query, conn.conn)
                tot = comm.ExecuteScalar
                e.Graphics.DrawString("Bill Grand Total : " + Sub_total.Text, tableFont, Brushes.Black, 140, 190)
                e.Graphics.DrawString("TOTAL  " + My.Settings.Extras_Location + "  EXTRAS FOR THIS MONTH : " + tot.ToString, tableFont, Brushes.Black, 0, 205)
                e.Graphics.DrawString("VALID THROUGH THE MEAL", tableFont, Brushes.Black, 70, 220)
                e.Graphics.DrawString("Thank You !! Have Fun !!", tableFont, Brushes.Black, 70, 235)
            Else
                If CStr(INAME5.text).Length > 10 Then
                    item_name = CStr(INAME5.Text).Substring(0, 3) + "..." + CStr(INAME5.Text).Substring(CStr(INAME5.Text).Length - 6, 6)
                Else
                    item_name = INAME5.text
                End If

                e.Graphics.DrawString("5", tableFont, Brushes.Black, 0, 175)
                e.Graphics.DrawString(item_name, tableFont, Brushes.Black, 30, 175)
                e.Graphics.DrawString(PRICE5.Text, tableFont, Brushes.Black, 190, 175)
                e.Graphics.DrawString(QTY5.Text, tableFont, Brushes.Black, 240, 175)
                e.Graphics.DrawString(TAX1.Text, tableFont, Brushes.Black, 270, 175)
                e.Graphics.DrawString(Convert.ToString(CDbl(PRICE5.Text) * (1 + (TAX5.Text) / 100) * CDbl(QTY5.Text)), tableFont, Brushes.Black, 320, 175)

                e.Graphics.DrawString("--------------------------------------------", tableFont, Brushes.Black, -20, 190)
                conn.connect()

                e.Graphics.DrawString("Bill Grand Total : " + Sub_total.Text, tableFont, Brushes.Black, 140, 205)
                Dim query As String = "select sum(QTY*(RATE*(1+(TAX/100)))) from student_takes where date_format(Date(DOR),'%d-%m-%Y') like '%" + MonthCalendar1.SelectionRange.Start.Month.ToString + "-" + MonthCalendar1.SelectionRange.Start.Year.ToString + "'" + "and s_id='" + sid + "'"
                Dim comm As New MySqlCommand(query, conn.conn)
                tot = comm.ExecuteScalar
                e.Graphics.DrawString("TOTAL  " + My.Settings.Extras_Location + "  EXTRAS FOR THIS MONTH : " + tot.ToString, tableFont, Brushes.Black, 0, 220)
                e.Graphics.DrawString("VALID THROUGH THE MEAL", tableFont, Brushes.Black, 70, 235)
                e.Graphics.DrawString("Thank You !! Have Fun !!", tableFont, Brushes.Black, 70, 250)
            End If



            Me.Focus()
            'Me.reload()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        countdown.Text = countdown.Text - 2
    End Sub

    'Works only When Module Settings are Changed Accordingly
    Private Sub S_ID_TextChanged(sender As Object, e As EventArgs) Handles S_ID.TextChanged
        If My.Settings.by_scanner_only = True Then
            If S_ID.Text.Length = 0 Then
                Timer1.Stop()
                countdown.Text = 6
            End If
            If S_ID.Text.Length = 1 Then
                countdown.Text = 6
                Timer1.Start()
            End If
            If S_ID.Text.Length >= 5 Then
                Timer1.Stop()
                If countdown.Text <= 0 Then
                    MessageBox.Show("Kindly enter using Scanner", "Error!")
                    S_ID.Text = ""
                    S_ID.Focus()
                End If
            End If
        End If
    End Sub


    Private Sub calc_sub_total()
        Dim subtotal As Double
        If ICODE1.Text <> "" Then
            subtotal = QTY1.Text * (PRICE1.Text * (1 + (TAX1.Text / 100)))
            If ICODE2.Text <> "" Then
                subtotal = subtotal + QTY2.Text * (PRICE2.Text * (1 + (TAX2.Text / 100)))
                If ICODE3.Text <> "" Then
                    subtotal = subtotal + QTY3.Text * (PRICE3.Text * (1 + (TAX3.Text / 100)))
                    If ICODE4.Text <> "" Then
                        subtotal = subtotal + QTY4.Text * (PRICE4.Text * (1 + (TAX4.Text / 100)))
                        If ICODE5.Text <> "" Then
                            subtotal = subtotal + QTY5.Text * (PRICE5.Text * (1 + (TAX5.Text / 100)))
                        End If
                    End If
                End If
            End If
        End If

        Sub_total.Text = subtotal.ToString
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)
        'If CheckBox1.Checked = False Then
        My.Settings.Query_ON = False
        'MsgBox("a")
        DataGridView1.DataSource = Nothing
        S_ID.Focus()
        ' ElseIf CheckBox1.Checked = True Then
        My.Settings.Query_ON = True
        'End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim no As String
            no = InputBox("Enter Bill No. to be printed : ")

            If no = "" Then
                bill_no = 0
                PrintDocument2.Print()
            Else
                conn.connect()
                bill_no = CInt(no)
                Dim query1 As String = "Select count(*) from student_takes where bill_id = '" + bill_no.ToString + "'"
                Dim comm1 As New MySqlCommand(query1, conn.conn)
                Dim n As Integer = comm1.ExecuteScalar
                If n = 0 Then
                    MsgBox("No such Bill No Found ! Please Try Again!")
                Else
                    PrintDocument2.Print()
                End If

            End If

        Catch ex As Exception
            MsgBox("Enter Proper Bill No. !")
            MsgBox(ex.Message.ToString)
            S_ID.Focus()
        End Try
    End Sub


    Private Sub print_specific_bill(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument2.PrintPage
        conn.connect()
        'MsgBox("Hii1")
        'MsgBox(n.ToString)
        If bill_no = 0 Then
            Dim query As String = "Select MAX(BILL_ID) from student_takes"
            Dim comm3 As New MySqlCommand(query, conn.conn)
            Dim maz As Integer = comm3.ExecuteScalar
            MsgBox(maz.ToString)
            bill_no = maz
        Else
        End If
        Dim query1 As String = "Select count(*) from student_takes where bill_id = '" + bill_no.ToString + "'"
        Dim comm1 As New MySqlCommand(query1, conn.conn)
        Dim n As Integer = comm1.ExecuteScalar

        If n = 0 Then
            MsgBox("Error ! No Such Bill Found!")
            reload()
        Else

            Try
                'MsgBox("Hii2")
                headfont = New Font("Courier New", 12, FontStyle.Bold)
                tableFont = New Font("Courier New", 10, FontStyle.Bold)
                e.Graphics.DrawString(My.Settings.messName.ToString, headfont, Brushes.Black, 90, 0)
                e.Graphics.DrawString("*****************", headfont, Brushes.Black, 90, 15)
                e.Graphics.DrawString("BILL NO. : " + bill_no.ToString, tableFont, Brushes.Black, 30, 35)

                e.Graphics.DrawString("----------------------------------------------", tableFont, Brushes.Black, -20, 65)
                e.Graphics.DrawString("----------------------------------------------", tableFont, Brushes.Black, -20, 70)
                e.Graphics.DrawString("SNo", tableFont, Brushes.Black, 0, 90)
                e.Graphics.DrawString("Item Name", tableFont, Brushes.Black, 30, 90)
                e.Graphics.DrawString("Rate", tableFont, Brushes.Black, 190, 90)
                e.Graphics.DrawString("Qty", tableFont, Brushes.Black, 240, 90)
                'e.Graphics.DrawString("Tax(%)", tableFont, Brushes.Black, 270, 90)
                e.Graphics.DrawString("Amount", tableFont, Brushes.Black, 320, 90)
                'MsgBox("Hii3")
                Dim query3 As String
                query3 = "SELECT student_takes.BILL_ID,student.idno, student_takes.t_id, student_takes.e_id,item.name,student_takes.qty,student_takes.rate, student_takes.dor, student_takes.s_id FROM student_takes inner join item on student_takes.item_id = item.item_id inner join student on student_takes.s_id = student.s_id and student_takes.bill_id = '" + bill_no.ToString + "'"
                Dim dr As MySqlDataReader
                Dim comm As New MySqlCommand(query3, conn.conn)
                dr = comm.ExecuteReader
                Dim no As Integer = 0
                Dim sid2 As String
                Dim sum1 As Double
                Dim date1 As String
                'MsgBox("Hii4")
                While dr.Read
                    sid2 = dr.Item(8)
                    date1 = dr.Item(7)
                    e.Graphics.DrawString(CStr(CInt(no) + 1), tableFont, Brushes.Black, 0, 110 + 15 * no)
                    e.Graphics.DrawString(dr.Item(4).ToString, tableFont, Brushes.Black, 30, 110 + 15 * no)
                    e.Graphics.DrawString(dr.Item(6), tableFont, Brushes.Black, 190, 110 + 15 * no)
                    e.Graphics.DrawString(dr.Item(5), tableFont, Brushes.Black, 240, 110 + 15 * no)
                    'e.Graphics.DrawString(TAX1.Text, tableFont, Brushes.Black, 270, 130)
                    e.Graphics.DrawString(Convert.ToString(dr.Item(6) * dr.Item(5)), tableFont, Brushes.Black, 320, 110 + 15 * no)
                    sum1 = sum1 + dr.Item(6) * dr.Item(5)
                    no = no + 1
                    'e.Graphics.DrawString(Convert.ToString(CDbl(PRICE2.Text) * (1 + (TAX2.Text) / 100) * CDbl(QTY2.Text)), tableFont, Brushes.Black, 320, 130)
                End While

                e.Graphics.DrawString(dr.Item(7), tableFont, Brushes.Black, 0, 50)
                e.Graphics.DrawString("ID No:" + dr.Item(1), tableFont, Brushes.Black, 200, 35)

                e.Graphics.DrawString("EMP No: " + dr.Item(3).ToString, tableFont, Brushes.Black, 200, 50)

                e.Graphics.DrawString("--------------------------------------------", tableFont, Brushes.Black, -20, 120 + 15 * no)
                conn.connect()

                e.Graphics.DrawString("Bill Grand Total : " + sum1.ToString, tableFont, Brushes.Black, 140, 135 + 15 * no)
                Dim query2 As String = "select sum(QTY*(RATE)) from student_takes where date_format(Date(DOR),'%d-%m-%Y') like '%" + MonthCalendar1.SelectionRange.Start.Month.ToString + "-" + MonthCalendar1.SelectionRange.Start.Year.ToString + "'" + " and s_id = '" + S_ID.text + "'"
                Dim comm2 As New MySqlCommand(query2, conn.conn)
                Dim tot2 As Integer = comm2.ExecuteScalar
                e.Graphics.DrawString("TOTAL  " + My.Settings.Extras_Location + "  EXTRAS FOR THIS MONTH : " + tot2.ToString, tableFont, Brushes.Black, 0, 150 + +15 * no)
                e.Graphics.DrawString("VALID THROUGH THE MEAL", tableFont, Brushes.Black, 70, 165 + 15 * no)
                e.Graphics.DrawString("Thank You !! Have Fun !!", tableFont, Brushes.Black, 70, 180 + 15 * no)

            Catch ex As Exception
                MsgBox("Error! Please Try again")
                MsgBox(ex.Message.ToString)
            End Try
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If My.Settings.Query_ON = False Then
            Button2.BackColor = Color.DarkGreen
            My.Settings.Query_ON = True
        Else
            Button2.BackColor = Color.Red
            My.Settings.Query_ON = False
        End If
    End Sub
End Class
