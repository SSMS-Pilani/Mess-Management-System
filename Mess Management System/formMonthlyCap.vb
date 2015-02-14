Imports MySql.Data.MySqlClient

Public Class formMonthlyCap 'Form to Add/ Update Monthly Cap that a Student Voluntarily wants to add to his Extras 
    Dim con As New connection

    'Handles Various KeyPresses on the Form
    Private Sub formMonthlyCap_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        ElseIf e.KeyCode = Keys.F5 Then
            reload()
        End If
    End Sub

    'On Form Load
    Private Sub formMonthlyCap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        tbS_ID.Focus()
    End Sub

    'Handles KeyPress on S_ID, queries Student Name and also the Monthly Cap if already exists 
    Private Sub tbS_ID_KeyDown(sender As Object, e As KeyEventArgs) Handles tbS_ID.KeyDown
        If e.KeyCode = Keys.Enter Then
            If tbS_ID.Text.Length = 5 Then
                tbS_ID.Text = "F20" + tbS_ID.Text + "P"
            ElseIf tbS_ID.Text.Length = 6 And (tbS_ID.Text.Contains("H") Or tbS_ID.Text.Contains("h")) Then
                tbS_ID.Text = tbS_ID.Text.Substring(0, 1) + "20" + tbS_ID.Text.Substring(1, 5) + "P"
            ElseIf tbS_ID.Text.Length = 6 And (tbS_ID.Text.Contains("P") Or tbS_ID.Text.Contains("p")) Then
                tbS_ID.Text = tbS_ID.Text.Substring(0, 1) + "20" + tbS_ID.Text.Substring(1, 5) + "P"
            End If
            If tbS_ID.Text <> "" Then
                Try
                    con.connect()
                    Dim query As String = "Select * from Student where S_ID = '" + tbS_ID.Text + "'"
                    Dim comm As New MySqlCommand(query, con.conn)
                    Dim dr As MySqlDataReader
                    dr = comm.ExecuteReader
                    If dr.Read Then
                        Try
                            dr.Close()
                            con.connect()
                            Dim dr2 As MySqlDataReader
                            Dim query2 As String = "SELECT CAP FROM MONTHLY_CAP WHERE S_ID = '" + tbS_ID.Text + "' and MONTH_YEAR = '" + Format(Today.Date, "yyyy-MM").ToString + "-00'"
                            Dim comm2 As New MySqlCommand(query2, con.conn)
                            dr2 = comm2.ExecuteReader
                            If dr2.Read Then
                                Label3.Visible = True
                                Label4.Text = dr2.Item(0)
                            End If
                        Catch ex As Exception
                            MsgBox("Error Occured! Please Try Again!")
                            MsgBox(ex.Message.ToString)
                            tbS_ID.Text = ""
                        End Try
                        proceedAndEnable(tbS_ID, tbCAP)
                    Else
                        MsgBox("Error! S_ID Not Found ! Please Enter Correct S_ID")
                        tbS_ID.Text = ""
                    End If
                Catch ex As Exception
                    MsgBox("Error Occured! Please Try Again!")
                    MsgBox(ex.Message.ToString)
                    tbS_ID.Text = ""
                End Try
            Else
                MsgBox("Enter Propoer S_ID")
            End If
        End If
    End Sub

    'Refreshes the Form
    Public Sub reload()
        Controls.Clear()
        InitializeComponent()
        tbS_ID.Focus()
    End Sub

    'Handles KeyPresses on CAP
    Private Sub tbCAP_KeyDown(sender As Object, e As KeyEventArgs) Handles tbCAP.KeyDown
        If e.KeyCode = Keys.Enter Then
            If tbCAP.Text <> "" And IsNumeric(tbCAP.Text) Then
                tbCAP.ReadOnly = True
                Confirm.Enabled = True
                Confirm.Focus()
            End If
        End If
    End Sub

    'Manages Final INSERT/ Update Query
    Private Sub Confirm_Click(sender As Object, e As EventArgs) Handles Confirm.Click
        Try
            con.connect()
            Dim query As String = "INSERT INTO MONTHLY_CAP(S_ID,MONTH_YEAR,CAP) VALUES('" + tbS_ID.Text + "','" + Format(Today.Date, "yyyy-MM").ToString + "-00'," + tbCAP.Text + ") ON DUPLICATE KEY UPDATE CAP = VALUES(CAP)"
            Dim comm As New MySqlCommand(query, con.conn)
            comm.ExecuteNonQuery()
            MsgBox("Cap Added!!")
            reload()
        Catch ex As Exception
            MsgBox("Error Occured! Please Try Again!")
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

End Class