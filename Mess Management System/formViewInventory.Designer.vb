<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formViewInventory
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ITEM_ID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.ShowEditingIcon = False
        Me.DataGridView1.Size = New System.Drawing.Size(332, 372)
        Me.DataGridView1.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Button1.Location = New System.Drawing.Point(380, 217)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 37)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Submit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Button2.Location = New System.Drawing.Point(499, 217)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(91, 37)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Close"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ITEM_ID
        '
        Me.ITEM_ID.Location = New System.Drawing.Point(473, 163)
        Me.ITEM_ID.Name = "ITEM_ID"
        Me.ITEM_ID.Size = New System.Drawing.Size(100, 20)
        Me.ITEM_ID.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Label1.Location = New System.Drawing.Point(389, 163)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "ITEM ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.GhostWhite
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label2.Location = New System.Drawing.Point(350, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(291, 16)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "For All The Items at once, Leave ITEM_ID Blank"
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.Button3.Location = New System.Drawing.Point(437, 281)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(99, 46)
        Me.Button3.TabIndex = 16
        Me.Button3.Text = "Print Store Summary"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'formViewInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(647, 396)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ITEM_ID)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "formViewInventory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "View Inventory"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ITEM_ID As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
End Class
