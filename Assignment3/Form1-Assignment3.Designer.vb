<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AssignmentForm
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
        Me.AssignmentLabel = New System.Windows.Forms.Label()
        Me.ArrayButton = New System.Windows.Forms.Button()
        Me.CollectionButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'AssignmentLabel
        '
        Me.AssignmentLabel.AutoSize = True
        Me.AssignmentLabel.Font = New System.Drawing.Font("Cooper Black", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AssignmentLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.AssignmentLabel.Location = New System.Drawing.Point(26, 126)
        Me.AssignmentLabel.Name = "AssignmentLabel"
        Me.AssignmentLabel.Size = New System.Drawing.Size(434, 55)
        Me.AssignmentLabel.TabIndex = 0
        Me.AssignmentLabel.Text = "Assignment No 3"
        '
        'ArrayButton
        '
        Me.ArrayButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.ArrayButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.ArrayButton.FlatAppearance.BorderSize = 3
        Me.ArrayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ArrayButton.Font = New System.Drawing.Font("Cooper Black", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ArrayButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.ArrayButton.Location = New System.Drawing.Point(100, 206)
        Me.ArrayButton.Name = "ArrayButton"
        Me.ArrayButton.Size = New System.Drawing.Size(265, 69)
        Me.ArrayButton.TabIndex = 1
        Me.ArrayButton.Text = "Array"
        Me.ArrayButton.UseVisualStyleBackColor = False
        '
        'CollectionButton
        '
        Me.CollectionButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.CollectionButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.CollectionButton.FlatAppearance.BorderSize = 3
        Me.CollectionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CollectionButton.Font = New System.Drawing.Font("Cooper Black", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CollectionButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.CollectionButton.Location = New System.Drawing.Point(100, 293)
        Me.CollectionButton.Name = "CollectionButton"
        Me.CollectionButton.Size = New System.Drawing.Size(265, 69)
        Me.CollectionButton.TabIndex = 2
        Me.CollectionButton.Text = "Collection"
        Me.CollectionButton.UseVisualStyleBackColor = False
        '
        'AssignmentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(484, 461)
        Me.Controls.Add(Me.CollectionButton)
        Me.Controls.Add(Me.ArrayButton)
        Me.Controls.Add(Me.AssignmentLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "AssignmentForm"
        Me.Text = "Assignment No. 3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AssignmentLabel As Label
    Friend WithEvents ArrayButton As Button
    Friend WithEvents CollectionButton As Button
End Class
