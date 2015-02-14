Public Class formCashCalc
    Public done As Boolean = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CDbl(formExtras.Sub_total.Text) > CDbl(tbCash_Given.Text) Then
            MsgBox("Cash Insufficient !! Rs. " + CStr(CDbl(formExtras.Sub_total.Text) - CDbl(tbCash_Given.Text)) + " Needed")
            tbCash_Given.Focus()
        Else
            MsgBox("Return Rs. " + CStr(CDbl(tbCash_Given.Text) - CDbl(formExtras.Sub_total.Text)) + " ")
            done = 1
            Me.Close()
        End If
    End Sub
End Class