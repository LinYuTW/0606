Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim score() = {60, 90, 44, 98, 50}
        Dim found As Integer = 0
        For i = 0 To 4
            TextBox1.Text = TextBox1.Text & "score(" & i & ")=" & score(i) & vbNewLine
            If (score(i) = 59) Then
                found = 1
                TextBox1.Text = TextBox1.Text & "找到成績為59分的學生" & vbNewLine
            End If
        Next
        If (found = 0) Then
            TextBox1.Text = TextBox1.Text & "找不到成績為59分的學生"
        End If
    End Sub
End Class
