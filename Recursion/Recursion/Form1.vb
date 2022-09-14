Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Integer
        a = Int(TextBox1.Text)
        Label3.Text = "Factorial of " & a & " = " & factorial(a)
    End Sub

    Function factorial(ByRef a As Integer)
        If (a = 1) Then
            Return 1
        Else
            Return a * factorial(a - 1)
        End If
    End Function
End Class
