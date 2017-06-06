Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim sex As Integer
        sex = Val(Mid(TextBox1.Text, 2, 1))
        If sex = 1 Then
            MsgBox("是男生")
        Else
            MsgBox("是女生")
        End If
    End Sub
End Class
