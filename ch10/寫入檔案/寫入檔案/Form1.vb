Imports System.IO
Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim FILENAME As String = "write.txt"
        If File.Exists(FILENAME) Then
            TextBox2.Text = "檔案已經存在"
            Return
        End If
        Dim outs As StreamWriter = File.CreateText(FILENAME)
        outs.WriteLine(TextBox1.Text)
        TextBox2.Text = "已將字串寫入檔案"
        outs.Close()
    End Sub
End Class
