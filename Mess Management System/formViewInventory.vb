Imports MySql.Data.MySqlClient
Public Class formViewInventory
    Dim con As New connection 'Mysql Connection used through the Form
    Dim tableFont, titlefont, headfont As Font 'Used in Printing the Summary

    'Handles Enter Pressed on Item ID tb
    'If not Blank, fills datagrid up only for That Item
    'Else for all items
    Private Sub ITEM_ID_keydown(sender As Object, e As KeyEventArgs) Handles ITEM_ID.KeyDown
        If e.KeyCode = Keys.Enter Then
            If ITEM_ID.Text <> "" Then
                Try
                    con.connect()
                    Dim query As String = "SELECT ITEM.NAME, MESS_STORE.ITEM_ID, MESS_STORE.QTY FROM(ITEM, MESS_STORE) WHERE ITEM.ITEM_ID = MESS_STORE.ITEM_ID and mess_store.Item_id = '" + ITEM_ID.Text.ToString + "'"
                    Dim comm As New MySqlCommand(query, con.conn)
                    Dim dr As MySqlDataReader
                    dr = comm.ExecuteReader
                    Dim dt1 As New DataTable
                    dt1.Load(dr)
                    DataGridView1.DataSource = dt1
                    dr.Close()
                    ITEM_ID.Text = ""
                    ITEM_ID.Focus()
                Catch ex As Exception
                    MsgBox("Error Occured !! Please Try Again")
                    MsgBox(ex.Message.ToString)
                    ITEM_ID.Focus()
                    ITEM_ID.Text = ""
                End Try
            Else
                fill()
            End If
        End If
    End Sub

    'Fills the DataGrid with all the Items and its Current Quantity
    Private Sub fill()
        Try
            con.connect()
            Dim query As String = "SELECT ITEM.NAME, MESS_STORE.ITEM_ID, MESS_STORE.QTY FROM(ITEM, MESS_STORE) WHERE ITEM.ITEM_ID=MESS_STORE.ITEM_ID"
            Dim comm As New MySqlCommand(query, con.conn)
            Dim dr As MySqlDataReader
            dr = comm.ExecuteReader
            Dim dt As New DataTable
            dt.Load(dr)
            DataGridView1.DataSource = dt
            ITEM_ID.Focus()
            For n As Integer = 0 To 2
                Dim column As DataGridViewColumn = DataGridView1.Columns(n)
                column.Width = 111
            Next
        Catch ex As Exception
            MsgBox("Error Occured ! Please Try Again!")
            MsgBox(ex.Message.ToString)
            Controls.Clear()
            InitializeComponent()
            ITEM_ID.Focus()
        End Try
    End Sub

    'Handles various Keypresses on the Form
    Private Sub formViewInventory_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        ElseIf e.KeyCode = Keys.F12 Then
            fill()
        End If
    End Sub

    'On Form Load
    Private Sub formViewInventory_Load(sender As Object, e As EventArgs) Handles Me.Load
        fill()
        ITEM_ID.Focus()
        Me.KeyPreview = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        PrintDocument1.Print()
    End Sub

    Private Sub print_bill(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Try
            headfont = New Font("Courier New", 12, FontStyle.Bold)
            tableFont = New Font("Courier New", 10, FontStyle.Bold)
            Dim Datefont = New Font("Courier New", 7.5, FontStyle.Bold)
            e.Graphics.DrawString("INVENTORY STORE SUMMARY", headfont, Brushes.Black, 40, 0)
            e.Graphics.DrawString("************************", headfont, Brushes.Black, 40, 15)
            e.Graphics.DrawString(My.Settings.messName.ToString, tableFont, Brushes.Black, 55, 35)
            e.Graphics.DrawString(DateTime.Now.ToString, headfont, Brushes.Black, 55, 50)


            e.Graphics.DrawString("--------------------------------------", tableFont, Brushes.Black, -20, 65)
            e.Graphics.DrawString("--------------------------------------", tableFont, Brushes.Black, -20, 70)


            e.Graphics.DrawString("Item ID", tableFont, Brushes.Black, 0, 90)
            e.Graphics.DrawString("Item Name", tableFont, Brushes.Black, 80, 90)
            e.Graphics.DrawString("Qty", tableFont, Brushes.Black, 230, 90)

            For n As Integer = 0 To DataGridView1.Rows.Count - 1

                e.Graphics.DrawString(CStr(DataGridView1.Rows(n).Cells(1).Value), tableFont, Brushes.Black, 10, 110 + 20 * n)
                Dim item_name As String
                If CStr(DataGridView1.Rows(n).Cells(0).Value).Length > 12 Then
                    item_name = CStr(DataGridView1.Rows(n).Cells(0).Value).Substring(0, 3) + "..." + CStr(DataGridView1.Rows(n).Cells(0).Value).Substring(CStr(DataGridView1.Rows(n).Cells(0).Value).Length - 6, 6)
                Else
                    item_name = DataGridView1.Rows(n).Cells(0).Value
                End If
                e.Graphics.DrawString(item_name, tableFont, Brushes.Black, 80, 110 + 20 * n)
                e.Graphics.DrawString(CStr(DataGridView1.Rows(n).Cells(2).Value), tableFont, Brushes.Black, 240, 110 + 20 * n)
                'e.Graphics.DrawString(CStr(DataGridView1.Rows(n).Cells(4).Value), tableFont, Brushes.Black, 240, 110 + 20 * n)
            Next


        Catch ex As Exception
            MsgBox("Error Occured! Please Try Again!")
            MsgBox(ex.Message.ToString)

        End Try
    End Sub

End Class