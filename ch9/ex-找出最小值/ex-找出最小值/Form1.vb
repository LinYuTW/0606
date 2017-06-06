Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim score() = {60, 90, 44, 98, 50}
        Dim min As Integer = score(0)
        TextBox1.Text = TextBox1.Text & "score(0)=" & score(0) & vbNewLine
        For i = 1 To 4
            If (min > score(i)) Then
                min = score(i)
            End If
            TextBox1.Text = TextBox1.Text & "score(" & i & ")=" & score(i) & vbNewLine
        Next
        TextBox1.Text = TextBox1.Text & "min=" & min
    End Sub
End Class
