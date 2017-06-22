<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnConvertInches = New System.Windows.Forms.Button()
        Me.btnConvertMeters = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(41, 41)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(337, 43)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "This application converts meters to various English units, and inches to various " &
    "metric units."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(278, 112)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 47)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnConvertInches
        '
        Me.btnConvertInches.Location = New System.Drawing.Point(159, 112)
        Me.btnConvertInches.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnConvertInches.Name = "btnConvertInches"
        Me.btnConvertInches.Size = New System.Drawing.Size(100, 47)
        Me.btnConvertInches.TabIndex = 1
        Me.btnConvertInches.Text = "Convert &Inches"
        Me.btnConvertInches.UseVisualStyleBackColor = True
        '
        'btnConvertMeters
        '
        Me.btnConvertMeters.Location = New System.Drawing.Point(39, 112)
        Me.btnConvertMeters.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnConvertMeters.Name = "btnConvertMeters"
        Me.btnConvertMeters.Size = New System.Drawing.Size(100, 47)
        Me.btnConvertMeters.TabIndex = 0
        Me.btnConvertMeters.Text = "Convert &Meters"
        Me.btnConvertMeters.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 191)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnConvertInches)
        Me.Controls.Add(Me.btnConvertMeters)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "MainForm"
        Me.Text = "Converter"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnConvertInches As System.Windows.Forms.Button
    Friend WithEvents btnConvertMeters As System.Windows.Forms.Button

End Class
