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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.time = New System.Windows.Forms.Label()
        Me.ampm = New System.Windows.Forms.Label()
        Me.days = New System.Windows.Forms.Label()
        Me.dates = New System.Windows.Forms.Label()
        Me.MyTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(252, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(177, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Digital Clock"
        '
        'time
        '
        Me.time.AutoSize = True
        Me.time.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.time.Location = New System.Drawing.Point(252, 95)
        Me.time.Name = "time"
        Me.time.Size = New System.Drawing.Size(125, 32)
        Me.time.TabIndex = 1
        Me.time.Text = "00:00:00"
        '
        'ampm
        '
        Me.ampm.AutoSize = True
        Me.ampm.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ampm.Location = New System.Drawing.Point(383, 95)
        Me.ampm.Name = "ampm"
        Me.ampm.Size = New System.Drawing.Size(63, 32)
        Me.ampm.TabIndex = 2
        Me.ampm.Text = "AM"
        '
        'days
        '
        Me.days.AutoSize = True
        Me.days.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.days.Location = New System.Drawing.Point(252, 155)
        Me.days.Name = "days"
        Me.days.Size = New System.Drawing.Size(213, 32)
        Me.days.TabIndex = 3
        Me.days.Text = "Today is Sunday"
        '
        'dates
        '
        Me.dates.AutoSize = True
        Me.dates.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dates.Location = New System.Drawing.Point(252, 230)
        Me.dates.Name = "dates"
        Me.dates.Size = New System.Drawing.Size(226, 32)
        Me.dates.TabIndex = 4
        Me.dates.Text = "Date: 2022/12/12"
        '
        'MyTimer
        '
        Me.MyTimer.Interval = 1000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(676, 352)
        Me.Controls.Add(Me.dates)
        Me.Controls.Add(Me.days)
        Me.Controls.Add(Me.ampm)
        Me.Controls.Add(Me.time)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents time As Label
    Friend WithEvents ampm As Label
    Friend WithEvents days As Label
    Friend WithEvents dates As Label
    Friend WithEvents MyTimer As Timer
End Class
