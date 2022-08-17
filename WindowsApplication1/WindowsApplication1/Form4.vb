Public Class Form4

    Private Sub btn_sum_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_sum.Click
        txt_ans.Text = (Int32.Parse(txt_x.Text) + Int32.Parse(txt_y.Text)).ToString()
    End Sub

    Private Sub btn_sub_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_sub.Click
        txt_ans.Text = (Int32.Parse(txt_x.Text) - Int32.Parse(txt_y.Text)).ToString()
    End Sub

    Private Sub btn_mul_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_mul.Click
        txt_ans.Text = (Int32.Parse(txt_x.Text) * Int32.Parse(txt_y.Text)).ToString()
    End Sub

    Private Sub btn_div_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_div.Click
        txt_ans.Text = (Int32.Parse(txt_x.Text) / Int32.Parse(txt_y.Text)).ToString()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        txt_x.Text = " "
        txt_y.Text = " "
        txt_ans.Text = " "
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        txt_ans.Text = "x = " + txt_y.Text + "   y = " + txt_x.Text

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If ((Int32.Parse(txt_x.Text)) > (Int32.Parse(txt_y.Text))) Then
            txt_ans.Text = "x is big:- x= " + txt_x.Text + "y= " + txt_y.Text
        ElseIf ((Int32.Parse(txt_x.Text)) < (Int32.Parse(txt_y.Text))) Then
            txt_ans.Text = "y is big:- x= " + txt_x.Text + "y= " + txt_y.Text
        ElseIf ((Int32.Parse(txt_x.Text)) = (Int32.Parse(txt_y.Text))) Then
            txt_ans.Text = "x and y both are same x= " + txt_x.Text + "y= " + txt_y.Text
        End If
        txt_ans.Text = " "


    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If ((Int32.Parse(txt_x.Text)) / 2 = 0 & (Int32.Parse(txt_y.Text)) / 2 = 0) Then

            txt_ans.Text = "even " + txt_x.Text + "even= " + txt_y.Text

        ElseIf ((Int32.Parse(txt_x.Text)) / 2 = 0 & (Int32.Parse(txt_y.Text)) / 2.0! = 0) Then

            txt_ans.Text = "even " + txt_x.Text + "odd=" + txt_y.Text

        ElseIf ((Int32.Parse(txt_x.Text)) / 2.0! = 0 & (Int32.Parse(txt_y.Text)) / 2 = 0) Then

            txt_ans.Text = "odd= " + txt_x.Text + "even= " + txt_y.Text

        ElseIf ((Int32.Parse(txt_x.Text)) / 2.0! = 0 & (Int32.Parse(txt_y.Text)) / 2.0! = 0) Then

            txt_ans.Text = "odd= " + txt_x.Text + "odd= " + txt_y.Text
        End If

        txt_ans.Text = " "

    End Sub
End Class