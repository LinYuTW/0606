Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim dis As Double
        Dim dx As Double
        Dim dy As Double
        dx = Val(TextBox1.Text) - Val(TextBox3.Text)
        dy = Val(TextBox2.Text) - Val(TextBox4.Text)
        dis = Math.Sqrt(Math.Pow(dx, 2) + Math.Pow(dy, 2))
        TextBox5.Text = dis
    End Sub
End Class
