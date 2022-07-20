Public Class Form1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles MyTimer.Tick
        time.Text = Date.Now.ToString("hh:mm:ss")
        ampm.Text = Date.Now.ToString("tt")
        days.Text = "Today is " & Date.Now.ToString("dddd")
        dates.Text = "Date: " & Date.Now.Date


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MyTimer.Start()
    End Sub
End Class
