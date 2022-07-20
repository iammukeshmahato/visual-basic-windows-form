Public Class colorPicker
    Private Sub redScroller_Scroll(sender As Object, e As ScrollEventArgs) Handles redScroller.Scroll, greenScroller.Scroll, blueScroller.Scroll
        preview.BackColor = Color.FromArgb(redScroller.Value, greenScroller.Value, blueScroller.Value)
    End Sub

    Private Sub setColor_Click(sender As Object, e As EventArgs) Handles setColor.Click
        Me.BackColor = preview.BackColor
    End Sub
End Class
