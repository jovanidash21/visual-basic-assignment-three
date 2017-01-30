<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ArrayForm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TaskDataGridView = New System.Windows.Forms.DataGridView()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.TaskOrder = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TaskName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.TaskDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TaskDataGridView
        '
        Me.TaskDataGridView.AllowUserToAddRows = False
        Me.TaskDataGridView.AllowUserToDeleteRows = False
        Me.TaskDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.TaskDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TaskDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TaskOrder, Me.TaskName})
        Me.TaskDataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.TaskDataGridView.Location = New System.Drawing.Point(12, 12)
        Me.TaskDataGridView.Name = "TaskDataGridView"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(221, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TaskDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.TaskDataGridView.Size = New System.Drawing.Size(460, 385)
        Me.TaskDataGridView.TabIndex = 0
        '
        'AddButton
        '
        Me.AddButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.AddButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.AddButton.FlatAppearance.BorderSize = 3
        Me.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddButton.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.AddButton.Location = New System.Drawing.Point(12, 403)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(112, 46)
        Me.AddButton.TabIndex = 1
        Me.AddButton.Text = "ADD"
        Me.AddButton.UseVisualStyleBackColor = False
        '
        'TaskOrder
        '
        Me.TaskOrder.HeaderText = "Order"
        Me.TaskOrder.Name = "TaskOrder"
        Me.TaskOrder.ReadOnly = True
        Me.TaskOrder.Width = 50
        '
        'TaskName
        '
        Me.TaskName.HeaderText = "Task"
        Me.TaskName.Name = "TaskName"
        Me.TaskName.Width = 360
        '
        'ArrayForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(484, 461)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.TaskDataGridView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "ArrayForm"
        Me.Text = "Array"
        CType(Me.TaskDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TaskDataGridView As DataGridView
    Friend WithEvents AddButton As Button
    Friend WithEvents TaskOrder As DataGridViewTextBoxColumn
    Friend WithEvents TaskName As DataGridViewTextBoxColumn
End Class
