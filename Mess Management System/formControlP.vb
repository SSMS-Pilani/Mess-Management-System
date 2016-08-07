Public Class formControlP
    Public Logged_User As String = formLogin.Logged_User

    'Various KeyEvents
    Private Sub formControlP_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case (e.KeyCode)
            Case Keys.Escape
                Me.Close()
            Case Keys.F1
                formViewInventory.Show()
            Case Keys.F2
                formViewStudents.Show()
            Case Keys.F3
                formIndentEntry.Show()
            Case Keys.F5
                formExtras.Show()
            Case Keys.F6
                formMonthly.Show()
            Case Keys.Escape
                Me.Close()
            Case Keys.F7
                formIndentEntry.Show()
            Case Keys.F8
                formLedger.Show()
            Case Keys.Q
                Dim myNum As String

                Try
                    myNum = InputBox("Who are you : ")
                    If myNum = "" Then
                        MsgBox("Enter Proper Password")
                    ElseIf myNum = "devenbansod.bits" Then
                        formEditSettings.Show()
                    Else
                        MsgBox("Enter Proper Password")
                    End If

                Catch
                    MsgBox("Enter Proper Password!.")

                End Try

        End Select
    End Sub

    'Needs To act upon the Key Events of Form
    Private Sub formControlP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
    End Sub


    'Below Functions handle various Buttons' Clicks'


    Private Sub Add_Item_Click(sender As Object, e As EventArgs) Handles Add_item.Click
        formAddItem.Show()
    End Sub


    Private Sub Extras_Click(sender As Object, e As EventArgs) Handles Extras.Click
        formExtras.Show()
    End Sub


    Private Sub Indent_Entry_Click(sender As Object, e As EventArgs) Handles Indent_Entry.Click
        formIndentEntry.Show()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Student_acc.Click
        formStudentAccount.Show()
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Change_SP.Click
        formChangePrice.Show()
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Item_Sale.Click
        formItemSale.Show()
        'formItemSaleOld.Show()
    End Sub


    Private Sub Inventory_Click(sender As Object, e As EventArgs) Handles Inventory.Click
        formViewInventory.Show()
    End Sub


    Private Sub Add_Supplier_Click(sender As Object, e As EventArgs) Handles Add_Supplier.Click
        formAddSupplier.Show()
    End Sub


    Private Sub Block_UB_Click(sender As Object, e As EventArgs) Handles Block_UB.Click
        formBlock.Show()
    End Sub


    Private Sub Deleted_Supplies_Click(sender As Object, e As EventArgs) Handles Deleted_Supplies.Click
        formDeletedSupplies.Show()
    End Sub


    Private Sub Deleted_Extras_Click(sender As Object, e As EventArgs) Handles Deleted_Extras.Click
        formDeletedExtras.Show()
    End Sub


    Private Sub Students_Click(sender As Object, e As EventArgs) Handles Students.Click
        formViewStudents.Show()
    End Sub


    Private Sub Ledger_Click(sender As Object, e As EventArgs) Handles Ledger.Click
        formLedger.Show()
    End Sub


    Private Sub Monthly_bill_Click(sender As Object, e As EventArgs) Handles Monthly_Bill.Click
        formMonthlyBill.Show()
    End Sub


    Private Sub Rebate_Click(sender As Object, e As EventArgs) Handles Rebate.Click
        formRebate.Show()
    End Sub

    Private Sub Monthly_Click(sender As Object, e As EventArgs) Handles Monthly.Click
        formMonthly.Show()
    End Sub

    Private Sub Monthly_Cap_Click(sender As Object, e As EventArgs) Handles Monthly_Cap.Click
        formMonthlyCap.Show()
    End Sub


    Private Sub Grub_Signings_Click(sender As Object, e As EventArgs) Handles Grub_Signings.Click
        If My.Settings.grubSigningsON Then
            formGrubSignings.Show()
        Else
            MsgBox("Grub Signings have been disabled in Messes")
        End If
    End Sub

    Private Sub backupButton_Click(sender As Object, e As EventArgs) Handles backupButton.Click
        formBackupApplication.show()
    End Sub
    Private Sub Add_Student_Click(sender As Object, e As EventArgs) Handles Add_Student.Click
        formAddStudent.Show()
     End Sub

    Private Sub btnClearInventory_Click(sender As Object, e As EventArgs) Handles btnClearInventory.Click
        formClearInventory.Show()
    End Sub
End Class
