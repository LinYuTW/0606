Imports System.IO
Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim FILENAME As String = "read.txt"
        If Not File.Exists(FILENAME) Then
            TextBox1.Text = TextBox1.Text & "檔案不存在"
            Return
        End If
        Dim ins As StreamReader = File.OpenText(FILENAME)
        Dim inl As String
        inl = ins.ReadLine()
        While Not inl Is Nothing
            TextBox1.Text = TextBox1.Text & inl & vbNewLine
            inl = ins.ReadLine()
        End While
        ins.Close()
    End Sub
End Class
