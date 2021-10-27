Public Class htglgkrn
    Dim r As Single
    Const phi As Single = 3.14

    Private Sub htglgkrn_Load(ByVal Sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtRad.Text = r
        r = txtRad.Text
    End Sub
    Private Sub txtRad_TextChanged(sender As Object, e As EventArgs) Handles txtRad.TextChanged
        r = txtRad.Text

    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        kllLing.Text = 2 * phi * r
        luasLing.Text = phi * (r ^ 2)
    End Sub
End Class
