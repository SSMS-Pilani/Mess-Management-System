<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formDeleteStudentTakes
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
        Me.Bill_ID = New System.Windows.Forms.TextBox()
        Me.T_ID = New System.Windows.Forms.TextBox()
        Me.Description = New System.Windows.Forms.RichTextBox()
        Me.Confirm = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.25!)
        Me.Label1.Location = New System.Drawing.Point(22, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "BILL ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.25!)
        Me.Label2.Location = New System.Drawing.Point(22, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(235, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Transaction ID (1-5)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.25!)
        Me.Label3.Location = New System.Drawing.Point(22, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(257, 29)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Description (Optional)"
        '
        'Bill_ID
        '
        Me.Bill_ID.Location = New System.Drawing.Point(323, 33)
        Me.Bill_ID.Name = "Bill_ID"
        Me.Bill_ID.Size = New System.Drawing.Size(169, 20)
        Me.Bill_ID.TabIndex = 3
        '
        'T_ID
        '
        Me.T_ID.Enabled = False
        Me.T_ID.Location = New System.Drawing.Point(323, 90)
        Me.T_ID.Name = "T_ID"
        Me.T_ID.Size = New System.Drawing.Size(169, 20)
        Me.T_ID.TabIndex = 4
        '
        'Description
        '
        Me.Description.Enabled = False
        Me.Description.Location = New System.Drawing.Point(323, 147)
        Me.Description.Name = "Description"
        Me.Description.Size = New System.Drawing.Size(169, 96)
        Me.Description.TabIndex = 5
        Me.Description.Text = ""
        '
        'Confirm
        '
        Me.Confirm.Location = New System.Drawing.Point(93, 267)
        Me.Confirm.Name = "Confirm"
        Me.Confirm.Size = New System.Drawing.Size(126, 39)
        Me.Confirm.TabIndex = 6
        Me.Confirm.Text = "Confirm Delete"
        Me.Confirm.UseVisualStyleBackColor = True
        '
        'Cancel
        '
        Me.Cancel.Location = New System.Drawing.Point(313, 267)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(126, 39)
        Me.Cancel.TabIndex = 7
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'formDeleteStudentTakes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(556, 318)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.Confirm)
        Me.Controls.Add(Me.Description)
        Me.Controls.Add(Me.T_ID)
        Me.Controls.Add(Me.Bill_ID)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "formDeleteStudentTakes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Delete Student Takes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Bill_ID As System.Windows.Forms.TextBox
    Friend WithEvents T_ID As System.Windows.Forms.TextBox
    Friend WithEvents Description As System.Windows.Forms.RichTextBox
    Friend WithEvents Confirm As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button
End Class
