﻿Public Class Form1
    Dim lst As New ArrayList()
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim id As Integer
        Dim name As String
        id = Int(TextBox1.Text)
        name = TextBox2.Text
        lst.Add(id & ". " & name)
        TextBox1.Clear()
        TextBox2.Clear()
        MessageBox.Show("Added Successfully")
        showList()

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        showList()
    End Sub

    Sub showList()
        Label3.Text = ""
        For Each itm In lst
            Label3.Text += itm & vbCrLf
        Next
    End Sub
End Class