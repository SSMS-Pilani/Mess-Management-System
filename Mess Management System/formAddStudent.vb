Imports MySql.Data.MySqlClient
'This form add new student to the database
Public Class formAddStudent
    Dim con As New connection 'Mysql Connection used within the Form
    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Me.Close()

    End Sub

    'load the form, fill bhawan list
    Private Sub formAddStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        Student_Short_Id.Focus()
        Student_Complete_Id.Enabled = False
        Student_Complete_Id.ReadOnly = True
        Student_Name.Enabled = False
        Student_Name.ReadOnly = True

        Student_Room.Enabled = False
        Student_Room.ReadOnly = True
        Student_Bhawan.Enabled = False
        Confirm.Enabled = False
        FillBhawanList()


    End Sub
    'This function fills bhawan list
    'It first stores all bhawans in a datatable
    'Then it provides source to  the combobox
    Private Sub FillBhawanList()
        Dim dtbl As New DataTable()
        dtbl.Columns.Add("Bhawan_Name")
        dtbl.Columns.Add("Bhawan_Code")
        dtbl.Rows.Add("---Select---", "XX")
        dtbl.Rows.Add("VYAS", "VY")
        dtbl.Rows.Add("GANDHI", "GN")
        dtbl.Rows.Add("SHANKAR", "SK")
        dtbl.Rows.Add("KRISHNA", "KR")
        dtbl.Rows.Add("RAM", "RM")
        dtbl.Rows.Add("MEERA", "MR")
        dtbl.Rows.Add("MALVIYA", "ML")
        dtbl.Rows.Add("MAL EXTENSION", "MLE")
        dtbl.Rows.Add("ASHOK", "AK")
        dtbl.Rows.Add("BHUDH", "BG")
        dtbl.Rows.Add("BHAGIRATH", "BG")
        dtbl.Rows.Add("VISHWAKARMA", "VK")
        dtbl.Rows.Add("SRI RAMANUJAN", "SR")
        dtbl.Rows.Add("CVR", "CVR")
        dtbl.Rows.Add("RANA PRATAP", "RP")
        Student_Bhawan.DataSource = dtbl
        Student_Bhawan.DisplayMember = "Bhawan_Name"
        Student_Bhawan.ValueMember = "Bhawan_Code"


    End Sub


    Private Sub formAddStudent_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub Student_Short_Id_KeyDown(sender As Object, e As KeyEventArgs) Handles Student_Short_Id.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Student_Short_Id.Text <> "" Then
                Try
                    If (validateStudentShortId(Student_Short_Id.Text.ToString.ToUpper)) Then


                        con.connect()
                        Dim query As String = "Select * from student where s_id = '" + Student_Short_Id.Text.ToString + "'"
                        Dim comm As New MySqlCommand(query, con.conn)
                        Dim dr As MySqlDataReader
                        dr = comm.ExecuteReader

                        'Checks if Supplier ID already exists
                        'If yes, Shows an error | Else Proceed
                        If dr.Read() Then
                            MsgBox("Student ID Already Exists ! Enter A Different One")
                            Student_Short_Id.Text = ""
                        Else
                            proceedAndEnable(Student_Short_Id, Student_Complete_Id)
                        End If
                    Else : MsgBox("Invalid Student ID !Enter A Different One")
                        Student_Short_Id.Text = ""
                    End If
                Catch ex As MySqlException
                    MsgBox("Error Occured ! Please Try Again")
                    MsgBox(ex.Message.ToString)
                    reload()
                End Try
            Else
                MsgBox("Supplier ID Cannot be Empty ! Please Fill a Value")
            End If
        End If
    End Sub

    Private Sub reload()
        Controls.Clear()
        InitializeComponent()
        Student_Short_Id.Focus()
        Student_Complete_Id.Enabled = False
        Student_Complete_Id.ReadOnly = True
        Student_Name.Enabled = False
        Student_Name.ReadOnly = True

        Student_Room.Enabled = False
        Student_Room.ReadOnly = True
        Student_Bhawan.Enabled = False
        Confirm.Enabled = False
        FillBhawanList()


    End Sub
    'this function validates student short id (e.g. f2014623p)
    Private Function validateStudentShortId(id As String) As Boolean
        If (id.Length <> 9) Then
            Return False
        End If
        If ((id.Substring(1, 2) = "20") And id.Substring(8) = "P") Then
            Return True
        Else : Return False
        End If
    End Function

    'this function validates student full id (e.g. 2014a2ps623p)
    Private Function validateStudentCompleteId(id As String) As Boolean
        If (id.Length <> 12) Then
            Return False
        End If
        If ((id.Substring(0, 2) = "20") And (id.Substring(2, 2) = Student_Short_Id.Text.Substring(3, 2)) And (id.Substring(8, 3) = Student_Short_Id.Text.Substring(5, 3)) And id.Substring(11) = "P") Then
            Return True
        Else : Return False
        End If
    End Function


    Private Sub Student_Complete_Id_KeyDown(sender As Object, e As KeyEventArgs) Handles Student_Complete_Id.KeyDown
        If e.KeyCode = Keys.Enter Then


            If Student_Complete_Id.Text = "" Then
                MsgBox("Student Complete ID Cannot be Empty ! Please Enter a Value")
                Student_Complete_Id.Text = ""
                Student_Complete_Id.Focus()
            Else
                If (validateStudentCompleteId(Student_Complete_Id.Text.ToUpper)) Then
                    proceedAndEnable(Student_Complete_Id, Student_Name)

                Else
                    MsgBox("Invalid Student ID !Enter A Different One")
                    Student_Complete_Id.Text = ""

                End If
            End If
        End If

    End Sub

    Private Sub Student_Name_KeyDown(sender As Object, e As KeyEventArgs) Handles Student_Name.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Student_Name.Text = "" Then
                MsgBox("Student Name Cannot be Empty ! Please Enter a Value")
                Student_Name.Text = ""
                Student_Name.Focus()
            Else
                proceedAndEnable(Student_Name, Student_Room)
            End If
        End If
    End Sub



    Private Sub Student_Room_KeyDown(sender As Object, e As KeyEventArgs) Handles Student_Room.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Student_Room.Text = "" Then
                MsgBox("Room Number Cannot be Empty ! Please Enter a Value")
                Student_Room.Text = ""
                Student_Room.Focus()
            Else
                Try
                    If Convert.ToInt32(Student_Room.Text) > 0 And Convert.ToInt32(Student_Room.Text) < 99999 Then
                        Student_Bhawan.Enabled = True
                        Confirm.Enabled = True

                        Student_Room.Enabled = False
                        Student_Room.ReadOnly = True
                    End If
                Catch exp As Exception
                    MsgBox("Invalid Room Number")
                    Student_Room.Text = ""
                End Try

            End If
        End If
    End Sub

    Private Sub Confirm_Click(sender As Object, e As EventArgs) Handles Confirm.Click
        Try
            If Student_Bhawan.SelectedValue <> "XX" Then



                con.connect()
                Dim query As String = "INSERT INTO STUDENT(S_ID,IDNO,NAME,ROOM,BHAWAN,BLOCK) VALUES('" + Student_Short_Id.Text.ToString.ToUpper + "','" + Student_Complete_Id.Text.ToString.ToUpper + "','" + Student_Name.Text.ToString.ToUpper + "','" + Student_Room.Text.ToString.ToUpper + "','" + Student_Bhawan.SelectedValue.ToString.ToUpper + "','0')"
                Dim comm As New MySqlCommand(query, con.conn)
                comm.ExecuteNonQuery()
                MsgBox("Student Added")
                reload()
            Else
                MsgBox("Please select a Bhawan")

            End If
        Catch ex As Exception
            MsgBox("Error Occured ! Please Try again !!")
            MsgBox(ex.Message.ToString)
            reload()
        End Try
    End Sub

End Class