<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formAddSupplier
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
        Me.Sup_ID = New System.Windows.Forms.TextBox()
        Me.Sup_Name = New System.Windows.Forms.TextBox()
        Me.Sup_Address = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Confirm = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Sup_ID
        '
        Me.Sup_ID.Location = New System.Drawing.Point(244, 33)
        Me.Sup_ID.Name = "Sup_ID"
        Me.Sup_ID.Size = New System.Drawing.Size(135, 20)
        Me.Sup_ID.TabIndex = 0
        '
        'Sup_Name
        '
        Me.Sup_Name.Location = New System.Drawing.Point(244, 85)
        Me.Sup_Name.Name = "Sup_Name"
        Me.Sup_Name.Size = New System.Drawing.Size(135, 20)
        Me.Sup_Name.TabIndex = 1
        '
        'Sup_Address
        '
        Me.Sup_Address.Enabled = False
        Me.Sup_Address.Location = New System.Drawing.Point(244, 149)
        Me.Sup_Address.Name = "Sup_Address"
        Me.Sup_Address.Size = New System.Drawing.Size(135, 96)
        Me.Sup_Address.TabIndex = 2
        Me.Sup_Address.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.25!)
        Me.Label1.Location = New System.Drawing.Point(48, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 22)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Supplier ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.25!)
        Me.Label2.Location = New System.Drawing.Point(48, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 22)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Supplier Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.25!)
        Me.Label3.Location = New System.Drawing.Point(48, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(147, 22)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Supplier Address"
        '
        'Confirm
        '
        Me.Confirm.Enabled = False
        Me.Confirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Confirm.Location = New System.Drawing.Point(62, 269)
        Me.Confirm.Name = "Confirm"
        Me.Confirm.Size = New System.Drawing.Size(114, 34)
        Me.Confirm.TabIndex = 6
        Me.Confirm.Text = "Confirm"
        Me.Confirm.UseVisualStyleBackColor = True
        '
        'Cancel
        '
        Me.Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.25!)
        Me.Cancel.Location = New System.Drawing.Point(244, 269)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(115, 34)
        Me.Cancel.TabIndex = 7
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'formAddSupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(414, 326)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.Confirm)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Sup_Address)
        Me.Controls.Add(Me.Sup_Name)
        Me.Controls.Add(Me.Sup_ID)
        Me.Name = "formAddSupplier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Supplier"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Sup_ID As System.Windows.Forms.TextBox
    Friend WithEvents Sup_Name As System.Windows.Forms.TextBox
    Friend WithEvents Sup_Address As System.Windows.Forms.RichTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Confirm As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button
End Class
