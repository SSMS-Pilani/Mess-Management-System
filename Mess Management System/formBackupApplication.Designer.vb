<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formBackupApplication
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Button_Backup = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbMessRepBackup = New System.Windows.Forms.TextBox()
        Me.Button_Confirm = New System.Windows.Forms.Button()
        Me.Button_BrowseMySqlDump = New System.Windows.Forms.Button()
        Me.Button_Browse = New System.Windows.Forms.Button()
        Me.TextBox_mySqlDumpLocation = New System.Windows.Forms.TextBox()
        Me.TextBox_Location = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox_DBName = New System.Windows.Forms.TextBox()
        Me.TextBox_Password = New System.Windows.Forms.TextBox()
        Me.TextBox_Username = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(12, 13)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(442, 196)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.Button_Backup)
        Me.TabPage1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(434, 170)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "General"
        '
        'Button_Backup
        '
        Me.Button_Backup.BackColor = System.Drawing.Color.Transparent
        Me.Button_Backup.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Backup.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Button_Backup.Location = New System.Drawing.Point(65, 44)
        Me.Button_Backup.Name = "Button_Backup"
        Me.Button_Backup.Size = New System.Drawing.Size(324, 44)
        Me.Button_Backup.TabIndex = 0
        Me.Button_Backup.Text = "Backup"
        Me.Button_Backup.UseVisualStyleBackColor = False
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.White
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.tbMessRepBackup)
        Me.TabPage2.Controls.Add(Me.Button_Confirm)
        Me.TabPage2.Controls.Add(Me.Button_BrowseMySqlDump)
        Me.TabPage2.Controls.Add(Me.Button_Browse)
        Me.TabPage2.Controls.Add(Me.TextBox_mySqlDumpLocation)
        Me.TabPage2.Controls.Add(Me.TextBox_Location)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.TextBox_DBName)
        Me.TabPage2.Controls.Add(Me.TextBox_Password)
        Me.TabPage2.Controls.Add(Me.TextBox_Username)
        Me.TabPage2.ForeColor = System.Drawing.SystemColors.Control
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(434, 170)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Advance Settings"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(5, 130)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(139, 13)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Mess Rep Backup Location"
        '
        'tbMessRepBackup
        '
        Me.tbMessRepBackup.Enabled = False
        Me.tbMessRepBackup.Location = New System.Drawing.Point(6, 146)
        Me.tbMessRepBackup.Name = "tbMessRepBackup"
        Me.tbMessRepBackup.Size = New System.Drawing.Size(270, 20)
        Me.tbMessRepBackup.TabIndex = 4
        '
        'Button_Confirm
        '
        Me.Button_Confirm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button_Confirm.Location = New System.Drawing.Point(358, 100)
        Me.Button_Confirm.Name = "Button_Confirm"
        Me.Button_Confirm.Size = New System.Drawing.Size(70, 23)
        Me.Button_Confirm.TabIndex = 3
        Me.Button_Confirm.Text = "Save Settings"
        Me.Button_Confirm.UseVisualStyleBackColor = True
        '
        'Button_BrowseMySqlDump
        '
        Me.Button_BrowseMySqlDump.Enabled = False
        Me.Button_BrowseMySqlDump.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button_BrowseMySqlDump.Location = New System.Drawing.Point(358, 62)
        Me.Button_BrowseMySqlDump.Name = "Button_BrowseMySqlDump"
        Me.Button_BrowseMySqlDump.Size = New System.Drawing.Size(70, 23)
        Me.Button_BrowseMySqlDump.TabIndex = 3
        Me.Button_BrowseMySqlDump.Text = "Browse"
        Me.Button_BrowseMySqlDump.UseVisualStyleBackColor = True
        '
        'Button_Browse
        '
        Me.Button_Browse.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button_Browse.Location = New System.Drawing.Point(280, 100)
        Me.Button_Browse.Name = "Button_Browse"
        Me.Button_Browse.Size = New System.Drawing.Size(70, 23)
        Me.Button_Browse.TabIndex = 3
        Me.Button_Browse.Text = "Browse"
        Me.Button_Browse.UseVisualStyleBackColor = True
        '
        'TextBox_mySqlDumpLocation
        '
        Me.TextBox_mySqlDumpLocation.Enabled = False
        Me.TextBox_mySqlDumpLocation.Location = New System.Drawing.Point(6, 63)
        Me.TextBox_mySqlDumpLocation.Name = "TextBox_mySqlDumpLocation"
        Me.TextBox_mySqlDumpLocation.Size = New System.Drawing.Size(346, 20)
        Me.TextBox_mySqlDumpLocation.TabIndex = 2
        '
        'TextBox_Location
        '
        Me.TextBox_Location.Enabled = False
        Me.TextBox_Location.Location = New System.Drawing.Point(6, 102)
        Me.TextBox_Location.Name = "TextBox_Location"
        Me.TextBox_Location.Size = New System.Drawing.Size(270, 20)
        Me.TextBox_Location.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(303, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(153, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Username"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(3, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "MySqlDump Location"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(3, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Backup Location"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(5, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "DB Name"
        '
        'TextBox_DBName
        '
        Me.TextBox_DBName.Enabled = False
        Me.TextBox_DBName.Location = New System.Drawing.Point(6, 24)
        Me.TextBox_DBName.Name = "TextBox_DBName"
        Me.TextBox_DBName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(35)
        Me.TextBox_DBName.Size = New System.Drawing.Size(122, 20)
        Me.TextBox_DBName.TabIndex = 0
        '
        'TextBox_Password
        '
        Me.TextBox_Password.Enabled = False
        Me.TextBox_Password.Location = New System.Drawing.Point(306, 24)
        Me.TextBox_Password.Name = "TextBox_Password"
        Me.TextBox_Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(35)
        Me.TextBox_Password.Size = New System.Drawing.Size(122, 20)
        Me.TextBox_Password.TabIndex = 0
        '
        'TextBox_Username
        '
        Me.TextBox_Username.Enabled = False
        Me.TextBox_Username.Location = New System.Drawing.Point(156, 24)
        Me.TextBox_Username.Name = "TextBox_Username"
        Me.TextBox_Username.PasswordChar = Global.Microsoft.VisualBasic.ChrW(35)
        Me.TextBox_Username.Size = New System.Drawing.Size(122, 20)
        Me.TextBox_Username.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Label7)
        Me.TabPage3.Controls.Add(Me.Label6)
        Me.TabPage3.Controls.Add(Me.Button1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(434, 170)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "For Mess Reps"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(88, 106)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(281, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Goto ssms/dashboard.php > Upload Mess Data to Upload"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(123, 84)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(198, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Get this Data at : D:/MessRepBackups/"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(130, 31)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(186, 45)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "GET MESS DATA"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'backupForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(468, 221)
        Me.Controls.Add(Me.TabControl1)
        Me.KeyPreview = True
        Me.Name = "backupForm"
        Me.Text = "Backup Application"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Button_Backup As System.Windows.Forms.Button
    Friend WithEvents TextBox_DBName As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_Password As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_Username As System.Windows.Forms.TextBox
    Friend WithEvents FolderBrowserDialog As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents Button_Confirm As System.Windows.Forms.Button
    Friend WithEvents Button_Browse As System.Windows.Forms.Button
    Friend WithEvents TextBox_Location As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button_BrowseMySqlDump As System.Windows.Forms.Button
    Friend WithEvents TextBox_mySqlDumpLocation As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tbMessRepBackup As System.Windows.Forms.TextBox

End Class
