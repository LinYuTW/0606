Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim score() = {60, 90, 44, 98, 50}
        Dim max As Integer = score(0)
        Dim max_index As Integer
        TextBox1.Text = TextBox1.Text & "score(0)=" & score(0) & vbNewLine
        For i = 1 To 4
            If (max < score(i)) Then
                max = score(i)
                max_index = i
            End If
            TextBox1.Text = TextBox1.Text & "score(" & i & ")=" & score(i) & vbNewLine
        Next
        TextBox1.Text = TextBox1.Text & "陣列score第" & max_index + 1 & "元素為最大值，其值為" & max
    End Sub
End Class
