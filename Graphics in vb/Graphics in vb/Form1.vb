Imports System.Drawing.Drawing2D
Imports System.Drawing.Brushes

Public Class Form1
    Dim g As Graphics

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        g = myDrawingPanel.CreateGraphics
    End Sub

    Private Sub rectBtn_Click(sender As Object, e As EventArgs) Handles rectBtn.Click
        myDrawingPanel.Refresh()
        Dim rectangle As New Rectangle(50, 50, 100, 150)
        g.DrawRectangle(Pens.Red, rectangle)
    End Sub

    Private Sub circleBtn_Click(sender As Object, e As EventArgs) Handles circleBtn.Click
        myDrawingPanel.Refresh()
        Dim circle As New Rectangle(50, 50, 150, 150)
        g.DrawEllipse(Pens.Red, circle)
    End Sub

    Private Sub ellipseBtn_Click(sender As Object, e As EventArgs) Handles ellipseBtn.Click
        myDrawingPanel.Refresh()
        Dim ellipse As New Rectangle(50, 50, 250, 150)
        g.DrawEllipse(Pens.Red, ellipse)
    End Sub

    Private Sub lineBtn_Click(sender As Object, e As EventArgs) Handles lineBtn.Click
        myDrawingPanel.Refresh()
        'Dim ellipse As New Rectangle(50, 50, 200, 150)
        g.DrawLine(Pens.Red, 20, 20, 200, 20)
    End Sub

    Private Sub polygonBtn_Click(sender As Object, e As EventArgs) Handles polygonBtn.Click
        myDrawingPanel.Refresh()
        Dim points(3) As Point
        points(0) = New Point(0, 0)
        points(1) = New Point(200, 0)
        points(2) = New Point(100, 100)
        g.DrawPolygon(Pens.Red, points)
        'g.FillPolygon(Brushes.Black, points)
    End Sub

    Private Sub fillRectBtn_Click(sender As Object, e As EventArgs) Handles fillRectBtn.Click
        myDrawingPanel.Refresh()
        Dim rectangle As New Rectangle(50, 50, 100, 150)
        g.FillRectangle(Brushes.Red, rectangle)
    End Sub

    Private Sub fillCircleBtn_Click(sender As Object, e As EventArgs) Handles fillCircleBtn.Click
        myDrawingPanel.Refresh()
        Dim circle As New Rectangle(50, 50, 150, 150)
        g.FillEllipse(Brushes.Red, circle)
    End Sub

    Private Sub fillEllipseBtn_Click(sender As Object, e As EventArgs) Handles fillEllipseBtn.Click
        myDrawingPanel.Refresh()
        Dim ellipse As New Rectangle(50, 50, 250, 150)
        g.FillEllipse(Brushes.Red, ellipse)
    End Sub

    Private Sub fllPolygonBtn_Click(sender As Object, e As EventArgs) Handles fllPolygonBtn.Click
        myDrawingPanel.Refresh()
        Dim points(3) As Point
        points(0) = New Point(0, 0)
        points(1) = New Point(200, 0)
        points(2) = New Point(100, 100)
        g.FillPolygon(Brushes.Red, points)
    End Sub
End Class
