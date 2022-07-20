<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class colorPicker
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
        Me.setColor = New System.Windows.Forms.Button()
        Me.preview = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.blueScroller = New System.Windows.Forms.HScrollBar()
        Me.greenScroller = New System.Windows.Forms.HScrollBar()
        Me.redScroller = New System.Windows.Forms.HScrollBar()
        Me.SuspendLayout()
        '
        'setColor
        '
        Me.setColor.Location = New System.Drawing.Point(580, 370)
        Me.setColor.Name = "setColor"
        Me.setColor.Size = New System.Drawing.Size(75, 23)
        Me.setColor.TabIndex = 15
        Me.setColor.Text = "Set Background"
        Me.setColor.UseVisualStyleBackColor = True
        '
        'preview
        '
        Me.preview.BackColor = System.Drawing.SystemColors.Control
        Me.preview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.preview.Location = New System.Drawing.Point(228, 331)
        Me.preview.Name = "preview"
        Me.preview.Size = New System.Drawing.Size(155, 103)
        Me.preview.TabIndex = 14
        Me.preview.Text = "Preview"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(228, 183)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Blue"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(228, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Green"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(228, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Red"
        '
        'blueScroller
        '
        Me.blueScroller.Location = New System.Drawing.Point(328, 174)
        Me.blueScroller.Maximum = 255
        Me.blueScroller.Name = "blueScroller"
        Me.blueScroller.Size = New System.Drawing.Size(327, 22)
        Me.blueScroller.TabIndex = 10
        '
        'greenScroller
        '
        Me.greenScroller.Location = New System.Drawing.Point(328, 102)
        Me.greenScroller.Maximum = 255
        Me.greenScroller.Name = "greenScroller"
        Me.greenScroller.Size = New System.Drawing.Size(327, 22)
        Me.greenScroller.TabIndex = 9
        '
        'redScroller
        '
        Me.redScroller.Location = New System.Drawing.Point(328, 29)
        Me.redScroller.Maximum = 255
        Me.redScroller.Name = "redScroller"
        Me.redScroller.Size = New System.Drawing.Size(327, 22)
        Me.redScroller.TabIndex = 8
        '
        'colorPicker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(813, 463)
        Me.Controls.Add(Me.setColor)
        Me.Controls.Add(Me.preview)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.blueScroller)
        Me.Controls.Add(Me.greenScroller)
        Me.Controls.Add(Me.redScroller)
        Me.Name = "colorPicker"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents setColor As Button
    Friend WithEvents preview As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents blueScroller As HScrollBar
    Friend WithEvents greenScroller As HScrollBar
    Friend WithEvents redScroller As HScrollBar
End Class
