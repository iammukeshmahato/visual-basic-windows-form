Public Class Form1
    Private Sub CalculateBtn_Click(sender As Object, e As EventArgs) Handles CalculateBtn.Click
        Dim dob As Date
        Dim today As Date
        Dim diffDays As Double
        Dim difference As TimeSpan

        dob = dobPicker.Value.ToShortDateString
        today = todayDate.Value.ToShortDateString

        difference = today - dob

        diffDays = difference.Days

        year.Text = Int(diffDays / 365)
        months.Text = Int((diffDays Mod 365) / 30)
        days.Text = ((diffDays Mod 365) Mod 30)

    End Sub

End Class
