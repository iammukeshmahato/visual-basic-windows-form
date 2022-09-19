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
        Me.myDrawingPanel = New System.Windows.Forms.Panel()
        Me.PanelClearBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'myDrawingPanel
        '
        Me.myDrawingPanel.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.myDrawingPanel.Location = New System.Drawing.Point(38, 26)
        Me.myDrawingPanel.Name = "myDrawingPanel"
        Me.myDrawingPanel.Size = New System.Drawing.Size(956, 931)
        Me.myDrawingPanel.TabIndex = 0
        '
        'PanelClearBtn
        '
        Me.PanelClearBtn.Location = New System.Drawing.Point(253, 988)
        Me.PanelClearBtn.Name = "PanelClearBtn"
        Me.PanelClearBtn.Size = New System.Drawing.Size(521, 57)
        Me.PanelClearBtn.TabIndex = 1
        Me.PanelClearBtn.Text = "Clear Panel"
        Me.PanelClearBtn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1033, 1074)
        Me.Controls.Add(Me.PanelClearBtn)
        Me.Controls.Add(Me.myDrawingPanel)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents myDrawingPanel As Panel
    Friend WithEvents PanelClearBtn As Button
End Class
