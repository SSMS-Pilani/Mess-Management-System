Imports System.IO

Public Class formBackupApplication

    Private Sub backupForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Q Then
            If InputBox("Enter Security Access Code", "Passphrase") = "55ms" Then
                TextBox_DBName.Enabled = True
                TextBox_Password.Enabled = True
                TextBox_Username.Enabled = True
                Button_BrowseMySqlDump.Enabled = True
                TextBox_Location.Enabled = True
            End If
        End If
    End Sub

    Private Sub backupForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox_DBName.Text = My.Settings.DB_NAME
        TextBox_Username.Text = My.Settings.DB_UserName
        TextBox_Password.Text = My.Settings.DB_Password
        TextBox_Location.Text = My.Settings.BackupLocation
        tbMessRepBackup.Text = My.Settings.MessRepBackupLocation
        TextBox_mySqlDumpLocation.Text = My.Settings.mysqldumpLocation
    End Sub

    Private Sub Button_Backup_Click(sender As Object, e As EventArgs) Handles Button_Backup.Click
        Try
            Dim myProcess As New Process

            With myProcess.StartInfo
                .FileName = "cmd.exe"
                .UseShellExecute = False
                .WorkingDirectory = My.Settings.mysqldumpLocation
                .RedirectStandardInput = True
                .RedirectStandardOutput = True
                .RedirectStandardError = True
                .CreateNoWindow = True
            End With

            myProcess.Start()
            Dim myStreamWriter As StreamWriter = myProcess.StandardInput
            Dim mystreamreader As StreamReader = myProcess.StandardOutput

            Dim command As String
            command = "mysqldump -u " + My.Settings.DB_UserName +
                " -p" + My.Settings.DB_Password +
                " " + My.Settings.DB_NAME +
                " > " + My.Settings.BackupLocation +
                "/dump_" + DateTime.Now.ToString("yyyy_MMM_dd_HH-mm-ss") + ".sql"
            myStreamWriter.WriteLine(command)
            myStreamWriter.Close()

            'for supressing warning
            Dim outputStr As String
            outputStr = myProcess.StandardError.ReadToEnd

            If (outputStr.ToLower.Contains("error")) Then
                MsgBox(outputStr)
                'Throw New Exception
            Else
                MsgBox("Backup Successful")
            End If
            myProcess.WaitForExit()
            myProcess.Close()
        Catch ex As Exception
            MsgBox("Contact SSMS Technical Team Immediately!!", MsgBoxStyle.OkOnly, "Backup Failed")
        End Try
    End Sub

    Private Sub Button_Browse_Click(sender As Object, e As EventArgs) Handles Button_BrowseMySqlDump.Click
        FolderBrowserDialog.ShowDialog()
        TextBox_mySqlDumpLocation.Text = FolderBrowserDialog.SelectedPath
    End Sub

    Private Sub Button_LocationBrowse_Click(sender As Object, e As EventArgs) Handles Button_Browse.Click
        FolderBrowserDialog.ShowDialog()
        TextBox_Location.Text = FolderBrowserDialog.SelectedPath
    End Sub


    Private Sub Button_Confirm_Click(sender As Object, e As EventArgs) Handles Button_Confirm.Click
        My.Settings.DB_NAME = TextBox_DBName.Text
        My.Settings.DB_UserName = TextBox_Username.Text
        My.Settings.DB_Password = TextBox_Password.Text
        My.Settings.BackupLocation = TextBox_Location.Text
        My.Settings.mysqldumpLocation = TextBox_mySqlDumpLocation.Text
        My.Settings.MessRepBackupLocation = tbMessRepBackup.Text
        TextBox_DBName.Enabled = False
        TextBox_Password.Enabled = False
        TextBox_Username.Enabled = False
        Button_BrowseMySqlDump.Enabled = False

        MsgBox("Settings Saved", MsgBoxStyle.OkOnly, "Backup Application")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim myProcess As New Process

            With myProcess.StartInfo
                .FileName = "cmd.exe"
                .UseShellExecute = False
                .WorkingDirectory = My.Settings.mysqldumpLocation
                .RedirectStandardInput = True
                .RedirectStandardOutput = True
                .RedirectStandardError = True
                .CreateNoWindow = True
            End With

            myProcess.Start()
            Dim myStreamWriter As StreamWriter = myProcess.StandardInput
            Dim mystreamreader As StreamReader = myProcess.StandardOutput

            Dim command As String

            command = "mysqldump -u " + My.Settings.DB_UserName +
                " -p" + My.Settings.DB_Password +
                " --no-create-info --skip-triggers --disable-keys --skip-add-locks --skip-set-charset --single-transaction " + My.Settings.DB_NAME + " student_takes item " +
                " > " + My.Settings.MessRepBackupLocation +
                "/MessRepDump_" + DateTime.Now.ToString("yyyy_MMM_dd_HH-mm-ss") + ".sql"
            myStreamWriter.WriteLine(command)
            myStreamWriter.Close()

            'for supressing warning
            Dim outputStr As String
            outputStr = myProcess.StandardError.ReadToEnd

            If (outputStr.ToLower.Contains("error")) Then
                MsgBox(outputStr)
                'Throw New Exception
            Else
                MsgBox("Backup Successful")
            End If
            myProcess.WaitForExit()
            myProcess.Close()
        Catch ex As Exception
            MsgBox("Contact SSMS Technical Team Immediately!!", MsgBoxStyle.OkOnly, "Backup Failed")
        End Try
    End Sub
End Class

