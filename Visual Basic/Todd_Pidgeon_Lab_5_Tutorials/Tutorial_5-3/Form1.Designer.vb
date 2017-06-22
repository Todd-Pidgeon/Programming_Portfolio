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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnRunDemo = New System.Windows.Forms.Button()
        Me.lstOutput = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(100, 271)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 28)
        Me.btnExit.TabIndex = 15
        Me.btnExit.Text = "E&xit"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(164, 231)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 28)
        Me.btnClear.TabIndex = 14
        Me.btnClear.Text = "C&lear"
        '
        'btnRunDemo
        '
        Me.btnRunDemo.Location = New System.Drawing.Point(36, 231)
        Me.btnRunDemo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnRunDemo.Name = "btnRunDemo"
        Me.btnRunDemo.Size = New System.Drawing.Size(100, 28)
        Me.btnRunDemo.TabIndex = 13
        Me.btnRunDemo.Text = "&Run Demo"
        '
        'lstOutput
        '
        Me.lstOutput.ItemHeight = 16
        Me.lstOutput.Location = New System.Drawing.Point(37, 15)
        Me.lstOutput.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lstOutput.Name = "lstOutput"
        Me.lstOutput.Size = New System.Drawing.Size(223, 196)
        Me.lstOutput.TabIndex = 12
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(299, 313)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnRunDemo)
        Me.Controls.Add(Me.lstOutput)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Do While Demo"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnRunDemo As System.Windows.Forms.Button
    Friend WithEvents lstOutput As System.Windows.Forms.ListBox

End Class
