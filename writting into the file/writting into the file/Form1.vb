Imports System.IO

Public Class Form1
    Dim fs As FileStream
    Dim sw As StreamWriter
    Dim sr As StreamReader
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fs = New FileStream("\\Mac\Home\Desktop\test.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite)
    End Sub

    Private Sub Button1_click(sender As Object, e As EventArgs) Handles Button1.Click
        sw = New StreamWriter(fs)
        sw.Write(TextBox1.Text)
        sw.Close()
        MsgBox("file written successfully!!!")
        TextBox1.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        sr = New StreamReader(fs)
        TextBox1.Text = sr.ReadToEnd()
        sr.Close()
    End Sub
End Class
