Public Class formEditSettings

    'Loads the Previously Saved Values
    Private Sub formEditSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        tbMess_Name.Focus()
        tbmess_name.Text = My.Settings.messName
        cbBy_Scanner_Only.Checked = My.Settings.by_scanner_only
        tbCash_ID.Text = My.Settings.Cash_ID
        cbCash_On.Checked = My.Settings.Cash_On
        tbMax_Days_Delete_Entries.Text = My.Settings.Max_Days_Delete_Entries
        tbRebate_Min_Days.Text = My.Settings.Rebate_Min_days
        tbPhotos_Location.Text = My.Settings.Photos_Location
        tbExtras_Location.Text = My.Settings.Extras_Location
        tbQuery_ON.Checked = My.Settings.Query_ON
        tbDB_Name.Text = My.Settings.DB_NAME
        'tbMessShortName.Text = My.Settings.messShortName
    End Sub

    'Handles various Key PResses on the form
    Private Sub formEditSettings_KeyPress(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        ElseIf e.KeyCode = Keys.F5 Then
            formEditSettings_Load(sender, e)
        End If
    End Sub

    'Loads the Control Panel form
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click, ButtonControlP.Click
        formControlP.Show()
        Me.Close()
    End Sub

    'Saves the new Settings
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonConfirm.Click
        Try
            My.Settings.messName = tbMess_Name.Text
            My.Settings.by_scanner_only = cbBy_Scanner_Only.Checked
            My.Settings.Cash_ID = tbCash_ID.Text
            My.Settings.Cash_On = cbCash_On.Checked
            My.Settings.Max_Days_Delete_Entries = tbMax_Days_Delete_Entries.Text
            My.Settings.Rebate_Min_days = tbRebate_Min_Days.Text
            My.Settings.Photos_Location = tbPhotos_Location.Text
            My.Settings.Extras_Location = tbExtras_Location.Text
            My.Settings.Query_ON = tbQuery_ON.Checked
            My.Settings.DB_NAME = tbDB_Name.Text
            'My.Settings.messShortName = tbMessShortName.Text

            MsgBox("Settings updated!")
            formEditSettings_Load(sender, e)
        Catch ex As Exception
            MsgBox("Error! Settings were not saved !")
            MsgBox(ex.Message.ToString)
            formEditSettings_Load(sender, e)
        End Try



    End Sub
End Class