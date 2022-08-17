<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Me.btn_calSI = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_p = New System.Windows.Forms.TextBox()
        Me.txt_r = New System.Windows.Forms.TextBox()
        Me.txt_n = New System.Windows.Forms.TextBox()
        Me.txt_si = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btn_calSI
        '
        Me.btn_calSI.Location = New System.Drawing.Point(35, 186)
        Me.btn_calSI.Name = "btn_calSI"
        Me.btn_calSI.Size = New System.Drawing.Size(75, 23)
        Me.btn_calSI.TabIndex = 4
        Me.btn_calSI.Text = "CalculateSI"
        Me.btn_calSI.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(14, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "P"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(15, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "R"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(15, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "N"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(17, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "SI"
        '
        'txt_p
        '
        Me.txt_p.Location = New System.Drawing.Point(76, 37)
        Me.txt_p.Name = "txt_p"
        Me.txt_p.Size = New System.Drawing.Size(100, 20)
        Me.txt_p.TabIndex = 0
        '
        'txt_r
        '
        Me.txt_r.Location = New System.Drawing.Point(76, 67)
        Me.txt_r.Name = "txt_r"
        Me.txt_r.Size = New System.Drawing.Size(100, 20)
        Me.txt_r.TabIndex = 1
        '
        'txt_n
        '
        Me.txt_n.Location = New System.Drawing.Point(76, 101)
        Me.txt_n.Name = "txt_n"
        Me.txt_n.Size = New System.Drawing.Size(100, 20)
        Me.txt_n.TabIndex = 2
        '
        'txt_si
        '
        Me.txt_si.Enabled = False
        Me.txt_si.Location = New System.Drawing.Point(76, 132)
        Me.txt_si.Name = "txt_si"
        Me.txt_si.Size = New System.Drawing.Size(100, 20)
        Me.txt_si.TabIndex = 3
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.txt_si)
        Me.Controls.Add(Me.txt_n)
        Me.Controls.Add(Me.txt_r)
        Me.Controls.Add(Me.txt_p)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_calSI)
        Me.Name = "Form5"
        Me.Text = "Form5"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_calSI As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_p As System.Windows.Forms.TextBox
    Friend WithEvents txt_r As System.Windows.Forms.TextBox
    Friend WithEvents txt_n As System.Windows.Forms.TextBox
    Friend WithEvents txt_si As System.Windows.Forms.TextBox
End Class
