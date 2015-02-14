<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formCashCalc
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
        Me.tbCash_Given = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tbCash_Given
        '
        Me.tbCash_Given.Location = New System.Drawing.Point(24, 67)
        Me.tbCash_Given.Name = "tbCash_Given"
        Me.tbCash_Given.Size = New System.Drawing.Size(159, 20)
        Me.tbCash_Given.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.25!)
        Me.Label1.Location = New System.Drawing.Point(21, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 22)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Enter Cash Given :"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(45, 107)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 22)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Confirm"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'formCashCalc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(207, 141)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbCash_Given)
        Me.Name = "formCashCalc"
        Me.Text = "Cash Given :"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbCash_Given As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
