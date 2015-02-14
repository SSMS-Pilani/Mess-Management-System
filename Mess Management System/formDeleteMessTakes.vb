Imports MySql.Data.MySqlClient
Public Class formDeleteMessTakes 'Form for Deleting the Orders of Indent_Takes
    Dim conn As New connection 'Mysql Connection used through the Form

    'On Form Load
    Private Sub formDeleteStudentTakes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.KeyPreview = True 'To ensure that KeyPress works | Don't Remove. KeyPress for the Form Won't Work
        T_ID.Focus()
    End Sub

    'Handles Cancel Clicked
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    'Handles T_ID Enter Pressed
    Private Sub T_ID_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles T_ID.KeyPress

        If Asc(e.KeyChar) = Keys.Escape Then
            Me.Close()
        End If

        If Asc(e.KeyChar) = Keys.Enter Then
            If T_ID.Text = "" Then
                MsgBox("Enter Proper T_ID!!")
            Else
                Try

                    'See if the Bill_ID entered Exists or else Show an Error
                    conn.connect()
                    Dim query As String = "Select * from Mess_takes where T_Id = '" + T_ID.Text.ToString + "'"
                    Dim comm As New MySqlCommand(query, conn.conn)
                    Dim dr As MySqlDataReader
                    dr = comm.ExecuteReader
                    If dr.Read Then
                        If DateDiff(DateInterval.Day, dr.Item("DOR"), Today.Date) <= My.Settings.Max_Days_Delete_Entries Then
                            Description.ReadOnly = False
                            Description.Enabled = True
                            Description.Focus()
                            T_ID.ReadOnly = True
                        Else
                            MsgBox("The Transactions upto Last " + My.Settings.Max_Days_Delete_Entries.ToString + " days can only be deleted")
                            T_ID.Text = ""
                        End If
                    Else
                        MsgBox("Enter Proper T_ID")
                        T_ID.Text = ""
                    End If
                Catch ex As MySqlException
                    MsgBox("Error Occured ! Please try Again !")
                    MsgBox(ex.Message.ToString)
                    Me.Close()
                End Try
            End If
        End If
    End Sub

    'Handles KeyPresses on Description
    Private Sub RTB1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Description.KeyPress
        If Asc(e.KeyChar) = Keys.Escape Then
            Me.Close()
        End If
        If Asc(e.KeyChar) = Keys.Enter Then
            Confirm.Focus()
        End If
    End Sub

    'Handles Queries for Deleting the Entry
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Confirm.Click

        'Query2 for Updating the Description and E_ID_Delete in Student_takes_delete
        Dim query2 As String = "UPDATE Mess_Takes_Delete SET DESCRIPTION = '" + Description.Text.ToString + "', E_ID_DELETE = '" + formControlP.Logged_User.ToString + "' where T_ID = '" + T_ID.Text.ToString + "'"
        Try
            conn.connect()

            'Query For Deleting the Entry from Mess_takes. -> Trigger in the DB works and Inserts the Reqd Data into Mess_takes_delete
            Dim query As String = "Delete from Mess_Takes where T_ID = '" + T_ID.Text.ToString + "'"
            Dim comm As New MySqlCommand(query, conn.conn)
            comm.ExecuteNonQuery()
            Dim comm2 As New MySqlCommand(query2, conn.conn)
            comm2.ExecuteNonQuery()

            'Confirm that It is Done
            MsgBox("Transaction Deleted")

            'Recover and Close the form
            formIndentEntry.fill()
            Controls.Clear()
            InitializeComponent()
            T_ID.Focus()
            Me.Close()
        Catch ex As MySqlException
            MsgBox("Error Occured ! Please Try Again !")
            MsgBox(ex.Message.ToString)
            Me.Close()
        End Try
    End Sub

End Class