Imports MySql.Data.MySqlClient
Public Class formItemDelete
    'Dim flag As Integer
    Dim con As New connection 'Mysql Connection used through the Form

    'On Form Load
    Private Sub formItemDelete_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
    End Sub

    'Refreshes the Form Content
    Public Sub reload()
        Controls.Clear()
        InitializeComponent()
        tbItemId.Focus()
    End Sub

    'For Key Events on Form Itself
    Private Sub formItemDelete_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    'Handles Enter and F12 on Item ID Tb
    Private Sub tbItemId_KeyDown(sender As Object, e As KeyEventArgs) Handles tbItemId.KeyDown
        'Checks if Item ID exists in the DB
        If e.KeyValue = Keys.Enter Then
            If tbItemId.Text = "" Then
                MsgBox("Item ID cannot be empty !!")
            Else
                Try
                    con.connect()
                    Dim query As String = "Select * from ITEM where ITEM_ID = '" + tbItemId.Text.ToString + "'"
                    Dim dr As MySqlDataReader
                    Dim comm As New MySqlCommand(query, con.conn)
                    dr = comm.ExecuteReader()
                    'If Item ID exists, Proceed
                    'Else Show an Error
                    If dr.Read Then
                        proceedAndEnable(sender, Description)
                        dr.Close()
                    Else
                        MsgBox("Item Doesnot exists ! Enter proper Values")
                        reload()
                        dr.Close()
                    End If
                    dr.Close()
                    '
                Catch ex As MySqlException
                    MsgBox("Error ! Check the Database Connection/Query")
                    MsgBox(ex.Message.ToString)
                End Try
            End If
        ElseIf e.KeyValue = Keys.F12 Then
            reload()
        End If
    End Sub

    'Handles the KeyPress on Description
    Private Sub Description_KeyDown(sender As Object, e As KeyEventArgs) Handles Description.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            enterToTab(sender, e)
        End If
    End Sub

    'Handles The Delete Query on Item
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If tbItemId.Text = "" Then
            MsgBox("Item ID cannot be empty !!")
        Else
            Try
                con.connect()
                Dim query = "DELETE FROM ITEM WHERE ITEM_ID ='" + tbItemId.Text.ToString + "'"
                Dim comm2 As New MySqlCommand(query, con.conn)
                comm2.ExecuteNonQuery()
                reload()
                MsgBox("Item Deleted !!")
                formAddItem.reload()
                Me.Close()
            Catch ex As MySqlException
                MsgBox("Error ! Problem with Executing the Query ")
                MsgBox(ex.Message.ToString)
                Me.reload()
            End Try
        End If
    End Sub

    'For Closing the Form
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

End Class