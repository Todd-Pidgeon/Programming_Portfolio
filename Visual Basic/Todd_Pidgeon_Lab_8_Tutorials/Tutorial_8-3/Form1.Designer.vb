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
        Me.btnCalcPay = New System.Windows.Forms.Button()
        Me.lstOutput = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(163, 176)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(91, 23)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnCalcPay
        '
        Me.btnCalcPay.Location = New System.Drawing.Point(25, 176)
        Me.btnCalcPay.Name = "btnCalcPay"
        Me.btnCalcPay.Size = New System.Drawing.Size(110, 23)
        Me.btnCalcPay.TabIndex = 4
        Me.btnCalcPay.Text = "&Calculate Payroll"
        Me.btnCalcPay.UseVisualStyleBackColor = True
        '
        'lstOutput
        '
        Me.lstOutput.FormattingEnabled = True
        Me.lstOutput.Location = New System.Drawing.Point(25, 12)
        Me.lstOutput.Name = "lstOutput"
        Me.lstOutput.Size = New System.Drawing.Size(229, 134)
        Me.lstOutput.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 231)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalcPay)
        Me.Controls.Add(Me.lstOutput)
        Me.Name = "Form1"
        Me.Text = "Simple Payroll"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents btnCalcPay As Button
    Friend WithEvents lstOutput As ListBox
End Class
