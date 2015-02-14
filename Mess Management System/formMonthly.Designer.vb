<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formMonthly
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
        Me.tbItemId = New System.Windows.Forms.TextBox()
        Me.tbNewPrice = New System.Windows.Forms.TextBox()
        Me.Confirm_Change = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.S_ID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.sname = New System.Windows.Forms.Label()
        Me.room = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.change_visiblity = New System.Windows.Forms.Button()
        Me.Confirm_Details = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.item_0 = New System.Windows.Forms.Button()
        Me.item_1 = New System.Windows.Forms.Button()
        Me.item_2 = New System.Windows.Forms.Button()
        Me.item_5 = New System.Windows.Forms.Button()
        Me.item_4 = New System.Windows.Forms.Button()
        Me.item_3 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SaturdayButton = New System.Windows.Forms.Button()
        Me.FridayButton = New System.Windows.Forms.Button()
        Me.ThursdayButton = New System.Windows.Forms.Button()
        Me.WednesdayButton = New System.Windows.Forms.Button()
        Me.MondayButton = New System.Windows.Forms.Button()
        Me.SundayButton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbItemId
        '
        Me.tbItemId.Location = New System.Drawing.Point(136, 46)
        Me.tbItemId.Name = "tbItemId"
        Me.tbItemId.Size = New System.Drawing.Size(100, 20)
        Me.tbItemId.TabIndex = 0
        '
        'tbNewPrice
        '
        Me.tbNewPrice.Location = New System.Drawing.Point(138, 117)
        Me.tbNewPrice.Name = "tbNewPrice"
        Me.tbNewPrice.ReadOnly = True
        Me.tbNewPrice.Size = New System.Drawing.Size(100, 20)
        Me.tbNewPrice.TabIndex = 1
        '
        'Confirm_Change
        '
        Me.Confirm_Change.Location = New System.Drawing.Point(35, 159)
        Me.Confirm_Change.Name = "Confirm_Change"
        Me.Confirm_Change.Size = New System.Drawing.Size(75, 23)
        Me.Confirm_Change.TabIndex = 2
        Me.Confirm_Change.Text = "Confirm"
        Me.Confirm_Change.UseVisualStyleBackColor = True
        '
        'Cancel
        '
        Me.Cancel.Location = New System.Drawing.Point(151, 159)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(75, 23)
        Me.Cancel.TabIndex = 3
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(35, 51)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 13)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "ITEM(0-9) / Day"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(26, 120)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(97, 13)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "New Price Per Day"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(138, 83)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(100, 20)
        Me.TextBox5.TabIndex = 6
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(18, 87)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(109, 13)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "Current Price Per Day"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Cancel)
        Me.GroupBox1.Controls.Add(Me.Confirm_Change)
        Me.GroupBox1.Controls.Add(Me.tbNewPrice)
        Me.GroupBox1.Controls.Add(Me.tbItemId)
        Me.GroupBox1.Location = New System.Drawing.Point(296, 66)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(252, 196)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Change Price"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "S_ID"
        '
        'S_ID
        '
        Me.S_ID.Location = New System.Drawing.Point(76, 24)
        Me.S_ID.Name = "S_ID"
        Me.S_ID.Size = New System.Drawing.Size(100, 20)
        Me.S_ID.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "NAME"
        '
        'sname
        '
        Me.sname.AutoSize = True
        Me.sname.Location = New System.Drawing.Point(73, 90)
        Me.sname.Name = "sname"
        Me.sname.Size = New System.Drawing.Size(0, 13)
        Me.sname.TabIndex = 21
        '
        'room
        '
        Me.room.AutoSize = True
        Me.room.Location = New System.Drawing.Point(73, 128)
        Me.room.Name = "room"
        Me.room.Size = New System.Drawing.Size(0, 13)
        Me.room.TabIndex = 23
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 128)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "ROOM NO."
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(146, 55)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(119, 20)
        Me.DateTimePicker1.TabIndex = 24
        '
        'change_visiblity
        '
        Me.change_visiblity.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.change_visiblity.Location = New System.Drawing.Point(296, 13)
        Me.change_visiblity.Name = "change_visiblity"
        Me.change_visiblity.Size = New System.Drawing.Size(145, 40)
        Me.change_visiblity.TabIndex = 25
        Me.change_visiblity.Text = "Change/Add Price"
        Me.change_visiblity.UseVisualStyleBackColor = True
        '
        'Confirm_Details
        '
        Me.Confirm_Details.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.Confirm_Details.Location = New System.Drawing.Point(12, 393)
        Me.Confirm_Details.Name = "Confirm_Details"
        Me.Confirm_Details.Size = New System.Drawing.Size(117, 40)
        Me.Confirm_Details.TabIndex = 26
        Me.Confirm_Details.Text = "Confirm"
        Me.Confirm_Details.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.Button3.Location = New System.Drawing.Point(153, 392)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(122, 40)
        Me.Button3.TabIndex = 27
        Me.Button3.Text = "Cancel"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 58)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 13)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Select Proper Month"
        '
        'item_0
        '
        Me.item_0.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.item_0.Location = New System.Drawing.Point(12, 177)
        Me.item_0.Name = "item_0"
        Me.item_0.Size = New System.Drawing.Size(73, 28)
        Me.item_0.TabIndex = 29
        Me.item_0.Text = "ITEM_0"
        Me.item_0.UseVisualStyleBackColor = True
        '
        'item_1
        '
        Me.item_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.item_1.Location = New System.Drawing.Point(114, 177)
        Me.item_1.Name = "item_1"
        Me.item_1.Size = New System.Drawing.Size(73, 28)
        Me.item_1.TabIndex = 30
        Me.item_1.Text = "ITEM_1"
        Me.item_1.UseVisualStyleBackColor = True
        '
        'item_2
        '
        Me.item_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.item_2.Location = New System.Drawing.Point(214, 178)
        Me.item_2.Name = "item_2"
        Me.item_2.Size = New System.Drawing.Size(73, 28)
        Me.item_2.TabIndex = 31
        Me.item_2.Text = "ITEM_2"
        Me.item_2.UseVisualStyleBackColor = True
        '
        'item_5
        '
        Me.item_5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.item_5.Location = New System.Drawing.Point(214, 221)
        Me.item_5.Name = "item_5"
        Me.item_5.Size = New System.Drawing.Size(73, 28)
        Me.item_5.TabIndex = 34
        Me.item_5.Text = "ITEM_5"
        Me.item_5.UseVisualStyleBackColor = True
        '
        'item_4
        '
        Me.item_4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.item_4.Location = New System.Drawing.Point(114, 220)
        Me.item_4.Name = "item_4"
        Me.item_4.Size = New System.Drawing.Size(73, 28)
        Me.item_4.TabIndex = 33
        Me.item_4.Text = "ITEM_4"
        Me.item_4.UseVisualStyleBackColor = True
        '
        'item_3
        '
        Me.item_3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.item_3.Location = New System.Drawing.Point(12, 220)
        Me.item_3.Name = "item_3"
        Me.item_3.Size = New System.Drawing.Size(73, 28)
        Me.item_3.TabIndex = 32
        Me.item_3.Text = "ITEM_3"
        Me.item_3.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "ROOM NO."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(73, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 13)
        Me.Label4.TabIndex = 23
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(102, 128)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 13)
        Me.Label7.TabIndex = 23
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label8.Location = New System.Drawing.Point(310, 272)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(238, 26)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "Note: For DAILY BASIC Put the ITEM as 11 and " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "For REBATE AMOUNT Put the ITEM as " & _
    "12"
        '
        'SaturdayButton
        '
        Me.SaturdayButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.SaturdayButton.Location = New System.Drawing.Point(216, 311)
        Me.SaturdayButton.Name = "SaturdayButton"
        Me.SaturdayButton.Size = New System.Drawing.Size(73, 28)
        Me.SaturdayButton.TabIndex = 41
        Me.SaturdayButton.Text = "Saturday"
        Me.SaturdayButton.UseVisualStyleBackColor = True
        '
        'FridayButton
        '
        Me.FridayButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.FridayButton.Location = New System.Drawing.Point(116, 310)
        Me.FridayButton.Name = "FridayButton"
        Me.FridayButton.Size = New System.Drawing.Size(73, 28)
        Me.FridayButton.TabIndex = 40
        Me.FridayButton.Text = "Friday"
        Me.FridayButton.UseVisualStyleBackColor = True
        '
        'ThursdayButton
        '
        Me.ThursdayButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.ThursdayButton.Location = New System.Drawing.Point(14, 310)
        Me.ThursdayButton.Name = "ThursdayButton"
        Me.ThursdayButton.Size = New System.Drawing.Size(73, 28)
        Me.ThursdayButton.TabIndex = 39
        Me.ThursdayButton.Text = "Thursday"
        Me.ThursdayButton.UseVisualStyleBackColor = True
        '
        'WednesdayButton
        '
        Me.WednesdayButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.WednesdayButton.Location = New System.Drawing.Point(216, 268)
        Me.WednesdayButton.Name = "WednesdayButton"
        Me.WednesdayButton.Size = New System.Drawing.Size(73, 28)
        Me.WednesdayButton.TabIndex = 38
        Me.WednesdayButton.Text = "Wednesday"
        Me.WednesdayButton.UseVisualStyleBackColor = True
        '
        'MondayButton
        '
        Me.MondayButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.MondayButton.Location = New System.Drawing.Point(116, 267)
        Me.MondayButton.Name = "MondayButton"
        Me.MondayButton.Size = New System.Drawing.Size(73, 28)
        Me.MondayButton.TabIndex = 37
        Me.MondayButton.Text = "Monday"
        Me.MondayButton.UseVisualStyleBackColor = True
        '
        'SundayButton
        '
        Me.SundayButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.SundayButton.Location = New System.Drawing.Point(14, 267)
        Me.SundayButton.Name = "SundayButton"
        Me.SundayButton.Size = New System.Drawing.Size(73, 28)
        Me.SundayButton.TabIndex = 36
        Me.SundayButton.Text = "Sunday"
        Me.SundayButton.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Button1.Location = New System.Drawing.Point(334, 316)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(171, 33)
        Me.Button1.TabIndex = 42
        Me.Button1.Text = "Show Already Signed"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(307, 364)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(230, 13)
        Me.Label12.TabIndex = 43
        Me.Label12.Text = "TOTAL No. of SIGNINGS (ITEM_1) :    "
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(307, 388)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(230, 13)
        Me.Label13.TabIndex = 44
        Me.Label13.Text = "TOTAL No. of SIGNINGS (ITEM_2) :    "
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(307, 439)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(230, 13)
        Me.Label14.TabIndex = 46
        Me.Label14.Text = "TOTAL No. of SIGNINGS (ITEM_4) :    "
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(307, 413)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(230, 13)
        Me.Label15.TabIndex = 45
        Me.Label15.Text = "TOTAL No. of SIGNINGS (ITEM_3) :    "
        '
        'formMonthly
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(568, 469)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.SaturdayButton)
        Me.Controls.Add(Me.FridayButton)
        Me.Controls.Add(Me.ThursdayButton)
        Me.Controls.Add(Me.WednesdayButton)
        Me.Controls.Add(Me.MondayButton)
        Me.Controls.Add(Me.SundayButton)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.item_5)
        Me.Controls.Add(Me.item_4)
        Me.Controls.Add(Me.item_3)
        Me.Controls.Add(Me.item_2)
        Me.Controls.Add(Me.item_1)
        Me.Controls.Add(Me.item_0)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Confirm_Details)
        Me.Controls.Add(Me.change_visiblity)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.room)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.sname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.S_ID)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "formMonthly"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Monthly Items"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbItemId As System.Windows.Forms.TextBox
    Friend WithEvents tbNewPrice As System.Windows.Forms.TextBox
    Friend WithEvents Confirm_Change As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents S_ID As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents sname As System.Windows.Forms.Label
    Friend WithEvents room As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents change_visiblity As System.Windows.Forms.Button
    Friend WithEvents Confirm_Details As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents item_0 As System.Windows.Forms.Button
    Friend WithEvents item_1 As System.Windows.Forms.Button
    Friend WithEvents item_2 As System.Windows.Forms.Button
    Friend WithEvents item_5 As System.Windows.Forms.Button
    Friend WithEvents item_4 As System.Windows.Forms.Button
    Friend WithEvents item_3 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents SaturdayButton As System.Windows.Forms.Button
    Friend WithEvents FridayButton As System.Windows.Forms.Button
    Friend WithEvents ThursdayButton As System.Windows.Forms.Button
    Friend WithEvents WednesdayButton As System.Windows.Forms.Button
    Friend WithEvents MondayButton As System.Windows.Forms.Button
    Friend WithEvents SundayButton As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
End Class
