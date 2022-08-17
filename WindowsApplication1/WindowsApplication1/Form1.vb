Public Class Form1

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_mname.TextChanged

    End Sub

    Private Sub txt_fullname_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_fullname.Enter
        txt_fullname.Text = txt_fname.Text + " " + txt_mname.Text + " " + txt_lname.Text


    End Sub
End Class
