Imports MySql.Data.MySqlClient
Public Class formGrubSignings
    Dim con As New connection
    Dim chara As Array
    Private Sub Button1_Click(ByVal sender As System.Object, _
   ByVal e As System.EventArgs) Handles Button1.Click

        Dim openFileDialog1 As New OpenFileDialog()
        openFileDialog1.Filter = "CSV Files|*.csv"
        openFileDialog1.Title = "Select a CSV File with all the S_IDs w/o Column Labels"

        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then

            Dim sr As New System.IO.StreamReader(openFileDialog1.FileName)
            Dim data As String = sr.ReadToEnd
            chara = data.Split(My.Settings.grubSigningsDelimiter)

            TextBox1.Text = openFileDialog1.FileName

            Button2.Enabled = True
            'MsgBox(chara(0))
            'MsgBox(data)
            'MsgBox(sr.ReadToEnd)
        End If
    End Sub

    Private Sub formGrubSignings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        TextBox1.Focus()
    End Sub


    Private Sub TextBox2_TextChanged(sender As Object, e As KeyEventArgs) Handles TextBox2.KeyDown

        Try
            If e.KeyCode = Keys.Enter Then
                con.connect()
                Dim query As String = "Select * from item where item_id = '" + TextBox2.Text.ToString + "'"
                Dim dr As MySqlDataReader
                Dim comm As New MySqlCommand(query, con.conn)

                dr = comm.ExecuteReader
                If dr.Read() Then
                    TextBox3.Text = dr.Item("NAME")
                    TextBox4.Text = dr.Item("SP")
                    TextBox1.Enabled = False
                    Button1.Enabled = True
                    Button1.Focus()
                Else
                    MsgBox("Error ! No Such Item Found! Please Try Again!")
                End If
            End If
        Catch ex As Exception
            MsgBox("Error ! Please Try Again!")
            MsgBox(ex.Message.ToString)
        End Try

    End Sub

    Private Sub bill_the_item(chara As Array, itemId As String)
        Try
            con.connect()
            Dim query As String
            Dim maxbid, new_bid As Integer

            query = "SELECT MAX(BILL_ID) FROM STUDENT_TAKES"
            Dim comm As New MySqlCommand(query, con.conn)
            Dim dr As MySqlDataReader = comm.ExecuteReader
            Dim i, k As Integer
            dr.Read()
            If Not IsDBNull(dr.Item(0)) Then
                i = dr.Item(0)
            Else
                i = 0
            End If
            dr.Close()
            query = "Select MAX(BILL_ID) FROM STUDENT_TAKES_DELETE"
            Dim commk As New MySqlCommand(query, con.conn)
            Dim dr2 As MySqlDataReader
            dr2 = commk.ExecuteReader
            dr2.Read()
            If Not IsDBNull(dr2.Item(0)) Then
                k = dr2.Item(0)
            Else
                k = 0
            End If
            dr2.Close()
            If i < k Then
                maxbid = k
            Else
                maxbid = i
            End If
            new_bid = maxbid + 1
            Dim final_query As String = "INSERT INTO STUDENT_TAKES(BILL_ID,T_ID,S_ID,E_ID,ITEM_ID,QTY,RATE,TAX) VALUES"
            Dim no As Integer = 0
            For j As Integer = 0 To chara.Length - 2
                no = no + 1
                new_bid = new_bid + 1

                final_query = final_query + " ('" + new_bid.ToString + "','1','" + chara(j).ToString.Trim + "','1','" + TextBox2.Text.ToString + "','1','" + TextBox4.Text.ToString + "','0'),"

            Next


            final_query = final_query.Substring(0, final_query.Length - 1)
            'MsgBox(final_query)
            Dim Final_comm As New MySqlCommand(final_query, con.conn)
            Final_comm.ExecuteNonQuery()
            MsgBox("The " + no.ToString + " Students have been charged successfully!")
            reload()
        Catch ex As Exception
            MsgBox("Error Occured! Please try again!")
            MsgBox(ex.Message.ToString)
        End Try
    End Sub


    Private Sub reload()
        Controls.Clear()
        InitializeComponent()
        formGrubSignings_Load(Me, Nothing)
        TextBox2.Focus()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        bill_the_item(chara, TextBox2.Text.ToString)
    End Sub

    Private Sub formExtras_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown 'Handles Key Presses 
        Select Case e.KeyCode
            
            Case Is = Keys.F5
                reload()
            Case Is = Keys.Escape
                Me.Close()
        End Select
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class
