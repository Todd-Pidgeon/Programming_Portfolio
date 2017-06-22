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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblRoman = New System.Windows.Forms.Label()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 34)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter a decimal integer in the range 1 - 10:"
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(141, 12)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(192, 20)
        Me.txtInput.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(12, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 34)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Equivalent Roman Numeral:"
        '
        'lblRoman
        '
        Me.lblRoman.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRoman.Location = New System.Drawing.Point(141, 72)
        Me.lblRoman.Name = "lblRoman"
        Me.lblRoman.Size = New System.Drawing.Size(192, 23)
        Me.lblRoman.TabIndex = 3
        Me.lblRoman.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnConvert
        '
        Me.btnConvert.Location = New System.Drawing.Point(47, 152)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(75, 23)
        Me.btnConvert.TabIndex = 4
        Me.btnConvert.Text = "Convert"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(213, 152)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(345, 198)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.lblRoman)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Roman Numeral Converter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtInput As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblRoman As System.Windows.Forms.Label
    Friend WithEvents btnConvert As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
