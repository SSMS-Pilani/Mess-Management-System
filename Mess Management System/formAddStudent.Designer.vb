<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formAddStudent
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Student_Complete_Id = New System.Windows.Forms.TextBox()
        Me.Student_Short_Id = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Student_Name = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.Confirm = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Student_Room = New System.Windows.Forms.TextBox()
        Me.Student_Bhawan = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.25!)
        Me.Label2.Location = New System.Drawing.Point(12, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(175, 22)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Student Complete ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.25!)
        Me.Label1.Location = New System.Drawing.Point(12, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 22)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Student Short ID"
        '
        'Student_Complete_Id
        '
        Me.Student_Complete_Id.Location = New System.Drawing.Point(208, 89)
        Me.Student_Complete_Id.Name = "Student_Complete_Id"
        Me.Student_Complete_Id.Size = New System.Drawing.Size(135, 20)
        Me.Student_Complete_Id.TabIndex = 6
        '
        'Student_Short_Id
        '
        Me.Student_Short_Id.Location = New System.Drawing.Point(208, 37)
        Me.Student_Short_Id.Name = "Student_Short_Id"
        Me.Student_Short_Id.Size = New System.Drawing.Size(135, 20)
        Me.Student_Short_Id.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.25!)
        Me.Label3.Location = New System.Drawing.Point(19, 226)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 22)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Bhawan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.25!)
        Me.Label4.Location = New System.Drawing.Point(12, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(158, 22)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Student Full Name"
        '
        'Student_Name
        '
        Me.Student_Name.Location = New System.Drawing.Point(208, 138)
        Me.Student_Name.Name = "Student_Name"
        Me.Student_Name.Size = New System.Drawing.Size(135, 20)
        Me.Student_Name.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.25!)
        Me.Label5.Location = New System.Drawing.Point(19, 186)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 22)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Room Number"
        '
        'Cancel
        '
        Me.Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.25!)
        Me.Cancel.Location = New System.Drawing.Point(228, 278)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(115, 34)
        Me.Cancel.TabIndex = 16
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'Confirm
        '
        Me.Confirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Confirm.Location = New System.Drawing.Point(23, 279)
        Me.Confirm.Name = "Confirm"
        Me.Confirm.Size = New System.Drawing.Size(114, 34)
        Me.Confirm.TabIndex = 15
        Me.Confirm.Text = "Confirm"
        Me.Confirm.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(20, 59)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "(e.g. F2014623P)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(20, 111)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "(e.g.2014A2PS623P)"
        '
        'Student_Room
        '
        Me.Student_Room.Location = New System.Drawing.Point(208, 186)
        Me.Student_Room.Name = "Student_Room"
        Me.Student_Room.Size = New System.Drawing.Size(135, 20)
        Me.Student_Room.TabIndex = 13
        '
        'Student_Bhawan
        '
        Me.Student_Bhawan.FormattingEnabled = True
        Me.Student_Bhawan.Location = New System.Drawing.Point(208, 226)
        Me.Student_Bhawan.Name = "Student_Bhawan"
        Me.Student_Bhawan.Size = New System.Drawing.Size(135, 21)
        Me.Student_Bhawan.TabIndex = 19
        '
        'formAddStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 315)
        Me.Controls.Add(Me.Student_Bhawan)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.Confirm)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Student_Room)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Student_Name)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Student_Complete_Id)
        Me.Controls.Add(Me.Student_Short_Id)
        Me.Name = "formAddStudent"
        Me.Text = "Add Student"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Student_Complete_Id As System.Windows.Forms.TextBox
    Friend WithEvents Student_Short_Id As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Student_Name As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Cancel As System.Windows.Forms.Button
    Friend WithEvents Confirm As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Student_Room As System.Windows.Forms.TextBox
    Friend WithEvents Student_Bhawan As System.Windows.Forms.ComboBox
End Class
