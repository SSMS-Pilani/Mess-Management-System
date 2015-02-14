Imports MySql.Data.MySqlClient
Public Class formIndentEntry
    Dim dt1 As New DataTable 'Datatable for Current Order Table
    Dim C As Int16 = 0 'Checks if The Header Row is added or not
    Dim conn As New connection 'Mysql COnnection used through the Form
    Public newbid As Integer 'New Bill_ID for the Current Entry

    'On Form Load
    Public Sub formIndentEntry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        If C = 0 Then
            dt1.Columns.Add("T_ID")
            dt1.Columns.Add("Supplier Name")
            dt1.Columns.Add("Item ID")
            dt1.Columns.Add("Item Name")
            dt1.Columns.Add("QTY")
            DataGridView2.DataSource = dt1
            C = 1
        End If
        Bill_IdTB.Focus()
        fill()
        Me.KeyPreview = True
        For n As Integer = 0 To 5
            Dim column As DataGridViewColumn = DataGridView1.Columns(n)
            column.Width = 175
        Next
    End Sub

    'Handles Various KeyPresses
    Private Sub formIndentEntry_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If

        If e.KeyCode = Keys.F1 Then
            'formShowInventory.Show() ' Shows the Inventory
        End If
        Select Case e.KeyCode
            Case Is = Keys.F5
                reload() ' Clear all the fields and Get Ready Once again
            Case Is = Keys.F9
                formDeleteMessTakes.Show()
        End Select


    End Sub

    'Fill the Main Datagrid with the Proper Data of all the Orders till now
    Public Sub fill()
        Try
            conn.connect()
            Dim query As String = "select * from Mess_Takes ORDER BY DOR DESC"
            Dim DR As MySqlDataReader
            Dim comm As New MySqlCommand(query, conn.conn)
            DR = comm.ExecuteReader()
            Dim DT As New DataTable
            DT.Load(DR)
            DataGridView1.DataSource = DT
            DR.Close()
        Catch ex As MySqlException
            MsgBox("Error Occured! Please Try Again")
            MsgBox(ex.Message.ToString)
            reload()
        End Try
    End Sub

    'Handles KeyPress on BILL_IDTb
    Private Sub BillID_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Bill_IdTB.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If

        Select Case e.KeyCode
            Case Is = Keys.Enter
                If Bill_IdTB.Text = "" Then
                    MsgBox("Enter Proper Bill ID")
                Else
                    Supp_IdTB.Focus()
                    Bill_IdTB.ReadOnly = True
                End If
            Case Is = Keys.F9
                formDeleteMessTakes.Show()
        End Select
    End Sub

    'Handles KeyPress on SUpplier_IDTb
    Private Sub Supp_ID_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Supp_IdTB.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If

        Select Case e.KeyCode
            Case Is = Keys.Enter
                If Supp_IdTB.Text = "" Then
                    If dt1.Rows.Count > 0 Then
                        Confirm_O.Focus()
                    Else
                        MsgBox("Enter Proper Supp_ID")
                    End If
                Else
                    Try
                        conn.connect()
                        Dim query As String = "Select * from supplier_master where sup_id = '" + Supp_IdTB.Text.ToString + "'"
                        Dim comm As New MySqlCommand(query, conn.conn)
                        Dim dr As MySqlDataReader
                        dr = comm.ExecuteReader
                        If dr.Read() Then
                            Supp_IdTB.ReadOnly = True
                            Item_IdTB.Focus()
                            lblSuppName.Text = dr.Item("NAME")
                        Else
                            MsgBox("Supplier Id doesnot exists!! Enter Proper values")
                            dr.Close()
                            Supp_IdTB.Text = ""

                        End If
                    Catch ex As MySqlException
                        MsgBox("Error Occured ! Please Try Again !")
                        MsgBox(ex.Message.ToString)
                    End Try
                End If
            Case Is = Keys.F9
                formDeleteMessTakes.Show()
        End Select
    End Sub

    'Handles KeyPress on Item_IDTb
    Private Sub item_ID_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Item_IdTB.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If

        Select Case e.KeyCode
            Case Is = Keys.Enter
                If Item_IdTB.Text = "" Then
                    MsgBox("Enter Proper Item_ID")
                Else
                    Try
                        conn.connect()
                        Dim query As String = "Select * from item where item_id = '" + Item_IdTB.Text.ToString + "'"
                        Dim comm As New MySqlCommand(query, conn.conn)
                        Dim dr As MySqlDataReader
                        dr = comm.ExecuteReader
                        If dr.Read() Then
                            Item_IdTB.ReadOnly = True
                            QtyTB.Focus()
                            lblItem_Name.Text = dr.Item("NAME")
                        Else
                            MsgBox("Item Id doesnot exists!! Enter Proper values")
                            dr.Close()
                            Item_IdTB.Text = ""
                        End If
                        dr.Close()
                        Dim query1 As String = "Select QTY from mess_store where item_id = '" + Item_IdTB.Text.ToString + "'"
                        Dim comm1 As New MySqlCommand(query1, conn.conn)
                        Dim dr1 As MySqlDataReader
                        dr1 = comm1.ExecuteReader
                        If dr1.Read() Then
                            lblCurr_Qty.Text = dr1.Item(0)
                        Else
                            MsgBox("Item has not been added in Store!!")
                            dr.Close()
                        End If

                    Catch ex As MySqlException
                        MsgBox("Error Occured ! Please Try Again !")
                        MsgBox(ex.Message.ToString)
                    End Try
                End If
            Case Is = Keys.F9
                formDeleteMessTakes.Show()
        End Select
    End Sub

    'Handles KeyPress on QTY-Tb
    Private Sub Qty_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles QtyTB.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
        Select Case e.KeyCode
            Case Is = Keys.Enter
                If QtyTB.Text = "" Or Not IsNumeric(QtyTB.Text) Then
                    MsgBox("Enter Proper Qty")
                    QtyTB.Text = ""

                Else
                    Confirm_T.Focus()
                    QtyTB.ReadOnly = True
                End If
            Case Is = Keys.F9
                formDeleteMessTakes.Show()
        End Select
    End Sub

    'Refreshes the Elements And Cancels the Current Transaction(Not Order)
    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Supp_IdTB.Text = ""
        Supp_IdTB.ReadOnly = False
        Item_IdTB.Text = ""
        Item_IdTB.ReadOnly = False
        lblItem_Name.Text = ""
        QtyTB.Text = ""
        QtyTB.ReadOnly = False
        lblSuppName.Text = ""
        Supp_IdTB.Focus()
        'dt1.Rows.Clear()
    End Sub

    '
    Private Sub Confirm_T_Click(sender As Object, e As EventArgs) Handles Confirm_T.Click
        dt1.LoadDataRow(New Object() {Supp_IdTB.Text, lblSuppName.Text, Item_IdTB.Text, lblItem_Name.Text, QtyTB.Text}, True)
        Cancel_Click(sender, e)
        Supp_IdTB.Focus()
    End Sub

    'Handles the Order Confirmation
    'Inserts all the Current Transactions into the DB
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Confirm_O.Click
        Try

            conn.connect()
            Dim newtid, maxtid, t1, t2 As Integer
            Dim query1 As String = "SELECT MAX(T_ID) FROM MESS_TAKES"
            Dim comm1 As New MySqlCommand(query1, conn.conn)
            Dim dr, dr2 As MySqlDataReader
            dr = comm1.ExecuteReader
            dr.Read()
            'MsgBox("1")
            If IsDBNull(dr.Item(0)) Then
                t1 = 1
            Else
                t1 = dr.Item(0)
            End If
            dr.Close()
            'MsgBox("2")
            Dim query2 As String = "SELECT MAX(T_ID) FROM MESS_TAKES_DELETE"
            Dim comm2 As New MySqlCommand(query2, conn.conn)
            dr2 = comm2.ExecuteReader
            dr2.Read()
            'MsgBox("3")
            If IsDBNull(dr2.Item(0)) Then
                t2 = 0
            Else
                t2 = dr2.Item(0)
            End If
            dr2.Close()
            'MsgBox("4")
            If t1 > t2 Then
                maxtid = t1
            Else
                maxtid = t2
            End If
            Dim query As String
            For i = 0 To (dt1.Rows.Count - 1)
                newtid = maxtid + i + 1
                'MsgBox("5")
                'MsgBox(newtid.ToString)
                'MsgBox(formControlP.Logged_User.ToString)
                query = "INSERT INTO mess_takes(T_ID,Bill_No,ITEM_ID,E_ID,QTY) VALUES('" + newtid.ToString + "','" + Bill_IdTB.Text.ToString + "','" + dt1.Rows(i).Item(2).ToString + "','" + formControlP.Logged_User.ToString + "','" + dt1.Rows(i).Item(4).ToString + "')"
                Dim comm As New MySqlCommand(query, conn.conn)
                'MsgBox("6")
                comm.ExecuteNonQuery()
            Next
            'MsgBox("7")
            reload()
        Catch ex As Exception
            MsgBox("Error !! Please Try Again!")
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    'Hard Refreshes the Form
    Private Sub reload()
        Supp_IdTB.Text = ""
        Supp_IdTB.ReadOnly = False
        Item_IdTB.Text = ""
        Item_IdTB.ReadOnly = False
        lblItem_Name.Text = ""
        QtyTB.Text = ""
        QtyTB.ReadOnly = False
        lblSuppName.Text = ""
        Bill_IdTB.Text = ""
        Bill_IdTB.ReadOnly = False
        fill()
        dt1.Rows.Clear()
        Bill_IdTB.Focus()
    End Sub

    'Opens the Delete Entry Form
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Delete_Entry.Click
        formDeleteMessTakes.Show()
    End Sub

End Class