<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.myProgressBar = New System.Windows.Forms.ProgressBar()
        Me.Progress = New System.Windows.Forms.Label()
        Me.myTimer = New System.Windows.Forms.Timer(Me.components)
        Me.StartBtn = New System.Windows.Forms.Button()
        Me.resetBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(399, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 32)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Progress Bar"
        '
        'myProgressBar
        '
        Me.myProgressBar.Location = New System.Drawing.Point(97, 110)
        Me.myProgressBar.MarqueeAnimationSpeed = 10
        Me.myProgressBar.Name = "myProgressBar"
        Me.myProgressBar.Size = New System.Drawing.Size(727, 23)
        Me.myProgressBar.TabIndex = 6
        '
        'Progress
        '
        Me.Progress.AutoSize = True
        Me.Progress.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Progress.Location = New System.Drawing.Point(426, 150)
        Me.Progress.Name = "Progress"
        Me.Progress.Size = New System.Drawing.Size(96, 19)
        Me.Progress.TabIndex = 7
        Me.Progress.Text = "Loading: 0%"
        '
        'myTimer
        '
        '
        'StartBtn
        '
        Me.StartBtn.Location = New System.Drawing.Point(333, 208)
        Me.StartBtn.Name = "StartBtn"
        Me.StartBtn.Size = New System.Drawing.Size(75, 23)
        Me.StartBtn.TabIndex = 8
        Me.StartBtn.Text = "Start"
        Me.StartBtn.UseVisualStyleBackColor = True
        '
        'resetBtn
        '
        Me.resetBtn.Location = New System.Drawing.Point(487, 208)
        Me.resetBtn.Name = "resetBtn"
        Me.resetBtn.Size = New System.Drawing.Size(75, 23)
        Me.resetBtn.TabIndex = 9
        Me.resetBtn.Text = "Reset"
        Me.resetBtn.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(905, 261)
        Me.Controls.Add(Me.resetBtn)
        Me.Controls.Add(Me.StartBtn)
        Me.Controls.Add(Me.Progress)
        Me.Controls.Add(Me.myProgressBar)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents myProgressBar As ProgressBar
    Friend WithEvents Progress As Label
    Friend WithEvents myTimer As Timer
    Friend WithEvents StartBtn As Button
    Friend WithEvents resetBtn As Button
End Class
