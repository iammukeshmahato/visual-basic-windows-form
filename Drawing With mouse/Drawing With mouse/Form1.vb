Imports System.Drawing.Drawing2D
Public Class Form1
    Dim g As Graphics
    Dim p1, p2 As Point
    Dim isClicked As Boolean
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        g = myDrawingPanel.CreateGraphics
    End Sub

    Private Sub myDrawingPanel_MouseDown(sender As Object, e As MouseEventArgs) Handles myDrawingPanel.MouseDown
        p1 = New Point(e.X, e.Y)
        isClicked = True
    End Sub

    Private Sub myDrawingPanel_MouseMove(sender As Object, e As MouseEventArgs) Handles myDrawingPanel.MouseMove
        If isClicked Then
            p2 = New Point(e.X, e.Y)
            Dim r As New Rectangle(Math.Min(p1.X, p2.X), Math.Min(p1.Y, p2.Y), Math.Abs(p1.X - p2.X), Math.Abs(p1.Y - p2.Y))
            myDrawingPanel.Refresh()
            g.DrawRectangle(Pens.Red, r)
        End If
    End Sub

    Private Sub myDrawingPanel_MouseUp(sender As Object, e As MouseEventArgs) Handles myDrawingPanel.MouseUp
        isClicked = False
        p2 = New Point(e.X, e.Y)
        Dim r As New Rectangle(Math.Min(p1.X, p2.X), Math.Min(p1.Y, p2.Y), Math.Abs(p1.X - p2.X), Math.Abs(p1.Y - p2.Y))
        g.DrawRectangle(Pens.Red, r)
    End Sub

    Private Sub PanelClearBtn_Click(sender As Object, e As EventArgs) Handles PanelClearBtn.Click
        myDrawingPanel.Refresh()
    End Sub

End Class
