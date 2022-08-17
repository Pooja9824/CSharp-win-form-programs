<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.x = New System.Windows.Forms.Label()
        Me.y = New System.Windows.Forms.Label()
        Me.ans = New System.Windows.Forms.Label()
        Me.txt_x = New System.Windows.Forms.TextBox()
        Me.txt_y = New System.Windows.Forms.TextBox()
        Me.txt_ans = New System.Windows.Forms.TextBox()
        Me.btn_sum = New System.Windows.Forms.Button()
        Me.btn_sub = New System.Windows.Forms.Button()
        Me.btn_div = New System.Windows.Forms.Button()
        Me.btn_mul = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'x
        '
        Me.x.AutoSize = True
        Me.x.Location = New System.Drawing.Point(33, 42)
        Me.x.Name = "x"
        Me.x.Size = New System.Drawing.Size(14, 13)
        Me.x.TabIndex = 0
        Me.x.Text = "X"
        '
        'y
        '
        Me.y.AutoSize = True
        Me.y.Location = New System.Drawing.Point(33, 79)
        Me.y.Name = "y"
        Me.y.Size = New System.Drawing.Size(14, 13)
        Me.y.TabIndex = 1
        Me.y.Text = "Y"
        '
        'ans
        '
        Me.ans.AutoSize = True
        Me.ans.Location = New System.Drawing.Point(33, 115)
        Me.ans.Name = "ans"
        Me.ans.Size = New System.Drawing.Size(25, 13)
        Me.ans.TabIndex = 2
        Me.ans.Text = "Ans"
        '
        'txt_x
        '
        Me.txt_x.Location = New System.Drawing.Point(108, 35)
        Me.txt_x.Name = "txt_x"
        Me.txt_x.Size = New System.Drawing.Size(100, 20)
        Me.txt_x.TabIndex = 3
        '
        'txt_y
        '
        Me.txt_y.Location = New System.Drawing.Point(108, 72)
        Me.txt_y.Name = "txt_y"
        Me.txt_y.Size = New System.Drawing.Size(100, 20)
        Me.txt_y.TabIndex = 4
        '
        'txt_ans
        '
        Me.txt_ans.Location = New System.Drawing.Point(108, 108)
        Me.txt_ans.Name = "txt_ans"
        Me.txt_ans.ReadOnly = True
        Me.txt_ans.Size = New System.Drawing.Size(100, 20)
        Me.txt_ans.TabIndex = 5
        '
        'btn_sum
        '
        Me.btn_sum.Location = New System.Drawing.Point(36, 155)
        Me.btn_sum.Name = "btn_sum"
        Me.btn_sum.Size = New System.Drawing.Size(45, 23)
        Me.btn_sum.TabIndex = 6
        Me.btn_sum.Text = "+"
        Me.btn_sum.UseVisualStyleBackColor = True
        '
        'btn_sub
        '
        Me.btn_sub.Location = New System.Drawing.Point(87, 155)
        Me.btn_sub.Name = "btn_sub"
        Me.btn_sub.Size = New System.Drawing.Size(44, 23)
        Me.btn_sub.TabIndex = 7
        Me.btn_sub.Text = "-"
        Me.btn_sub.UseVisualStyleBackColor = True
        '
        'btn_div
        '
        Me.btn_div.Location = New System.Drawing.Point(187, 155)
        Me.btn_div.Name = "btn_div"
        Me.btn_div.Size = New System.Drawing.Size(47, 23)
        Me.btn_div.TabIndex = 9
        Me.btn_div.Text = "/"
        Me.btn_div.UseVisualStyleBackColor = True
        '
        'btn_mul
        '
        Me.btn_mul.Location = New System.Drawing.Point(137, 155)
        Me.btn_mul.Name = "btn_mul"
        Me.btn_mul.Size = New System.Drawing.Size(44, 23)
        Me.btn_mul.TabIndex = 8
        Me.btn_mul.Text = "*"
        Me.btn_mul.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(36, 203)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 10
        Me.Button5.Text = "odd_even"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(159, 203)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 11
        Me.Button6.Text = "min_max"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(96, 243)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 23)
        Me.Button7.TabIndex = 12
        Me.Button7.Text = "Clear"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(36, 281)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(198, 23)
        Me.Button8.TabIndex = 13
        Me.Button8.Text = "Swap"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(478, 316)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.btn_div)
        Me.Controls.Add(Me.btn_mul)
        Me.Controls.Add(Me.btn_sub)
        Me.Controls.Add(Me.btn_sum)
        Me.Controls.Add(Me.txt_ans)
        Me.Controls.Add(Me.txt_y)
        Me.Controls.Add(Me.txt_x)
        Me.Controls.Add(Me.ans)
        Me.Controls.Add(Me.y)
        Me.Controls.Add(Me.x)
        Me.Name = "Form4"
        Me.Text = "Form4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents x As System.Windows.Forms.Label
    Friend WithEvents y As System.Windows.Forms.Label
    Friend WithEvents ans As System.Windows.Forms.Label
    Friend WithEvents txt_x As System.Windows.Forms.TextBox
    Friend WithEvents txt_y As System.Windows.Forms.TextBox
    Friend WithEvents txt_ans As System.Windows.Forms.TextBox
    Friend WithEvents btn_sum As System.Windows.Forms.Button
    Friend WithEvents btn_sub As System.Windows.Forms.Button
    Friend WithEvents btn_div As System.Windows.Forms.Button
    Friend WithEvents btn_mul As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
End Class
