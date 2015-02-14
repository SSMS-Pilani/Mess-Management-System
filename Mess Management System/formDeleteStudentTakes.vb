Imports MySql.Data.MySqlClient
Public Class formDeleteStudentTakes 'Form For Deletion of Orders in Extras
    Dim flag As Integer 'Sees if T_ID is empty
    Dim tot_T_id As Integer 'Stores number of T_ids for a Particular BILL_NO if T_ID is empty
    Dim con As New connection 'Mysql Connection used thourhg the Form


    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Me.Close() 'For Closing the Form
    End Sub


    Private Sub formDeleteStudentTakes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.KeyPreview = True 'To ensure that KeyPress works | Don't Remove. KeyPress for the Form Won't Work
        Bill_ID.Focus()
    End Sub

    'Handles KeyPresses on BIll_No Texbox. And Handles the Appropriate Queries
    Private Sub BIll_Id_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Bill_ID.KeyPress
        If Asc(e.KeyChar) = Keys.Escape Then
            Me.Close()
        End If
        If Asc(e.KeyChar) = Keys.Enter Then
            Try
                con.connect()

                'See if the Bill_ID entered Exists or else Show an Error
                Dim query As String = "Select * from Student_takes where Bill_Id = '" + Bill_ID.Text.ToString + "'"
                Dim comm As New MySqlCommand(query, con.conn)
                Dim dr As MySqlDataReader
                dr = comm.ExecuteReader
                If dr.Read Then
                    If DateDiff(DateInterval.Day, dr.Item("DOR"), Today.Date) <= My.Settings.Max_Days_Delete_Entries Then
                        T_ID.Enabled = True
                        MsgBox("Deleting Entry for BILL NO : " + Bill_ID.Text.ToString)
                        T_ID.Focus()
                    Else
                        MsgBox("Bills from Last " + My.Settings.Max_Days_Delete_Entries.ToString + " days can only be deleted!!")
                        Bill_ID.Text = ""
                    End If
                Else
                    MsgBox("Enter Proper Bill_ID")
                    Bill_ID.Text = ""
                End If
            Catch ex As MySqlException
                MsgBox("Error Occured ! Please Try Again !")
                MsgBox(ex.Message.ToString)
                Me.Close()
            End Try
        End If
    End Sub

    'Handles KeyPresses on T_ID Texbox. And Handles the Appropriate Queries
    Private Sub T_ID_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles T_ID.KeyPress
        If Asc(e.KeyChar) = Keys.Escape Then
            Me.Close()
        End If

        If Asc(e.KeyChar) = Keys.Enter Then
            If T_ID.Text <> "" Then
                Try
                    'Check if the Transaction ID exists for the Given Bill_ID and T_ID or Else Show An Error
                    con.connect()
                    Dim query As String = "Select * from Student_takes where Bill_Id = '" + Bill_ID.Text.ToString + "' and T_ID = '" + T_ID.Text.ToString + "'"
                    Dim comm As New MySqlCommand(query, con.conn)
                    Dim dr As MySqlDataReader
                    dr = comm.ExecuteReader
                    If dr.Read Then
                        T_ID.Enabled = False
                        T_ID.ReadOnly = True
                        Bill_ID.Enabled = False
                        Bill_ID.ReadOnly = True
                        Description.Enabled = True
                        Description.Focus()
                    Else
                        MsgBox("Enter Proper T_ID")
                        T_ID.Text = ""
                    End If
                Catch ex As MySqlException
                    MsgBox("Error Occured ! Please try Again ! ")
                    MsgBox(ex.Message.ToString)
                End Try

            Else
                Try
                    'Check if the Transaction ID exists for the Given Bill_ID and T_ID or Else Show An Error
                    con.connect()
                    Dim query As String = "Select count(t_id) from Student_takes where Bill_Id = '" + Bill_ID.Text.ToString + "'"
                    Dim comm As New MySqlCommand(query, con.conn)
                    Dim dr As MySqlDataReader
                    dr = comm.ExecuteReader
                    If dr.Read Then
                        T_ID.Enabled = False
                        T_ID.ReadOnly = True
                        Bill_ID.Enabled = False
                        Bill_ID.ReadOnly = True
                        Description.Enabled = True
                        Description.Focus()
                        MsgBox("The Bill has " + dr.Item(0).ToString + " transactions. All these will be Deleted !")
                        tot_T_id = dr.Item(0)
                        flag = 1
                    End If
                Catch ex As MySqlException
                    MsgBox("Error Occured ! Please try Again ! ")
                    MsgBox(ex.Message.ToString)
                End Try
            End If
        End If
    End Sub

    'Handles KeyPresses on Description Texbox
    Private Sub Description_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Description.KeyPress
        If Asc(e.KeyChar) = Keys.Escape Then
            Me.Close()
        End If
        If Asc(e.KeyChar) = Keys.Enter Then
            Confirm.Focus()
        End If
    End Sub

    'Runs the Delete Student_takes and Update Student_takes_delete Queries
    Private Sub Confirm_Click(sender As Object, e As EventArgs) Handles Confirm.Click

        If flag = 0 Then
            Dim query As String = "DELETE FROM STUDENT_TAKES WHERE BILL_ID = '" + Bill_ID.Text + "' AND T_ID = '" + T_ID.Text + "'"
            Dim query2 As String = "UPDATE STUDENT_TAKES_DELETE SET DESCRIPTION = '" + Description.Text.ToString + "', E_ID_DELETE = '" + formControlP.Logged_User.ToString + "' where BILL_ID = '" + Bill_ID.Text + "' And T_ID = '" + T_ID.Text + "'"
            Try
                'Query1 For Deleting the Entry from Student_takes. -> Trigger in the DB works and Inserts the Reqd Data into Student_takes_delete
                con.connect()
                Dim comm As New MySqlCommand(query, con.conn)

                comm.ExecuteNonQuery()

                'Query2 for Updating the Description and E_ID_Delete in Student_takes_delete
                Dim comm2 As New MySqlCommand(query2, con.conn)
                comm2.ExecuteNonQuery()

                'Confirm that it is Delete
                MsgBox("Transaction Deleted")


                formExtras.reload()
                Controls.Clear()
                InitializeComponent()
                Me.Close()
                Bill_ID.Focus()
            Catch ex As MySqlException
                MsgBox("Error Occured ! Please Try Again !")
                MsgBox(ex.Message.ToString)
            End Try
        Else
            For i As Integer = 0 To tot_T_id - 1
                Dim query As String = "DELETE FROM STUDENT_TAKES WHERE BILL_ID = '" + Bill_ID.Text + "' AND T_ID = '" + (i + 1).ToString + "'"
                Dim query2 As String = "UPDATE STUDENT_TAKES_DELETE SET DESCRIPTION = '" + Description.Text.ToString + "', E_ID_DELETE = '" + formControlP.Logged_User.ToString + "' where BILL_ID = '" + Bill_ID.Text + "' And T_ID = '" + (i + 1).ToString + "'"
                Try
                    'Query1 For Deleting the Entry from Student_takes. -> Trigger in the DB works and Inserts the Reqd Data into Student_takes_delete
                    con.connect()
                    Dim comm As New MySqlCommand(query, con.conn)

                    comm.ExecuteNonQuery()

                    'Query2 for Updating the Description and E_ID_Delete in Student_takes_delete
                    Dim comm2 As New MySqlCommand(query2, con.conn)
                    comm2.ExecuteNonQuery()

                    'Confirm that it is Delete
                    MsgBox("Transaction Deleted")


                Catch ex As MySqlException
                    MsgBox("Error Occured ! Please Try Again !")
                    MsgBox(ex.Message.ToString)
                End Try
            Next
            formExtras.reload()
            Controls.Clear()
            InitializeComponent()
            Me.Close()
        End If
    End Sub

End Class