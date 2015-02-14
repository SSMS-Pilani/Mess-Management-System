<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formMonthlyCap
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
        Me.tbS_ID = New System.Windows.Forms.TextBox()
        Me.tbCAP = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Confirm = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'tbS_ID
        '
        Me.tbS_ID.Location = New System.Drawing.Point(145, 25)
        Me.tbS_ID.Name = "tbS_ID"
        Me.tbS_ID.Size = New System.Drawing.Size(108, 20)
        Me.tbS_ID.TabIndex = 0
        '
        'tbCAP
        '
        Me.tbCAP.Location = New System.Drawing.Point(145, 87)
        Me.tbCAP.Name = "tbCAP"
        Me.tbCAP.ReadOnly = True
        Me.tbCAP.Size = New System.Drawing.Size(108, 20)
        Me.tbCAP.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(44, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "S_ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(44, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "MONTHLY CAP"
        '
        'Confirm
        '
        Me.Confirm.Enabled = False
        Me.Confirm.Location = New System.Drawing.Point(47, 135)
        Me.Confirm.Name = "Confirm"
        Me.Confirm.Size = New System.Drawing.Size(75, 23)
        Me.Confirm.TabIndex = 5
        Me.Confirm.Text = "Confirm"
        Me.Confirm.UseVisualStyleBackColor = True
        '
        'Cancel
        '
        Me.Cancel.Location = New System.Drawing.Point(155, 135)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(75, 23)
        Me.Cancel.TabIndex = 6
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Current MONTHLY CAP : "
        Me.Label3.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(150, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 13)
        Me.Label4.TabIndex = 8
        '
        'formMonthlyCap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 185)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.Confirm)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbCAP)
        Me.Controls.Add(Me.tbS_ID)
        Me.Name = "formMonthlyCap"
        Me.Text = "Monthly Cap"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbS_ID As System.Windows.Forms.TextBox
    Friend WithEvents tbCAP As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Confirm As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
