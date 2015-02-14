Imports MySql.Data.MySqlClient
Public Class formLogin

    Public Logged_User As String 'Used when Insert Queries for E_ID in other Forms

    'On Form Load
    Private Sub formLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.KeyPreview = True
        'TabPage1.Show()
        'TabPage1.Focus()
        Logged_User = 0
        username.Focus()
        DBName.Text = My.Settings.DB_NAME
        DBUsername.Text = My.Settings.DB_UserName
        DBPassword.Text = My.Settings.DB_Password
        PictureBox1.Visible = True
        

    End Sub

    'Handles Logging In
    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        My.Settings.CurrentSession_DBName = DBName.Text
        My.Settings.CurrentSession_DBUsername = DBUsername.Text
        My.Settings.CurrentSession_Password = DBPassword.Text
        Dim con As New connection 'Connection used within the Form

        Dim query As String = "SELECT PASSWORD, PRIVILEGE FROM EMPLOYEE WHERE E_ID ='" + username.Text.ToString + "'"
        Dim dr As MySqlDataReader
        Dim command As New MySqlCommand(query, con.conn)

        Try
            con.connect()
            dr = command.ExecuteReader()
            If dr.HasRows = False Then
                Throw New System.Exception("User does not exists")
            End If
            dr.Read()

        Catch ex As Exception 'Error with DB or if the USER ID doesnot exist
            MsgBox("Error With the Database Connection/Query!")
            MsgBox(ex.Message.ToString)
            resetForm()
            Return
        End Try


        'Checks if Password Entered Matches Password in DB
        If password.Text.ToString = dr.GetString("PASSWORD") Then
            Select Case dr.Item(1)
                Case 0 'non admin privilage
                    formControlP.GroupBox1.Visible = True
                    formControlP.GroupBox2.Visible = False
                    formControlP.GroupBox3.Visible = False
                    Me.Logged_User = username.Text.ToString
                    formControlP.Show()
                    formControlP.Logged_User = username.Text.ToString
                    Me.Close()

                Case 1 'admin privilage
                    formControlP.GroupBox1.Visible = True
                    formControlP.GroupBox2.Visible = True
                    formControlP.GroupBox3.Visible = True
                    Me.Logged_User = username.Text.ToString
                    formControlP.Show()
                    formControlP.Logged_User = username.Text.ToString
                    Me.Close()

                Case 2 'technical team
                    formEditSettings.Show()
                    Me.Close()

                Case Else
                    MsgBox("Undefined Privilage for given username")
                    resetForm()

            End Select
        Else
            MsgBox("Undefined Username or Password")
            resetForm()
        End If
    End Sub

    'Resets form
    Public Sub resetForm()
        Dim newForm As New formLogin
        Me.Hide()
        newForm.Show()
        Me.Close()
    End Sub

    'Functions Below handle various KeyPresses and Clicks

    Private Sub username_KeyDown(sender As Object, e As KeyEventArgs) Handles username.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
            username.ReadOnly = True
        End If
    End Sub


    Private Sub password_KeyDown(sender As Object, e As KeyEventArgs) Handles password.KeyDown
        If e.KeyCode = Keys.Enter Then
            loginBtn_Click(sender, e)
        End If

    End Sub


    Private Sub cancelBtn_Click(sender As Object, e As EventArgs) Handles cancelBtn.Click
        Me.Close()
    End Sub


    Private Sub formLogin_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        ElseIf e.KeyCode = Keys.F5 Then
            Me.resetForm()
        ElseIf e.KeyCode = Keys.F8 Then
            formEditSettings.Show()

        End If
    End Sub

End Class
