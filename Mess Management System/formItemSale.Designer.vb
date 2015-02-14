<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formItemSale
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
        Me.Submit = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ITEM_ID = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Print = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(24, 41)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.ShowEditingIcon = False
        Me.DataGridView1.Size = New System.Drawing.Size(342, 310)
        Me.DataGridView1.TabIndex = 100
        '
        'Submit
        '
        Me.Submit.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.Submit.Location = New System.Drawing.Point(375, 224)
        Me.Submit.Name = "Submit"
        Me.Submit.Size = New System.Drawing.Size(103, 34)
        Me.Submit.TabIndex = 4
        Me.Submit.Text = "Submit"
        Me.Submit.UseVisualStyleBackColor = True
        '
        'Cancel
        '
        Me.Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.Cancel.Location = New System.Drawing.Point(534, 224)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(107, 34)
        Me.Cancel.TabIndex = 5
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(391, 143)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Start Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(391, 186)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 102
        Me.Label2.Text = "End Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(391, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 104
        Me.Label3.Text = "ITEM ID"
        '
        'ITEM_ID
        '
        Me.ITEM_ID.Location = New System.Drawing.Point(473, 75)
        Me.ITEM_ID.Name = "ITEM_ID"
        Me.ITEM_ID.Size = New System.Drawing.Size(168, 20)
        Me.ITEM_ID.TabIndex = 1
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(473, 137)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(168, 20)
        Me.DateTimePicker1.TabIndex = 1
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(473, 180)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(168, 20)
        Me.DateTimePicker2.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Label4.ForeColor = System.Drawing.Color.Maroon
        Me.Label4.Location = New System.Drawing.Point(112, 402)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(423, 17)
        Me.Label4.TabIndex = 107
        Me.Label4.Text = "PRINT SUMMARY prints all the Data Currently Shown in the Table"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Label5.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label5.Location = New System.Drawing.Point(372, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(269, 17)
        Me.Label5.TabIndex = 108
        Me.Label5.Text = "For All Items at once, Leave Item ID Blank"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PrintDocument1
        '
        '
        'Print
        '
        Me.Print.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Print.Location = New System.Drawing.Point(432, 354)
        Me.Print.Name = "Print"
        Me.Print.Size = New System.Drawing.Size(144, 34)
        Me.Print.TabIndex = 109
        Me.Print.Text = "PRINT SUMMARY"
        Me.Print.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Label6.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label6.Location = New System.Drawing.Point(59, 435)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(530, 17)
        Me.Label6.TabIndex = 110
        Me.Label6.Text = "The Data Shown above is inclusive of the Start Date And Exclusive of the End Date" & _
    ""
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label7.Location = New System.Drawing.Point(390, 295)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(175, 20)
        Me.Label7.TabIndex = 111
        Me.Label7.Text = "Grand Total Sale : Rs."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Label8.Location = New System.Drawing.Point(571, 297)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 17)
        Me.Label8.TabIndex = 112
        Me.Label8.Text = "********"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(391, 315)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(139, 13)
        Me.Label9.TabIndex = 113
        Me.Label9.Text = "(Within the Selected Period)"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(452, 107)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(141, 17)
        Me.CheckBox1.TabIndex = 114
        Me.CheckBox1.Text = "Month-End Summary"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(391, 47)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 13)
        Me.Label10.TabIndex = 116
        Me.Label10.Text = "Supplier ID"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(473, 44)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(168, 20)
        Me.TextBox1.TabIndex = 0
        '
        'formItemSale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(666, 466)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Print)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ITEM_ID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.Submit)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "formItemSale"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Item Sale Summary"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Submit As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ITEM_ID As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents Print As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
