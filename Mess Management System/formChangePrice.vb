Imports MySql.Data.MySqlClient
Public Class formChangePrice
    Dim con As New connection 'Mysql connection used through the Form

    'On Form Load
    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tbItem_ID.Focus()
        Me.KeyPreview = True
    End Sub

    'Refreshes the Form Elements
    Private Sub reload()
        Controls.Clear()
        InitializeComponent()
        tbItem_ID.Focus()
    End Sub

    'Handles Enter KeyEvent on Item ID
    Private Sub tbItem_ID_KeyDown(sender As Object, e As KeyEventArgs) Handles tbItem_ID.KeyDown
        If e.KeyCode = Keys.Enter Then
            If tbItem_ID.Text <> "" Then
                Try
                    con.connect()
                    Dim query As String = "Select Name,SP,Tax from Item where Item_ID = '" + tbItem_ID.Text.ToString + "'"
                    Dim comm As New MySqlCommand(query, con.conn)
                    Dim dr As MySqlDataReader
                    dr = comm.ExecuteReader

                    'Checks if Item is Present in DB with the Given Item ID
                    'If Yes, Fill the Various TBs with Proper Values
                    'Else Show an Error
                    If dr.Read Then
                        tbItem_Name.Text = dr.Item(0)
                        tb_O_SP.Text = dr.Item(1)
                        tb_O_Tax.Text = dr.Item(2)
                        tbItem_ID.ReadOnly = True
                        proceedAndEnable(sender, tb_N_SP)
                    Else
                        MsgBox("Item not Found ! Please Enter Proper Values")
                        reload()
                    End If
                Catch ex As Exception
                    MsgBox("Error Occured ! Please Try Again !")
                    MsgBox(ex.Message.ToString)
                    reload()
                End Try
            End If
        End If
    End Sub

    'Handles Cancel Clicked
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    'Handles Esc and F12 Pressed
    Private Sub formChangePrice_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        ElseIf e.KeyCode = Keys.F12 Then
            Me.reload()
        End If
    End Sub

    'Handles Tb_New_SP Keypress
    Private Sub tb_N_SP_KeyDown(sender As Object, e As KeyEventArgs) Handles tb_N_SP.KeyDown
        If e.KeyCode = Keys.Enter Then
            If tb_N_SP.Text <> "" And IsNumeric(tb_N_SP.Text) Then
                'proceedAndEnable(sender, tb_N_Tax)
                Confirm.Focus()
                tb_N_SP.Enabled = False
                tb_N_Tax.Text = "0"
            Else
                MsgBox("Enter Proper Values!")
                tb_N_SP.Text = ""
            End If
        End If
    End Sub

    'Handles Tb_New_Tax Keypress
    Private Sub tb_N_Tax_KeyDown(sender As Object, e As KeyEventArgs) Handles tb_N_Tax.KeyDown
        If e.KeyCode = Keys.Enter Then
            If tb_N_Tax.Text <> "" And IsNumeric(tb_N_Tax.Text) Then
                proceedAndEnable(sender, Confirm)
            Else
                MsgBox("Enter Proper Values!")
                tb_N_Tax.Text = ""
            End If
        End If
    End Sub

    'Handles Confirm Click and Executes Update Query
    Private Sub Confirm_Click(sender As Object, e As EventArgs) Handles Confirm.Click
        Try
            con.connect()
            Dim query As String = "UPDATE ITEM SET SP ='" + tb_N_SP.Text.ToString + "', TAX = '" + tb_N_Tax.Text.ToString + "' WHERE ITEM_ID = '" + tbItem_ID.Text.ToString + "'"
            Dim comm As New MySqlCommand(query, con.conn)
            comm.ExecuteNonQuery()
            MsgBox("Values Changed!")
            reload()
        Catch ex As Exception
            MsgBox("Error Occured ! Please Try Again")
            MsgBox(ex.Message.ToString)
            reload()
        End Try
    End Sub
End Class