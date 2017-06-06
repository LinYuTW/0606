Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim myArray(5) As Integer
        Dim temp As Integer
        Dim max As Integer
        Randomize()
        For i As Integer = 0 To 4
            myArray(i) = CInt(Int(Rnd() * 100))
            TextBox1.Text = TextBox1.Text & "myArray(" & i & ")=" & myArray(i) & vbNewLine
        Next
        For i As Integer = 4 To 1 Step -1
            max = 0
            For j As Integer = 1 To i
                If myArray(j) > myArray(max) Then
                    max = j
                End If
            Next
            temp = myArray(i)
            myArray(i) = myArray(max)
            myArray(max) = temp
        Next
        TextBox1.Text = TextBox1.Text & "排序後" & vbNewLine
        For i As Integer = 0 To 4
            TextBox1.Text = TextBox1.Text & "myArray(" & i & ")=" & myArray(i) & vbNewLine
        Next
    End Sub
End Class
