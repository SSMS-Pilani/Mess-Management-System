<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formMonthlyBill
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
        Me.Gen_Excel = New System.Windows.Forms.Button()
        Me.Rebate = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.SuspendLayout()
        '
        'Gen_Excel
        '
        Me.Gen_Excel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Gen_Excel.Location = New System.Drawing.Point(182, 304)
        Me.Gen_Excel.Name = "Gen_Excel"
        Me.Gen_Excel.Size = New System.Drawing.Size(146, 56)
        Me.Gen_Excel.TabIndex = 5
        Me.Gen_Excel.Text = "Generate Bill" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Excel)"
        Me.Gen_Excel.UseVisualStyleBackColor = True
        '
        'Rebate
        '
        Me.Rebate.Location = New System.Drawing.Point(353, 47)
        Me.Rebate.Name = "Rebate"
        Me.Rebate.Size = New System.Drawing.Size(100, 20)
        Me.Rebate.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(269, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Rebate (in Rs.)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label3.Location = New System.Drawing.Point(269, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(170, 13)
        Me.Label3.TabIndex = 102
        Me.Label3.Text = "(If Left unchanged, will take ZERO)"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(18, 232)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(489, 46)
        Me.ProgressBar1.Step = 1
        Me.ProgressBar1.TabIndex = 103
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(272, 109)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(207, 20)
        Me.DateTimePicker1.TabIndex = 104
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(272, 149)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(208, 20)
        Me.DateTimePicker2.TabIndex = 105
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label2.Location = New System.Drawing.Point(34, 197)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(394, 16)
        Me.Label2.TabIndex = 101
        Me.Label2.Text = "Select Proper Month In the above Calender and Press The Button"
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(18, 18)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 100
        '
        'formMonthlyBill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(519, 384)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Rebate)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.Gen_Excel)
        Me.Name = "formMonthlyBill"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Generate Monthly Bill "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Gen_Excel As System.Windows.Forms.Button
    Friend WithEvents Rebate As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
End Class
