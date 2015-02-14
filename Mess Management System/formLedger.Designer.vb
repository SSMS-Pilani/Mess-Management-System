<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formLedger
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
        Me.TbItem_ID = New System.Windows.Forms.TextBox()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.MonthCalendar2 = New System.Windows.Forms.MonthCalendar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TbItem_ID
        '
        Me.TbItem_ID.Location = New System.Drawing.Point(512, 53)
        Me.TbItem_ID.Name = "TbItem_ID"
        Me.TbItem_ID.Size = New System.Drawing.Size(100, 20)
        Me.TbItem_ID.TabIndex = 0
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(18, 39)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 1
        '
        'MonthCalendar2
        '
        Me.MonthCalendar2.Location = New System.Drawing.Point(757, 39)
        Me.MonthCalendar2.Name = "MonthCalendar2"
        Me.MonthCalendar2.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(416, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "ITEM_ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(416, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "ITEM NAME"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(509, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(17, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = """"""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label4.Location = New System.Drawing.Point(214, 205)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "LEDGER"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label5.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label5.Location = New System.Drawing.Point(753, 205)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 20)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "SUPPLIES"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 237)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.ShowCellErrors = False
        Me.DataGridView1.ShowCellToolTips = False
        Me.DataGridView1.ShowEditingIcon = False
        Me.DataGridView1.Size = New System.Drawing.Size(465, 437)
        Me.DataGridView1.TabIndex = 8
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(519, 237)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.ShowCellToolTips = False
        Me.DataGridView2.ShowEditingIcon = False
        Me.DataGridView2.ShowRowErrors = False
        Me.DataGridView2.Size = New System.Drawing.Size(465, 437)
        Me.DataGridView2.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(82, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 20)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "FROM"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(845, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 20)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "TO"
        '
        'formLedger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1002, 686)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MonthCalendar2)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.TbItem_ID)
        Me.Name = "formLedger"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ledger"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TbItem_ID As System.Windows.Forms.TextBox
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents MonthCalendar2 As System.Windows.Forms.MonthCalendar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
