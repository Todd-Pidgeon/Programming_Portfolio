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
        Me.lblCounter = New System.Windows.Forms.Label()
        Me.btnToggleTimer = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.tmrSeconds = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(83, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Seconds Counter"
        '
        'lblCounter
        '
        Me.lblCounter.AutoSize = True
        Me.lblCounter.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCounter.Location = New System.Drawing.Point(155, 50)
        Me.lblCounter.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCounter.Name = "lblCounter"
        Me.lblCounter.Size = New System.Drawing.Size(19, 20)
        Me.lblCounter.TabIndex = 3
        Me.lblCounter.Text = "0"
        '
        'btnToggleTimer
        '
        Me.btnToggleTimer.Location = New System.Drawing.Point(63, 97)
        Me.btnToggleTimer.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnToggleTimer.Name = "btnToggleTimer"
        Me.btnToggleTimer.Size = New System.Drawing.Size(100, 28)
        Me.btnToggleTimer.TabIndex = 0
        Me.btnToggleTimer.Text = "&Stop Timer"
        Me.btnToggleTimer.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(171, 97)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 28)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'tmrSeconds
        '
        Me.tmrSeconds.Enabled = True
        Me.tmrSeconds.Interval = 1000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(333, 140)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnToggleTimer)
        Me.Controls.Add(Me.lblCounter)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "Timer Demo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblCounter As System.Windows.Forms.Label
    Friend WithEvents btnToggleTimer As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents tmrSeconds As System.Windows.Forms.Timer

End Class
