<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formRebate
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
        Me.S_ID = New System.Windows.Forms.TextBox()
        Me.tbName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Confirm = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tb_Meals_not_taken = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'S_ID
        '
        Me.S_ID.Location = New System.Drawing.Point(175, 18)
        Me.S_ID.Name = "S_ID"
        Me.S_ID.Size = New System.Drawing.Size(141, 20)
        Me.S_ID.TabIndex = 0
        '
        'tbName
        '
        Me.tbName.Location = New System.Drawing.Point(175, 54)
        Me.tbName.Name = "tbName"
        Me.tbName.ReadOnly = True
        Me.tbName.Size = New System.Drawing.Size(141, 20)
        Me.tbName.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Label1.Location = New System.Drawing.Point(22, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "S_ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Label2.Location = New System.Drawing.Point(22, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "NAME"
        '
        'Confirm
        '
        Me.Confirm.Location = New System.Drawing.Point(27, 145)
        Me.Confirm.Name = "Confirm"
        Me.Confirm.Size = New System.Drawing.Size(104, 35)
        Me.Confirm.TabIndex = 12
        Me.Confirm.Text = "Confirm"
        Me.Confirm.UseVisualStyleBackColor = True
        '
        'Cancel
        '
        Me.Cancel.Location = New System.Drawing.Point(186, 145)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(104, 35)
        Me.Cancel.TabIndex = 13
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Label3.Location = New System.Drawing.Point(22, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 17)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "MEALS NOT TAKEN"
        '
        'tb_Meals_not_taken
        '
        Me.tb_Meals_not_taken.Location = New System.Drawing.Point(175, 96)
        Me.tb_Meals_not_taken.Name = "tb_Meals_not_taken"
        Me.tb_Meals_not_taken.ReadOnly = True
        Me.tb_Meals_not_taken.Size = New System.Drawing.Size(141, 20)
        Me.tb_Meals_not_taken.TabIndex = 14
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(346, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.ShowEditingIcon = False
        Me.DataGridView1.Size = New System.Drawing.Size(491, 371)
        Me.DataGridView1.TabIndex = 16
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(63, 215)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 17
        '
        'formRebate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(852, 404)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tb_Meals_not_taken)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.Confirm)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbName)
        Me.Controls.Add(Me.S_ID)
        Me.Name = "formRebate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rebate Entry"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents S_ID As System.Windows.Forms.TextBox
    Friend WithEvents tbName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Confirm As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tb_Meals_not_taken As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
End Class
