Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Randomize()
        Dim Random As Integer = CInt(Int((6 * Rnd()) + 1))
        TextBox1.Text = Str(Random)
    End Sub
End Class
