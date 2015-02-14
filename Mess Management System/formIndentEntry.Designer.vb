<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formIndentEntry
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
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Item_IdTB = New System.Windows.Forms.TextBox()
        Me.QtyTB = New System.Windows.Forms.TextBox()
        Me.Confirm_T = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.Confirm_O = New System.Windows.Forms.Button()
        Me.Cancel_Close = New System.Windows.Forms.Button()
        Me.Delete_Entry = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Bill_IdTB = New System.Windows.Forms.TextBox()
        Me.Supp_IdTB = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblSuppName = New System.Windows.Forms.Label()
        Me.lblItem_Name = New System.Windows.Forms.Label()
        Me.lblCurr_Qty = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(17, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.ShowEditingIcon = False
        Me.DataGridView1.Size = New System.Drawing.Size(1062, 282)
        Me.DataGridView1.TabIndex = 10000
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(556, 308)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.ShowEditingIcon = False
        Me.DataGridView2.Size = New System.Drawing.Size(496, 236)
        Me.DataGridView2.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Label1.Location = New System.Drawing.Point(266, 383)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 17)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "ITEM ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Label2.Location = New System.Drawing.Point(266, 416)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 17)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "ITEM NAME"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Label4.Location = New System.Drawing.Point(266, 473)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 17)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "New QTY"
        '
        'Item_IdTB
        '
        Me.Item_IdTB.Location = New System.Drawing.Point(374, 383)
        Me.Item_IdTB.Name = "Item_IdTB"
        Me.Item_IdTB.Size = New System.Drawing.Size(133, 20)
        Me.Item_IdTB.TabIndex = 3
        '
        'QtyTB
        '
        Me.QtyTB.Location = New System.Drawing.Point(374, 473)
        Me.QtyTB.Name = "QtyTB"
        Me.QtyTB.Size = New System.Drawing.Size(133, 20)
        Me.QtyTB.TabIndex = 4
        '
        'Confirm_T
        '
        Me.Confirm_T.Location = New System.Drawing.Point(255, 501)
        Me.Confirm_T.Name = "Confirm_T"
        Me.Confirm_T.Size = New System.Drawing.Size(108, 43)
        Me.Confirm_T.TabIndex = 5
        Me.Confirm_T.Text = "Confirm Transaction"
        Me.Confirm_T.UseVisualStyleBackColor = True
        '
        'Cancel
        '
        Me.Cancel.Location = New System.Drawing.Point(411, 501)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(108, 43)
        Me.Cancel.TabIndex = 10002
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'Confirm_O
        '
        Me.Confirm_O.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Confirm_O.Location = New System.Drawing.Point(37, 568)
        Me.Confirm_O.Name = "Confirm_O"
        Me.Confirm_O.Size = New System.Drawing.Size(147, 44)
        Me.Confirm_O.TabIndex = 6
        Me.Confirm_O.Text = "Confirm Order"
        Me.Confirm_O.UseVisualStyleBackColor = True
        '
        'Cancel_Close
        '
        Me.Cancel_Close.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Cancel_Close.Location = New System.Drawing.Point(216, 568)
        Me.Cancel_Close.Name = "Cancel_Close"
        Me.Cancel_Close.Size = New System.Drawing.Size(147, 44)
        Me.Cancel_Close.TabIndex = 10004
        Me.Cancel_Close.Text = "Cancel and Close"
        Me.Cancel_Close.UseVisualStyleBackColor = True
        '
        'Delete_Entry
        '
        Me.Delete_Entry.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Delete_Entry.Location = New System.Drawing.Point(537, 568)
        Me.Delete_Entry.Name = "Delete_Entry"
        Me.Delete_Entry.Size = New System.Drawing.Size(237, 44)
        Me.Delete_Entry.TabIndex = 10005
        Me.Delete_Entry.Text = "Delete Indent Order"
        Me.Delete_Entry.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.Label5.Location = New System.Drawing.Point(12, 383)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 25)
        Me.Label5.TabIndex = 10007
        Me.Label5.Text = "INDENT_NO"
        '
        'Bill_IdTB
        '
        Me.Bill_IdTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Bill_IdTB.Location = New System.Drawing.Point(152, 381)
        Me.Bill_IdTB.Name = "Bill_IdTB"
        Me.Bill_IdTB.Size = New System.Drawing.Size(83, 29)
        Me.Bill_IdTB.TabIndex = 0
        '
        'Supp_IdTB
        '
        Me.Supp_IdTB.Location = New System.Drawing.Point(373, 318)
        Me.Supp_IdTB.Name = "Supp_IdTB"
        Me.Supp_IdTB.Size = New System.Drawing.Size(133, 20)
        Me.Supp_IdTB.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Label6.Location = New System.Drawing.Point(265, 318)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 17)
        Me.Label6.TabIndex = 10010
        Me.Label6.Text = "SUPPLIER ID"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Label7.Location = New System.Drawing.Point(266, 351)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 17)
        Me.Label7.TabIndex = 10012
        Me.Label7.Text = "SUPP. NAME"
        '
        'lblSuppName
        '
        Me.lblSuppName.AutoSize = True
        Me.lblSuppName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.lblSuppName.Location = New System.Drawing.Point(371, 351)
        Me.lblSuppName.Name = "lblSuppName"
        Me.lblSuppName.Size = New System.Drawing.Size(0, 17)
        Me.lblSuppName.TabIndex = 10015
        '
        'lblItem_Name
        '
        Me.lblItem_Name.AutoSize = True
        Me.lblItem_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.lblItem_Name.Location = New System.Drawing.Point(371, 416)
        Me.lblItem_Name.Name = "lblItem_Name"
        Me.lblItem_Name.Size = New System.Drawing.Size(0, 17)
        Me.lblItem_Name.TabIndex = 10016
        '
        'lblCurr_Qty
        '
        Me.lblCurr_Qty.AutoSize = True
        Me.lblCurr_Qty.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.lblCurr_Qty.Location = New System.Drawing.Point(371, 447)
        Me.lblCurr_Qty.Name = "lblCurr_Qty"
        Me.lblCurr_Qty.Size = New System.Drawing.Size(0, 17)
        Me.lblCurr_Qty.TabIndex = 10018
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Label8.Location = New System.Drawing.Point(266, 447)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 17)
        Me.Label8.TabIndex = 10017
        Me.Label8.Text = "Current Qty"
        '
        'formIndentEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1102, 637)
        Me.Controls.Add(Me.lblCurr_Qty)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblItem_Name)
        Me.Controls.Add(Me.lblSuppName)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Supp_IdTB)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Bill_IdTB)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Delete_Entry)
        Me.Controls.Add(Me.Cancel_Close)
        Me.Controls.Add(Me.Confirm_O)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.Confirm_T)
        Me.Controls.Add(Me.QtyTB)
        Me.Controls.Add(Me.Item_IdTB)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "formIndentEntry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Indent Entry"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Item_IdTB As System.Windows.Forms.TextBox
    Friend WithEvents QtyTB As System.Windows.Forms.TextBox
    Friend WithEvents Confirm_T As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button
    Friend WithEvents Confirm_O As System.Windows.Forms.Button
    Friend WithEvents Cancel_Close As System.Windows.Forms.Button
    Friend WithEvents Delete_Entry As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Bill_IdTB As System.Windows.Forms.TextBox
    Friend WithEvents Supp_IdTB As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblSuppName As System.Windows.Forms.Label
    Friend WithEvents lblItem_Name As System.Windows.Forms.Label
    Friend WithEvents lblCurr_Qty As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
