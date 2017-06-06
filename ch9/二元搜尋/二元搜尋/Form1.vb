Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim score() As Integer = {45, 59, 62, 67, 70, 78, 83, 85, 88, 92}
        Dim nowIndex As Integer = 5
        Dim leftIndex As Integer = 0
        Dim rightIndex As Integer = 9
        Do While score(nowIndex) <> 59
            TextBox1.Text = TextBox1.Text & "找尋陣列score第" & nowIndex & "元素其值為" & score(nowIndex) & vbNewLine
            If leftIndex = rightIndex Then
                Exit Do
            End If
            If score(nowIndex) > 59 Then
                rightIndex = nowIndex - 1
            Else
                leftIndex = nowIndex + 1
            End If
            nowIndex = (leftIndex + rightIndex) / 2
            TextBox1.Text = TextBox1.Text & "leftIndex為" & leftIndex & vbNewLine
            TextBox1.Text = TextBox1.Text & "rightIndex為" & rightIndex & vbNewLine
            TextBox1.Text = TextBox1.Text & "nowIndex為" & nowIndex & vbNewLine
        Loop
        If score(nowIndex) = 59 Then
            TextBox1.Text = TextBox1.Text & "找到陣列score第" & nowIndex & "元素為59" & vbNewLine
        Else
            TextBox1.Text = TextBox1.Text & "找不到成績為59分的資料"
        End If
    End Sub
End Class
