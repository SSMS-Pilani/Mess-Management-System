<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formBlock
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
        Me.S_ID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Block = New System.Windows.Forms.Button()
        Me.Unblock = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(267, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.ShowEditingIcon = False
        Me.DataGridView1.Size = New System.Drawing.Size(397, 369)
        Me.DataGridView1.TabIndex = 100
        '
        'S_ID
        '
        Me.S_ID.Location = New System.Drawing.Point(127, 118)
        Me.S_ID.Name = "S_ID"
        Me.S_ID.Size = New System.Drawing.Size(100, 20)
        Me.S_ID.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Label1.Location = New System.Drawing.Point(41, 118)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "S_ID"
        '
        'Block
        '
        Me.Block.Location = New System.Drawing.Point(24, 204)
        Me.Block.Name = "Block"
        Me.Block.Size = New System.Drawing.Size(75, 23)
        Me.Block.TabIndex = 3
        Me.Block.Text = "BLOCK"
        Me.Block.UseVisualStyleBackColor = True
        '
        'Unblock
        '
        Me.Unblock.Location = New System.Drawing.Point(152, 204)
        Me.Unblock.Name = "Unblock"
        Me.Unblock.Size = New System.Drawing.Size(75, 23)
        Me.Unblock.TabIndex = 4
        Me.Unblock.Text = "UNBLOCK"
        Me.Unblock.UseVisualStyleBackColor = True
        '
        'Cancel
        '
        Me.Cancel.Location = New System.Drawing.Point(88, 264)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(75, 23)
        Me.Cancel.TabIndex = 5
        Me.Cancel.Text = "CANCEL"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'formBlock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(677, 393)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.Unblock)
        Me.Controls.Add(Me.Block)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.S_ID)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "formBlock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Block/UnBlock Student"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents S_ID As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Block As System.Windows.Forms.Button
    Friend WithEvents Unblock As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button
End Class
