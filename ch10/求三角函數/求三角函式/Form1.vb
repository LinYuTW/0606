Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim degree As Integer = Val(TextBox1.Text)
        Dim radius As Double = degree / 180 * Math.PI
        TextBox2.Text = Str(Math.Sin(radius))
        TextBox3.Text = Str(Math.Cos(radius))
        TextBox4.Text = Str(Math.Tan(radius))
    End Sub
End Class
