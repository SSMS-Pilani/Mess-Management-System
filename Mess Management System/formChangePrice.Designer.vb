<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formChangePrice
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbItem_ID = New System.Windows.Forms.TextBox()
        Me.tbItem_Name = New System.Windows.Forms.TextBox()
        Me.tb_O_SP = New System.Windows.Forms.TextBox()
        Me.tb_O_Tax = New System.Windows.Forms.TextBox()
        Me.tb_N_SP = New System.Windows.Forms.TextBox()
        Me.tb_N_Tax = New System.Windows.Forms.TextBox()
        Me.Confirm = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Label1.Location = New System.Drawing.Point(23, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Item ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Label2.Location = New System.Drawing.Point(23, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Item Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Label3.Location = New System.Drawing.Point(22, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Orignal SP"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Label4.Location = New System.Drawing.Point(22, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Orignal Tax"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Label5.Location = New System.Drawing.Point(22, 164)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "New SP"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Label6.Location = New System.Drawing.Point(22, 199)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "New Tax"
        '
        'tbItem_ID
        '
        Me.tbItem_ID.Location = New System.Drawing.Point(130, 24)
        Me.tbItem_ID.Name = "tbItem_ID"
        Me.tbItem_ID.Size = New System.Drawing.Size(100, 20)
        Me.tbItem_ID.TabIndex = 6
        '
        'tbItem_Name
        '
        Me.tbItem_Name.Enabled = False
        Me.tbItem_Name.Location = New System.Drawing.Point(130, 61)
        Me.tbItem_Name.Name = "tbItem_Name"
        Me.tbItem_Name.ReadOnly = True
        Me.tbItem_Name.Size = New System.Drawing.Size(100, 20)
        Me.tbItem_Name.TabIndex = 7
        '
        'tb_O_SP
        '
        Me.tb_O_SP.Enabled = False
        Me.tb_O_SP.Location = New System.Drawing.Point(130, 96)
        Me.tb_O_SP.Name = "tb_O_SP"
        Me.tb_O_SP.ReadOnly = True
        Me.tb_O_SP.Size = New System.Drawing.Size(100, 20)
        Me.tb_O_SP.TabIndex = 8
        '
        'tb_O_Tax
        '
        Me.tb_O_Tax.Enabled = False
        Me.tb_O_Tax.Location = New System.Drawing.Point(130, 130)
        Me.tb_O_Tax.Name = "tb_O_Tax"
        Me.tb_O_Tax.ReadOnly = True
        Me.tb_O_Tax.Size = New System.Drawing.Size(100, 20)
        Me.tb_O_Tax.TabIndex = 9
        '
        'tb_N_SP
        '
        Me.tb_N_SP.Enabled = False
        Me.tb_N_SP.Location = New System.Drawing.Point(130, 164)
        Me.tb_N_SP.Name = "tb_N_SP"
        Me.tb_N_SP.ReadOnly = True
        Me.tb_N_SP.Size = New System.Drawing.Size(100, 20)
        Me.tb_N_SP.TabIndex = 10
        '
        'tb_N_Tax
        '
        Me.tb_N_Tax.Enabled = False
        Me.tb_N_Tax.Location = New System.Drawing.Point(130, 199)
        Me.tb_N_Tax.Name = "tb_N_Tax"
        Me.tb_N_Tax.ReadOnly = True
        Me.tb_N_Tax.Size = New System.Drawing.Size(100, 20)
        Me.tb_N_Tax.TabIndex = 11
        '
        'Confirm
        '
        Me.Confirm.Location = New System.Drawing.Point(46, 251)
        Me.Confirm.Name = "Confirm"
        Me.Confirm.Size = New System.Drawing.Size(75, 42)
        Me.Confirm.TabIndex = 12
        Me.Confirm.Text = "Confirm Change"
        Me.Confirm.UseVisualStyleBackColor = True
        '
        'Cancel
        '
        Me.Cancel.Location = New System.Drawing.Point(155, 251)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(75, 42)
        Me.Cancel.TabIndex = 13
        Me.Cancel.Text = "Cancel Change"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'formChangePrice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(284, 305)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.Confirm)
        Me.Controls.Add(Me.tb_N_Tax)
        Me.Controls.Add(Me.tb_N_SP)
        Me.Controls.Add(Me.tb_O_Tax)
        Me.Controls.Add(Me.tb_O_SP)
        Me.Controls.Add(Me.tbItem_Name)
        Me.Controls.Add(Me.tbItem_ID)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "formChangePrice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change SP/Tax"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tbItem_ID As System.Windows.Forms.TextBox
    Friend WithEvents tbItem_Name As System.Windows.Forms.TextBox
    Friend WithEvents tb_O_SP As System.Windows.Forms.TextBox
    Friend WithEvents tb_O_Tax As System.Windows.Forms.TextBox
    Friend WithEvents tb_N_SP As System.Windows.Forms.TextBox
    Friend WithEvents tb_N_Tax As System.Windows.Forms.TextBox
    Friend WithEvents Confirm As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button
End Class
