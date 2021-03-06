﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CollectionForm
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.CollectionLabel = New System.Windows.Forms.Label()
        Me.TaskDataGridView = New System.Windows.Forms.DataGridView()
        Me.TaskOrder = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TaskName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        CType(Me.TaskDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CollectionLabel
        '
        Me.CollectionLabel.AutoSize = True
        Me.CollectionLabel.Font = New System.Drawing.Font("Cooper Black", 21.0!)
        Me.CollectionLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.CollectionLabel.Location = New System.Drawing.Point(68, 9)
        Me.CollectionLabel.Name = "CollectionLabel"
        Me.CollectionLabel.Size = New System.Drawing.Size(341, 32)
        Me.CollectionLabel.TabIndex = 4
        Me.CollectionLabel.Text = "To-Do List (Collection)"
        '
        'TaskDataGridView
        '
        Me.TaskDataGridView.AllowUserToAddRows = False
        Me.TaskDataGridView.AllowUserToDeleteRows = False
        Me.TaskDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.TaskDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TaskDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TaskOrder, Me.TaskName})
        Me.TaskDataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.TaskDataGridView.Location = New System.Drawing.Point(12, 53)
        Me.TaskDataGridView.Name = "TaskDataGridView"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(221, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TaskDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.TaskDataGridView.Size = New System.Drawing.Size(460, 344)
        Me.TaskDataGridView.TabIndex = 5
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
        Me.TaskName.Width = 367
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
        Me.AddButton.TabIndex = 6
        Me.AddButton.Text = "ADD"
        Me.AddButton.UseVisualStyleBackColor = False
        '
        'ClearButton
        '
        Me.ClearButton.BackColor = System.Drawing.Color.IndianRed
        Me.ClearButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.ClearButton.FlatAppearance.BorderSize = 3
        Me.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ClearButton.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.ClearButton.Location = New System.Drawing.Point(331, 403)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(141, 46)
        Me.ClearButton.TabIndex = 7
        Me.ClearButton.Text = "CLEAR ALL"
        Me.ClearButton.UseVisualStyleBackColor = False
        '
        'CollectionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(484, 461)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.TaskDataGridView)
        Me.Controls.Add(Me.CollectionLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "CollectionForm"
        Me.Text = "Collection"
        CType(Me.TaskDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CollectionLabel As Label
    Friend WithEvents TaskDataGridView As DataGridView
    Friend WithEvents TaskOrder As DataGridViewTextBoxColumn
    Friend WithEvents TaskName As DataGridViewTextBoxColumn
    Friend WithEvents AddButton As Button
    Friend WithEvents ClearButton As Button
End Class
