<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.myDrawingPanel = New System.Windows.Forms.Panel()
        Me.rectBtn = New System.Windows.Forms.Button()
        Me.circleBtn = New System.Windows.Forms.Button()
        Me.ellipseBtn = New System.Windows.Forms.Button()
        Me.lineBtn = New System.Windows.Forms.Button()
        Me.polygonBtn = New System.Windows.Forms.Button()
        Me.fllPolygonBtn = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.fillEllipseBtn = New System.Windows.Forms.Button()
        Me.fillCircleBtn = New System.Windows.Forms.Button()
        Me.fillRectBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'myDrawingPanel
        '
        Me.myDrawingPanel.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.myDrawingPanel.Location = New System.Drawing.Point(275, 12)
        Me.myDrawingPanel.Name = "myDrawingPanel"
        Me.myDrawingPanel.Size = New System.Drawing.Size(401, 334)
        Me.myDrawingPanel.TabIndex = 0
        '
        'rectBtn
        '
        Me.rectBtn.Location = New System.Drawing.Point(48, 23)
        Me.rectBtn.Name = "rectBtn"
        Me.rectBtn.Size = New System.Drawing.Size(175, 39)
        Me.rectBtn.TabIndex = 1
        Me.rectBtn.Text = "Rectangle"
        Me.rectBtn.UseVisualStyleBackColor = True
        '
        'circleBtn
        '
        Me.circleBtn.Location = New System.Drawing.Point(48, 95)
        Me.circleBtn.Name = "circleBtn"
        Me.circleBtn.Size = New System.Drawing.Size(175, 39)
        Me.circleBtn.TabIndex = 2
        Me.circleBtn.Text = "Circle"
        Me.circleBtn.UseVisualStyleBackColor = True
        '
        'ellipseBtn
        '
        Me.ellipseBtn.Location = New System.Drawing.Point(48, 155)
        Me.ellipseBtn.Name = "ellipseBtn"
        Me.ellipseBtn.Size = New System.Drawing.Size(175, 39)
        Me.ellipseBtn.TabIndex = 3
        Me.ellipseBtn.Text = "Ellipse"
        Me.ellipseBtn.UseVisualStyleBackColor = True
        '
        'lineBtn
        '
        Me.lineBtn.Location = New System.Drawing.Point(48, 219)
        Me.lineBtn.Name = "lineBtn"
        Me.lineBtn.Size = New System.Drawing.Size(175, 39)
        Me.lineBtn.TabIndex = 4
        Me.lineBtn.Text = "Line"
        Me.lineBtn.UseVisualStyleBackColor = True
        '
        'polygonBtn
        '
        Me.polygonBtn.Location = New System.Drawing.Point(48, 286)
        Me.polygonBtn.Name = "polygonBtn"
        Me.polygonBtn.Size = New System.Drawing.Size(175, 39)
        Me.polygonBtn.TabIndex = 5
        Me.polygonBtn.Text = "Polygon"
        Me.polygonBtn.UseVisualStyleBackColor = True
        '
        'fllPolygonBtn
        '
        Me.fllPolygonBtn.Location = New System.Drawing.Point(748, 286)
        Me.fllPolygonBtn.Name = "fllPolygonBtn"
        Me.fllPolygonBtn.Size = New System.Drawing.Size(175, 39)
        Me.fllPolygonBtn.TabIndex = 10
        Me.fllPolygonBtn.Text = "Fill Polygon"
        Me.fllPolygonBtn.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(748, 219)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(175, 39)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Line"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'fillEllipseBtn
        '
        Me.fillEllipseBtn.Location = New System.Drawing.Point(748, 155)
        Me.fillEllipseBtn.Name = "fillEllipseBtn"
        Me.fillEllipseBtn.Size = New System.Drawing.Size(175, 39)
        Me.fillEllipseBtn.TabIndex = 8
        Me.fillEllipseBtn.Text = "Fill Ellipse"
        Me.fillEllipseBtn.UseVisualStyleBackColor = True
        '
        'fillCircleBtn
        '
        Me.fillCircleBtn.Location = New System.Drawing.Point(748, 95)
        Me.fillCircleBtn.Name = "fillCircleBtn"
        Me.fillCircleBtn.Size = New System.Drawing.Size(175, 39)
        Me.fillCircleBtn.TabIndex = 7
        Me.fillCircleBtn.Text = "Fill Circle"
        Me.fillCircleBtn.UseVisualStyleBackColor = True
        '
        'fillRectBtn
        '
        Me.fillRectBtn.Location = New System.Drawing.Point(748, 23)
        Me.fillRectBtn.Name = "fillRectBtn"
        Me.fillRectBtn.Size = New System.Drawing.Size(175, 39)
        Me.fillRectBtn.TabIndex = 6
        Me.fillRectBtn.Text = "Fill Rectangle"
        Me.fillRectBtn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(986, 362)
        Me.Controls.Add(Me.fllPolygonBtn)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.fillEllipseBtn)
        Me.Controls.Add(Me.fillCircleBtn)
        Me.Controls.Add(Me.fillRectBtn)
        Me.Controls.Add(Me.polygonBtn)
        Me.Controls.Add(Me.lineBtn)
        Me.Controls.Add(Me.ellipseBtn)
        Me.Controls.Add(Me.circleBtn)
        Me.Controls.Add(Me.rectBtn)
        Me.Controls.Add(Me.myDrawingPanel)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents myDrawingPanel As Panel
    Friend WithEvents rectBtn As Button
    Friend WithEvents circleBtn As Button
    Friend WithEvents ellipseBtn As Button
    Friend WithEvents lineBtn As Button
    Friend WithEvents polygonBtn As Button
    Friend WithEvents fllPolygonBtn As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents fillEllipseBtn As Button
    Friend WithEvents fillCircleBtn As Button
    Friend WithEvents fillRectBtn As Button
End Class
