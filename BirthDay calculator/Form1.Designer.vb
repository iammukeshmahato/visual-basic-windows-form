<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dobPicker = New System.Windows.Forms.DateTimePicker()
        Me.todayDate = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.days = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.months = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.year = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CalculateBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(174, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DOB"
        '
        'dobPicker
        '
        Me.dobPicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dobPicker.Location = New System.Drawing.Point(237, 54)
        Me.dobPicker.Name = "dobPicker"
        Me.dobPicker.Size = New System.Drawing.Size(252, 22)
        Me.dobPicker.TabIndex = 1
        '
        'todayDate
        '
        Me.todayDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.todayDate.Location = New System.Drawing.Point(237, 130)
        Me.todayDate.Name = "todayDate"
        Me.todayDate.Size = New System.Drawing.Size(252, 22)
        Me.todayDate.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(174, 131)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Today"
        '
        'days
        '
        Me.days.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.days.Location = New System.Drawing.Point(436, 265)
        Me.days.Name = "days"
        Me.days.Size = New System.Drawing.Size(50, 22)
        Me.days.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(401, 265)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 16)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "days"
        '
        'months
        '
        Me.months.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.months.Location = New System.Drawing.Point(331, 262)
        Me.months.Name = "months"
        Me.months.Size = New System.Drawing.Size(50, 22)
        Me.months.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(284, 265)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 16)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "months"
        '
        'year
        '
        Me.year.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.year.Location = New System.Drawing.Point(211, 262)
        Me.year.Name = "year"
        Me.year.Size = New System.Drawing.Size(50, 22)
        Me.year.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(176, 262)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 16)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Year"
        '
        'CalculateBtn
        '
        Me.CalculateBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CalculateBtn.Location = New System.Drawing.Point(306, 187)
        Me.CalculateBtn.Name = "CalculateBtn"
        Me.CalculateBtn.Size = New System.Drawing.Size(87, 29)
        Me.CalculateBtn.TabIndex = 16
        Me.CalculateBtn.Text = "Calculate"
        Me.CalculateBtn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(722, 335)
        Me.Controls.Add(Me.CalculateBtn)
        Me.Controls.Add(Me.days)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.months)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.year)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.todayDate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dobPicker)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dobPicker As DateTimePicker
    Friend WithEvents todayDate As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents days As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents months As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents year As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents CalculateBtn As Button
End Class
