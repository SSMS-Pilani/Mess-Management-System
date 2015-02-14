<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formAddItem
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
        Me.lblItemID = New System.Windows.Forms.Label()
        Me.lbltemName = New System.Windows.Forms.Label()
        Me.lblSupplierID = New System.Windows.Forms.Label()
        Me.lblSupplierName = New System.Windows.Forms.Label()
        Me.lblSP = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.tbItemId = New System.Windows.Forms.TextBox()
        Me.tbItemName = New System.Windows.Forms.TextBox()
        Me.tbSuppID = New System.Windows.Forms.TextBox()
        Me.tbSuppName = New System.Windows.Forms.TextBox()
        Me.tbSP = New System.Windows.Forms.TextBox()
        Me.tbTax = New System.Windows.Forms.TextBox()
        Me.Confirm = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.buttonDelete = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(27, 25)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ShowEditingIcon = False
        Me.DataGridView1.Size = New System.Drawing.Size(533, 442)
        Me.DataGridView1.TabIndex = 100
        '
        'lblItemID
        '
        Me.lblItemID.AutoSize = True
        Me.lblItemID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblItemID.Location = New System.Drawing.Point(623, 67)
        Me.lblItemID.Name = "lblItemID"
        Me.lblItemID.Size = New System.Drawing.Size(51, 17)
        Me.lblItemID.TabIndex = 1
        Me.lblItemID.Text = "Item ID"
        '
        'lbltemName
        '
        Me.lbltemName.AutoSize = True
        Me.lbltemName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lbltemName.Location = New System.Drawing.Point(623, 115)
        Me.lbltemName.Name = "lbltemName"
        Me.lbltemName.Size = New System.Drawing.Size(75, 17)
        Me.lbltemName.TabIndex = 2
        Me.lbltemName.Text = "Item Name"
        '
        'lblSupplierID
        '
        Me.lblSupplierID.AutoSize = True
        Me.lblSupplierID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblSupplierID.Location = New System.Drawing.Point(623, 164)
        Me.lblSupplierID.Name = "lblSupplierID"
        Me.lblSupplierID.Size = New System.Drawing.Size(77, 17)
        Me.lblSupplierID.TabIndex = 3
        Me.lblSupplierID.Text = "Supplier ID"
        '
        'lblSupplierName
        '
        Me.lblSupplierName.AutoSize = True
        Me.lblSupplierName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblSupplierName.Location = New System.Drawing.Point(623, 211)
        Me.lblSupplierName.Name = "lblSupplierName"
        Me.lblSupplierName.Size = New System.Drawing.Size(101, 17)
        Me.lblSupplierName.TabIndex = 4
        Me.lblSupplierName.Text = "Supplier Name"
        '
        'lblSP
        '
        Me.lblSP.AutoSize = True
        Me.lblSP.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblSP.Location = New System.Drawing.Point(623, 254)
        Me.lblSP.Name = "lblSP"
        Me.lblSP.Size = New System.Drawing.Size(26, 17)
        Me.lblSP.TabIndex = 5
        Me.lblSP.Text = "SP"
        '
        'lblTax
        '
        Me.lblTax.AutoSize = True
        Me.lblTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblTax.Location = New System.Drawing.Point(623, 299)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(72, 17)
        Me.lblTax.TabIndex = 6
        Me.lblTax.Text = "Tax (in %)"
        '
        'tbItemId
        '
        Me.tbItemId.Location = New System.Drawing.Point(733, 67)
        Me.tbItemId.Name = "tbItemId"
        Me.tbItemId.Size = New System.Drawing.Size(127, 20)
        Me.tbItemId.TabIndex = 0
        '
        'tbItemName
        '
        Me.tbItemName.Enabled = False
        Me.tbItemName.Location = New System.Drawing.Point(733, 112)
        Me.tbItemName.Name = "tbItemName"
        Me.tbItemName.ReadOnly = True
        Me.tbItemName.Size = New System.Drawing.Size(127, 20)
        Me.tbItemName.TabIndex = 1
        '
        'tbSuppID
        '
        Me.tbSuppID.Enabled = False
        Me.tbSuppID.Location = New System.Drawing.Point(733, 161)
        Me.tbSuppID.Name = "tbSuppID"
        Me.tbSuppID.ReadOnly = True
        Me.tbSuppID.Size = New System.Drawing.Size(127, 20)
        Me.tbSuppID.TabIndex = 2
        '
        'tbSuppName
        '
        Me.tbSuppName.Enabled = False
        Me.tbSuppName.Location = New System.Drawing.Point(733, 210)
        Me.tbSuppName.Name = "tbSuppName"
        Me.tbSuppName.ReadOnly = True
        Me.tbSuppName.Size = New System.Drawing.Size(127, 20)
        Me.tbSuppName.TabIndex = 3
        '
        'tbSP
        '
        Me.tbSP.Enabled = False
        Me.tbSP.Location = New System.Drawing.Point(733, 254)
        Me.tbSP.Name = "tbSP"
        Me.tbSP.ReadOnly = True
        Me.tbSP.Size = New System.Drawing.Size(127, 20)
        Me.tbSP.TabIndex = 4
        '
        'tbTax
        '
        Me.tbTax.Enabled = False
        Me.tbTax.Location = New System.Drawing.Point(733, 299)
        Me.tbTax.Name = "tbTax"
        Me.tbTax.ReadOnly = True
        Me.tbTax.Size = New System.Drawing.Size(127, 20)
        Me.tbTax.TabIndex = 5
        '
        'Confirm
        '
        Me.Confirm.Enabled = False
        Me.Confirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.Confirm.Location = New System.Drawing.Point(649, 378)
        Me.Confirm.Name = "Confirm"
        Me.Confirm.Size = New System.Drawing.Size(75, 23)
        Me.Confirm.TabIndex = 6
        Me.Confirm.Text = "Confirm Item"
        Me.Confirm.UseVisualStyleBackColor = True
        '
        'Cancel
        '
        Me.Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.Cancel.Location = New System.Drawing.Point(772, 378)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(75, 23)
        Me.Cancel.TabIndex = 7
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'buttonDelete
        '
        Me.buttonDelete.Location = New System.Drawing.Point(706, 444)
        Me.buttonDelete.Name = "buttonDelete"
        Me.buttonDelete.Size = New System.Drawing.Size(75, 23)
        Me.buttonDelete.TabIndex = 101
        Me.buttonDelete.Text = "Remove Item"
        Me.buttonDelete.UseVisualStyleBackColor = True
        '
        'formAddItem
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(944, 528)
        Me.Controls.Add(Me.buttonDelete)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.Confirm)
        Me.Controls.Add(Me.tbTax)
        Me.Controls.Add(Me.tbSP)
        Me.Controls.Add(Me.tbSuppName)
        Me.Controls.Add(Me.tbSuppID)
        Me.Controls.Add(Me.tbItemName)
        Me.Controls.Add(Me.tbItemId)
        Me.Controls.Add(Me.lblTax)
        Me.Controls.Add(Me.lblSP)
        Me.Controls.Add(Me.lblSupplierName)
        Me.Controls.Add(Me.lblSupplierID)
        Me.Controls.Add(Me.lbltemName)
        Me.Controls.Add(Me.lblItemID)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "formAddItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Item"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents lblItemID As System.Windows.Forms.Label
    Friend WithEvents lbltemName As System.Windows.Forms.Label
    Friend WithEvents lblSupplierID As System.Windows.Forms.Label
    Friend WithEvents lblSupplierName As System.Windows.Forms.Label
    Friend WithEvents lblSP As System.Windows.Forms.Label
    Friend WithEvents lblTax As System.Windows.Forms.Label
    Friend WithEvents tbItemId As System.Windows.Forms.TextBox
    Friend WithEvents tbItemName As System.Windows.Forms.TextBox
    Friend WithEvents tbSuppID As System.Windows.Forms.TextBox
    Friend WithEvents tbSuppName As System.Windows.Forms.TextBox
    Friend WithEvents tbSP As System.Windows.Forms.TextBox
    Friend WithEvents tbTax As System.Windows.Forms.TextBox
    Friend WithEvents Confirm As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button
    Friend WithEvents buttonDelete As System.Windows.Forms.Button
End Class
