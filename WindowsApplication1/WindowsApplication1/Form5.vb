Public Class Form5

    Private Sub btn_calSI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_calSI.Click
        txt_si.Text = (Int32.Parse(txt_p.Text) * Int32.Parse(txt_r.Text) * Int32.Parse(txt_n.Text) / 100).ToString()
    End Sub
End Class