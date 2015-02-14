<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formLogin))
        Me.username = New System.Windows.Forms.TextBox()
        Me.password = New System.Windows.Forms.TextBox()
        Me.usernameLabel = New System.Windows.Forms.Label()
        Me.passwordLabel = New System.Windows.Forms.Label()
        Me.loginBtn = New System.Windows.Forms.Button()
        Me.cancelBtn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.AdvanceSettings = New System.Windows.Forms.TabPage()
        Me.DBPassword = New System.Windows.Forms.TextBox()
        Me.DBName = New System.Windows.Forms.TextBox()
        Me.DBUsername = New System.Windows.Forms.TextBox()
        Me.Label_DBPassword = New System.Windows.Forms.Label()
        Me.Label_DBName = New System.Windows.Forms.Label()
        Me.Label_DBUsername = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.AdvanceSettings.SuspendLayout()
        Me.SuspendLayout()
        '
        'username
        '
        Me.username.Location = New System.Drawing.Point(223, 42)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(157, 20)
        Me.username.TabIndex = 0
        '
        'password
        '
        Me.password.Location = New System.Drawing.Point(223, 82)
        Me.password.Name = "password"
        Me.password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.password.Size = New System.Drawing.Size(157, 20)
        Me.password.TabIndex = 1
        '
        'usernameLabel
        '
        Me.usernameLabel.AutoSize = True
        Me.usernameLabel.Location = New System.Drawing.Point(220, 26)
        Me.usernameLabel.Name = "usernameLabel"
        Me.usernameLabel.Size = New System.Drawing.Size(55, 13)
        Me.usernameLabel.TabIndex = 1
        Me.usernameLabel.Text = "Username"
        '
        'passwordLabel
        '
        Me.passwordLabel.AutoSize = True
        Me.passwordLabel.Location = New System.Drawing.Point(220, 66)
        Me.passwordLabel.Name = "passwordLabel"
        Me.passwordLabel.Size = New System.Drawing.Size(53, 13)
        Me.passwordLabel.TabIndex = 1
        Me.passwordLabel.Text = "Password"
        '
        'loginBtn
        '
        Me.loginBtn.Location = New System.Drawing.Point(223, 125)
        Me.loginBtn.Name = "loginBtn"
        Me.loginBtn.Size = New System.Drawing.Size(75, 23)
        Me.loginBtn.TabIndex = 2
        Me.loginBtn.Text = "Login"
        Me.loginBtn.UseVisualStyleBackColor = True
        '
        'cancelBtn
        '
        Me.cancelBtn.Location = New System.Drawing.Point(305, 125)
        Me.cancelBtn.Name = "cancelBtn"
        Me.cancelBtn.Size = New System.Drawing.Size(75, 23)
        Me.cancelBtn.TabIndex = 3
        Me.cancelBtn.Text = "Cancel"
        Me.cancelBtn.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Mess_Management_System.My.Resources.Resources.bitslogo
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(6, 23)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(185, 132)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.TabPage1)
        Me.TabControl.Controls.Add(Me.AdvanceSettings)
        Me.TabControl.Location = New System.Drawing.Point(12, 12)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(450, 197)
        Me.TabControl.TabIndex = 5
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Transparent
        Me.TabPage1.Controls.Add(Me.PictureBox1)
        Me.TabPage1.Controls.Add(Me.cancelBtn)
        Me.TabPage1.Controls.Add(Me.username)
        Me.TabPage1.Controls.Add(Me.loginBtn)
        Me.TabPage1.Controls.Add(Me.password)
        Me.TabPage1.Controls.Add(Me.passwordLabel)
        Me.TabPage1.Controls.Add(Me.usernameLabel)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(442, 171)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Login"
        '
        'AdvanceSettings
        '
        Me.AdvanceSettings.BackColor = System.Drawing.Color.Transparent
        Me.AdvanceSettings.Controls.Add(Me.DBPassword)
        Me.AdvanceSettings.Controls.Add(Me.DBName)
        Me.AdvanceSettings.Controls.Add(Me.DBUsername)
        Me.AdvanceSettings.Controls.Add(Me.Label_DBPassword)
        Me.AdvanceSettings.Controls.Add(Me.Label_DBName)
        Me.AdvanceSettings.Controls.Add(Me.Label_DBUsername)
        Me.AdvanceSettings.Location = New System.Drawing.Point(4, 22)
        Me.AdvanceSettings.Name = "AdvanceSettings"
        Me.AdvanceSettings.Padding = New System.Windows.Forms.Padding(3)
        Me.AdvanceSettings.Size = New System.Drawing.Size(442, 171)
        Me.AdvanceSettings.TabIndex = 1
        Me.AdvanceSettings.Text = "Advance Settings"
        '
        'DBPassword
        '
        Me.DBPassword.Location = New System.Drawing.Point(144, 95)
        Me.DBPassword.Name = "DBPassword"
        Me.DBPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.DBPassword.Size = New System.Drawing.Size(173, 20)
        Me.DBPassword.TabIndex = 1
        '
        'DBName
        '
        Me.DBName.Location = New System.Drawing.Point(144, 35)
        Me.DBName.Name = "DBName"
        Me.DBName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(35)
        Me.DBName.Size = New System.Drawing.Size(173, 20)
        Me.DBName.TabIndex = 1
        '
        'DBUsername
        '
        Me.DBUsername.Location = New System.Drawing.Point(144, 65)
        Me.DBUsername.Name = "DBUsername"
        Me.DBUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(64)
        Me.DBUsername.Size = New System.Drawing.Size(173, 20)
        Me.DBUsername.TabIndex = 1
        '
        'Label_DBPassword
        '
        Me.Label_DBPassword.AutoSize = True
        Me.Label_DBPassword.Location = New System.Drawing.Point(54, 98)
        Me.Label_DBPassword.Name = "Label_DBPassword"
        Me.Label_DBPassword.Size = New System.Drawing.Size(74, 13)
        Me.Label_DBPassword.TabIndex = 68
        Me.Label_DBPassword.Text = "DB_Password"
        '
        'Label_DBName
        '
        Me.Label_DBName.AutoSize = True
        Me.Label_DBName.Location = New System.Drawing.Point(54, 38)
        Me.Label_DBName.Name = "Label_DBName"
        Me.Label_DBName.Size = New System.Drawing.Size(56, 13)
        Me.Label_DBName.TabIndex = 66
        Me.Label_DBName.Text = "DB_Name"
        '
        'Label_DBUsername
        '
        Me.Label_DBUsername.AutoSize = True
        Me.Label_DBUsername.Location = New System.Drawing.Point(54, 68)
        Me.Label_DBUsername.Name = "Label_DBUsername"
        Me.Label_DBUsername.Size = New System.Drawing.Size(76, 13)
        Me.Label_DBUsername.TabIndex = 67
        Me.Label_DBUsername.Text = "DB_Username"
        '
        'formLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(471, 223)
        Me.Controls.Add(Me.TabControl)
        Me.Name = "formLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Welcome to Mess Management System"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.AdvanceSettings.ResumeLayout(False)
        Me.AdvanceSettings.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents username As System.Windows.Forms.TextBox
    Friend WithEvents password As System.Windows.Forms.TextBox
    Friend WithEvents usernameLabel As System.Windows.Forms.Label
    Friend WithEvents passwordLabel As System.Windows.Forms.Label
    Friend WithEvents loginBtn As System.Windows.Forms.Button
    Friend WithEvents cancelBtn As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TabControl As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents AdvanceSettings As System.Windows.Forms.TabPage
    Friend WithEvents DBPassword As System.Windows.Forms.TextBox
    Friend WithEvents DBName As System.Windows.Forms.TextBox
    Friend WithEvents DBUsername As System.Windows.Forms.TextBox
    Friend WithEvents Label_DBPassword As System.Windows.Forms.Label
    Friend WithEvents Label_DBName As System.Windows.Forms.Label
    Friend WithEvents Label_DBUsername As System.Windows.Forms.Label

End Class
