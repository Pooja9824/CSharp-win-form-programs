Public Class Form2

    Private Sub txt_first_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_first.Enter
        txt_first.Text = "welcome"
        txt_second.Text = "By"
    End Sub

    Private Sub txt_first_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_first.Leave
        txt_first.Text = "By"
        txt_second.Text = "welcome"
    End Sub
End Class