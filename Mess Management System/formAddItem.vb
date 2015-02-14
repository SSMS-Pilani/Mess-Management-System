Imports MySql.Data.MySqlClient
Public Class formAddItem
    Dim con As New connection 'Used when Insert Queries for E_ID in other Forms

    'On Form Load -> Fills the DataGrid with Present Items and Takes Cursor to Item_ID TB
    Private Sub formAddItem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        fill()
        tbItemId.Focus()
    End Sub

    'For KeyPresses of Refresh(F5) and Closure(Esc) of Form
    Private Sub frmAddItem_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F5 Then
            Controls.Clear()
            reload()
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    'Handles Enter Pressed 
    Private Sub tbItemId_KeyDown(sender As Object, e As KeyEventArgs) Handles tbItemId.KeyDown

        'Searches Given Item ID in the DB and checks if it is already present in there
        If e.KeyCode = Keys.Enter And tbItemId.Text <> "" Then
            Dim query As String = "SELECT * FROM ITEM WHERE ITEM_ID = '" + tbItemId.Text.ToString + "'"
            Dim dr As MySqlDataReader
            Try
                con.connect()
                Dim comm As New MySqlCommand(query, con.conn)
                dr = comm.ExecuteReader()

                'If Item ID Already exists, raises that error otherwise proceeds ahead
                If dr.Read() Then
                    MsgBox("ITEM ID Already exists!! Try other one !!")
                    tbItemId.Text = ""
                    tbItemId.Focus()
                Else
                    proceedAndEnable(sender, tbItemName)
                    Return
                End If
                dr.Close()

                'Catch exceptions With DB or Queries
            Catch ex As MySqlException
                MsgBox("Error Occurred ! Please Try Again !")
                MsgBox(ex.Message.ToString)
                tbItemId.Text = ""
                tbItemId.Focus()
            End Try
        End If
    End Sub

    'Handles Enter Press on Item Name
    Private Sub tbItemName_KeyDown(sender As Object, e As KeyEventArgs) Handles tbItemName.KeyDown
        If e.KeyCode = Keys.Enter Then
            proceedAndEnable(sender, tbSuppID)
        End If
    End Sub

    'Handles Enter Press on Supplier ID
    Private Sub tbSuppID_KeyDown(sender As Object, e As KeyEventArgs) Handles tbSuppID.KeyDown

        'Searches Given Item ID in the DB and checks if it is already present in there
        'If e.KeyCode = Keys.Enter And proceedAndEnable(tbSuppID, tbSP) Then

        If e.KeyCode = Keys.Enter And tbSuppID.Text <> "" Then
            Try
                con.connect()
                Dim query As String = "SELECT NAME FROM SUPPLIER_MASTER where Sup_ID = '" + tbSuppID.Text.ToString + "'"
                Dim comm As New MySqlCommand(query, con.conn)
                Dim dr As MySqlDataReader
                dr = comm.ExecuteReader
                dr.Read()
                'Checks if Supplier ID exists. If yes, Puts its Name in Proper TB or Else Shows an error
                If Not IsDBNull(dr.Item(0)) Then
                    tbSuppName.Text = dr.Item(0).ToString
                    proceedAndEnable(tbSuppID, tbSP)
                    Return
                End If
                'If Supplier Not Found, Raises an Error 
            Catch ex As MySqlException
                MsgBox("Supplier not Found. Enter A vaild Supplier ID ", , "Error!")
                MsgBox(ex.Message.ToString)
                tbSuppID.Text = ""
                enable(tbSuppID)
                disable(tbSP)
                tbSuppID.Focus()
            End Try
        End If
    End Sub
    
    'Handles Enter Press on tbSP
    Private Sub tbSP_KeyDown(sender As Object, e As KeyEventArgs) Handles tbSP.KeyDown
        If e.KeyCode = Keys.Enter Then
            'proceedAndEnable(sender, tbTax)
            tbTax.Text = "0"
            tbTax_KeyDown(sender, e)
            tbSP.Enabled = False
            Confirm.Enabled = True

        End If
    End Sub

    'Handles Enter Press on tbTax
    Private Sub tbTax_KeyDown(sender As Object, e As KeyEventArgs) Handles tbTax.KeyDown
        If e.KeyCode = Keys.Enter Then
            proceedAndEnable(sender, Confirm)
        End If
    End Sub

    'Executes Insert Query for Adding Item and Fills the Updated Table
    Private Sub Confirm_Click(sender As Object, e As EventArgs) Handles Confirm.Click
        Try
            con.connect()
            Dim query As String = "INSERT INTO ITEM(ITEM_ID,NAME,SUP_ID,SP,TAX) VALUES('" + tbItemId.Text.ToString + "','" + tbItemName.Text.ToString + "','" + tbSuppID.Text.ToString + "','" + tbSP.Text.ToString + "','" + tbTax.Text.ToString + "')"
            Dim comm As New MySqlCommand(query, con.conn)
            comm.ExecuteNonQuery()
            reload()
        Catch ex As Exception
            MsgBox("Error occured ! Please Try Again !")
            MsgBox(ex.Message.ToString)
        End Try

    End Sub

    'Handles Click on Cancel
    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    'Fills up the DataGridView with all Items
    Public Sub fill()
        Try
            Dim query As String = "select * from item order by item_id desc"
            Dim dr As MySqlDataReader
            con.connect()
            Dim comm As New MySqlCommand(query, con.conn)
            dr = comm.ExecuteReader
            Dim DT As New DataTable
            DT.Load(dr)
            DataGridView1.DataSource = DT
            dr.Close()
        Catch ex As MySqlException
            MsgBox("Error Occured ! Please Try again!")
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    'Refreshes the Form
    Public Sub reload()
        tbItemId.Focus()
        Controls.Clear()
        InitializeComponent()
        fill()
        tbItemId.Focus()
    End Sub

    'Opens the Form for Deleting an Item
    Private Sub buttonDelete_Click(sender As Object, e As EventArgs) Handles buttonDelete.Click
        formItemDelete.Show()
    End Sub

    'Handles the KeyPresses on the Form
    Private Sub formAddItem_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        ElseIf e.KeyCode = Keys.F12 Then
            Me.reload()
        ElseIf e.KeyCode = Keys.F9 Then
            formItemDelete.Show()
        End If
    End Sub


End Class