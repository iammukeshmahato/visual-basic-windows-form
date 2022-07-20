Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim inputDays As Integer
        inputDays = inputBox.Text

        year.Text = Int(inputDays / 365)
        months.Text = Int((inputDays Mod 365) / 30)
        days.Text = (inputDays Mod 365) Mod 30
    End Sub
End Class
