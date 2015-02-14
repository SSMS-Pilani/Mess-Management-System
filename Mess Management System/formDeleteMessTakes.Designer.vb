<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formDeleteMessTakes
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.T_ID = New System.Windows.Forms.TextBox()
        Me.Confirm = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.Description = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label2.Location = New System.Drawing.Point(40, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "T_ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label3.Location = New System.Drawing.Point(40, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Description"
        '
        'T_ID
        '
        Me.T_ID.Location = New System.Drawing.Point(166, 41)
        Me.T_ID.Name = "T_ID"
        Me.T_ID.Size = New System.Drawing.Size(149, 20)
        Me.T_ID.TabIndex = 4
        '
        'Confirm
        '
        Me.Confirm.Location = New System.Drawing.Point(44, 217)
        Me.Confirm.Name = "Confirm"
        Me.Confirm.Size = New System.Drawing.Size(117, 43)
        Me.Confirm.TabIndex = 6
        Me.Confirm.Text = "Confirm Delete"
        Me.Confirm.UseVisualStyleBackColor = True
        '
        'Cancel
        '
        Me.Cancel.Location = New System.Drawing.Point(188, 217)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(105, 43)
        Me.Cancel.TabIndex = 7
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'Description
        '
        Me.Description.Location = New System.Drawing.Point(166, 85)
        Me.Description.Name = "Description"
        Me.Description.Size = New System.Drawing.Size(149, 110)
        Me.Description.TabIndex = 8
        Me.Description.Text = ""
        '
        'formDeleteMessTakes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(372, 272)
        Me.Controls.Add(Me.Description)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.Confirm)
        Me.Controls.Add(Me.T_ID)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "formDeleteMessTakes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Delete Mess Takes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents T_ID As System.Windows.Forms.TextBox
    Friend WithEvents Confirm As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button
    Friend WithEvents Description As System.Windows.Forms.RichTextBox
End Class
