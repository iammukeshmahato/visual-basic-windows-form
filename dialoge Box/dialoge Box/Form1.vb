Public Class Form1
    Private Sub calculate_Click(sender As Object, e As EventArgs) Handles calculate.Click
        Dim si As Double
        si = (principle.Text * time.Text * rate.Text) / 100
        MessageBox.Show("The simple interest = " & si)


    End Sub
End Class