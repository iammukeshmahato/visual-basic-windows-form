Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub myTimer_Tick(sender As Object, e As EventArgs) Handles myTimer.Tick
        myProgressBar.Increment(1)
        Progress.Text = "Loading: " & myProgressBar.Value & "%"
        If myProgressBar.Value = 100 Then
            Progress.Text = "Loading: Completed"
            myTimer.Stop()

        End If


    End Sub

    Private Sub StartBtn_Click(sender As Object, e As EventArgs) Handles StartBtn.Click
        myTimer.Start()
    End Sub

    Private Sub resetBtn_Click(sender As Object, e As EventArgs) Handles resetBtn.Click
        myTimer.Stop()
        myProgressBar.Value = 0
        Progress.Text = "Loading: 0%"
    End Sub
End Class