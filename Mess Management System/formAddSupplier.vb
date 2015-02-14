Imports MySql.Data.MySqlClient
Public Class formAddSupplier
    Dim con As New connection 'Mysql Connection used within the Form

    'On Form Load
    Private Sub formAddSupplier_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.KeyPreview = True
        Sup_ID.Focus()
        Sup_Address.Enabled = False
        Sup_Address.ReadOnly = True
        Sup_Name.ReadOnly = True
        Sup_Name.Enabled = False
    End Sub


    'Handles Cancel Button Click
    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub


    'Handles Escape Key Event
    Private Sub formAddSupplier_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub


    'Handles Enter on Supplier ID
    Private Sub Sup_ID_KeyDown(sender As Object, e As KeyEventArgs) Handles Sup_ID.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Sup_ID.Text <> "" Then
                Try
                    con.connect()
                    Dim query As String = "Select * from supplier_master where sup_id = '" + Sup_ID.Text.ToString + "'"
                    Dim comm As New MySqlCommand(query, con.conn)
                    Dim dr As MySqlDataReader
                    dr = comm.ExecuteReader

                    'Checks if Supplier ID already exists
                    'If yes, Shows an error | Else Proceed
                    If dr.Read() Then
                        MsgBox("Supplier ID Already Exists ! Enter A Different One")
                        Sup_ID.Text = ""
                    Else
                        proceedAndEnable(Sup_ID, Sup_Name)
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

    'Refreshes Form Elements
    Private Sub reload()
        Controls.Clear()
        InitializeComponent()
        Sup_ID.Focus()
        Sup_Address.Enabled = False
        Sup_Address.ReadOnly = True
        Sup_Name.ReadOnly = True
        Sup_Name.Enabled = False
    End Sub


    'Handles Enter Key event
    Private Sub Sup_Name_KeyDown(sender As Object, e As KeyEventArgs) Handles Sup_Name.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Sup_Name.Text = "" Then
                MsgBox("Supplier Name Cannot be Empty ! Please Enter a Value")
                Sup_Name.Text = ""
                Sup_Name.Focus()
            Else
                proceedAndEnable(Sup_Name, Sup_Address)
            End If
        End If
    End Sub


    'Handles Enter Key event
    Private Sub Sup_Address_KeyDown(sender As Object, e As KeyEventArgs) Handles Sup_Address.KeyDown
        If e.KeyCode = Keys.Enter Then
            proceedAndEnable(Sup_Address, Confirm, False)
        End If
    End Sub


    'Handles Confirm Click and Carries out INSERT Query
    Private Sub Confirm_Click(sender As Object, e As EventArgs) Handles Confirm.Click
        Try
            con.connect()
            Dim query As String = "INSERT INTO SUPPLIER_MASTER(SUP_ID,NAME,CONTACT) VALUES('" + Sup_ID.Text.ToString + "','" + Sup_Name.Text.ToString + "','" + Sup_Address.Text.ToString + "')"
            Dim comm As New MySqlCommand(query, con.conn)
            comm.ExecuteNonQuery()
            MsgBox("Supplier Added")
            reload()
        Catch ex As Exception
            MsgBox("Error Occured ! Please Try again !!")
            MsgBox(ex.Message.ToString)
            reload()
        End Try
    End Sub


End Class