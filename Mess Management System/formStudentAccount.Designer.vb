<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formStudentAccount
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.S_ID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblNAME = New System.Windows.Forms.Label()
        Me.lblROOM = New System.Windows.Forms.Label()
        Me.lblBHAWAN = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblStudent_Account = New System.Windows.Forms.Label()
        Me.lblIDNO = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(52, 24)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.ShowEditingIcon = False
        Me.DataGridView1.Size = New System.Drawing.Size(897, 408)
        Me.DataGridView1.TabIndex = 10000
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(325, 455)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 2
        '
        'S_ID
        '
        Me.S_ID.Location = New System.Drawing.Point(153, 452)
        Me.S_ID.Name = "S_ID"
        Me.S_ID.Size = New System.Drawing.Size(101, 20)
        Me.S_ID.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(72, 455)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "S_ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(72, 486)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "NAME"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(72, 551)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "ROOM NO."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(72, 589)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "BHAWAN"
        '
        'lblNAME
        '
        Me.lblNAME.AutoSize = True
        Me.lblNAME.Location = New System.Drawing.Point(150, 486)
        Me.lblNAME.Name = "lblNAME"
        Me.lblNAME.Size = New System.Drawing.Size(0, 13)
        Me.lblNAME.TabIndex = 8
        '
        'lblROOM
        '
        Me.lblROOM.AutoSize = True
        Me.lblROOM.Location = New System.Drawing.Point(150, 551)
        Me.lblROOM.Name = "lblROOM"
        Me.lblROOM.Size = New System.Drawing.Size(0, 13)
        Me.lblROOM.TabIndex = 9
        '
        'lblBHAWAN
        '
        Me.lblBHAWAN.AutoSize = True
        Me.lblBHAWAN.Location = New System.Drawing.Point(150, 589)
        Me.lblBHAWAN.Name = "lblBHAWAN"
        Me.lblBHAWAN.Size = New System.Drawing.Size(0, 13)
        Me.lblBHAWAN.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label8.Location = New System.Drawing.Point(580, 517)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(269, 20)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "MONTHLY MESS EXTRAS :    Rs."
        '
        'lblStudent_Account
        '
        Me.lblStudent_Account.AutoSize = True
        Me.lblStudent_Account.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.lblStudent_Account.Location = New System.Drawing.Point(901, 515)
        Me.lblStudent_Account.Name = "lblStudent_Account"
        Me.lblStudent_Account.Size = New System.Drawing.Size(0, 20)
        Me.lblStudent_Account.TabIndex = 12
        '
        'lblIDNO
        '
        Me.lblIDNO.AutoSize = True
        Me.lblIDNO.Location = New System.Drawing.Point(150, 520)
        Me.lblIDNO.Name = "lblIDNO"
        Me.lblIDNO.Size = New System.Drawing.Size(0, 13)
        Me.lblIDNO.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(72, 520)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "IDNO"
        '
        'formStudentAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1001, 693)
        Me.Controls.Add(Me.lblIDNO)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblStudent_Account)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblBHAWAN)
        Me.Controls.Add(Me.lblROOM)
        Me.Controls.Add(Me.lblNAME)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.S_ID)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "formStudentAccount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "View Student Account"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents S_ID As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblNAME As System.Windows.Forms.Label
    Friend WithEvents lblROOM As System.Windows.Forms.Label
    Friend WithEvents lblBHAWAN As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblStudent_Account As System.Windows.Forms.Label
    Friend WithEvents lblIDNO As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
