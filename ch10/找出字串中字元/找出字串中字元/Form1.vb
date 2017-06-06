Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim leng As Integer = Len(TextBox1.Text)
        Dim ch As Char
        For i As Integer = 1 To leng
            ch = Mid(TextBox1.Text, i, 1)
            TextBox2.Text = TextBox2.Text & ch & vbNewLine
        Next
    End Sub
End Class
