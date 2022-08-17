<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.txt_first = New System.Windows.Forms.TextBox()
        Me.txt_second = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txt_first
        '
        Me.txt_first.Location = New System.Drawing.Point(93, 74)
        Me.txt_first.Name = "txt_first"
        Me.txt_first.Size = New System.Drawing.Size(100, 20)
        Me.txt_first.TabIndex = 0
        '
        'txt_second
        '
        Me.txt_second.Location = New System.Drawing.Point(93, 125)
        Me.txt_second.Name = "txt_second"
        Me.txt_second.Size = New System.Drawing.Size(100, 20)
        Me.txt_second.TabIndex = 1
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.txt_second)
        Me.Controls.Add(Me.txt_first)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_first As System.Windows.Forms.TextBox
    Friend WithEvents txt_second As System.Windows.Forms.TextBox
End Class
