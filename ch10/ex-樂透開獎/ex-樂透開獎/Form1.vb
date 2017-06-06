Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Randomize()
        Dim random As Integer
        For i As Integer = 1 To 6
            random = CInt(Int(Rnd() * 49 + 1))
            TextBox1.Text = TextBox1.Text & random & vbNewLine
        Next
    End Sub
End Class
