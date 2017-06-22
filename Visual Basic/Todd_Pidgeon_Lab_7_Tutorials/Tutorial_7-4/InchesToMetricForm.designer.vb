<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InchesToMetricForm
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
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnInchesToMeters = New System.Windows.Forms.Button()
        Me.btnInchesToCM = New System.Windows.Forms.Button()
        Me.btnInchesToMM = New System.Windows.Forms.Button()
        Me.txtInches = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(142, 137)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(100, 42)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "C&lose"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnInchesToMeters
        '
        Me.btnInchesToMeters.Location = New System.Drawing.Point(250, 87)
        Me.btnInchesToMeters.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnInchesToMeters.Name = "btnInchesToMeters"
        Me.btnInchesToMeters.Size = New System.Drawing.Size(100, 42)
        Me.btnInchesToMeters.TabIndex = 3
        Me.btnInchesToMeters.Text = "Convert to M&eters"
        Me.btnInchesToMeters.UseVisualStyleBackColor = True
        '
        'btnInchesToCM
        '
        Me.btnInchesToCM.Location = New System.Drawing.Point(142, 87)
        Me.btnInchesToCM.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnInchesToCM.Name = "btnInchesToCM"
        Me.btnInchesToCM.Size = New System.Drawing.Size(100, 42)
        Me.btnInchesToCM.TabIndex = 2
        Me.btnInchesToCM.Text = "Convert to &Centimeters"
        Me.btnInchesToCM.UseVisualStyleBackColor = True
        '
        'btnInchesToMM
        '
        Me.btnInchesToMM.Location = New System.Drawing.Point(34, 87)
        Me.btnInchesToMM.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnInchesToMM.Name = "btnInchesToMM"
        Me.btnInchesToMM.Size = New System.Drawing.Size(100, 42)
        Me.btnInchesToMM.TabIndex = 1
        Me.btnInchesToMM.Text = "Convert to &Millimeters"
        Me.btnInchesToMM.UseVisualStyleBackColor = True
        '
        'txtInches
        '
        Me.txtInches.Location = New System.Drawing.Point(218, 39)
        Me.txtInches.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtInches.Name = "txtInches"
        Me.txtInches.Size = New System.Drawing.Size(132, 23)
        Me.txtInches.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 42)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(183, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Enter the number of inches:"
        '
        'InchesToMetricForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(390, 200)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnInchesToMeters)
        Me.Controls.Add(Me.btnInchesToCM)
        Me.Controls.Add(Me.btnInchesToMM)
        Me.Controls.Add(Me.txtInches)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "InchesToMetricForm"
        Me.Text = "Inches to Metric"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnInchesToMeters As System.Windows.Forms.Button
    Friend WithEvents btnInchesToCM As System.Windows.Forms.Button
    Friend WithEvents btnInchesToMM As System.Windows.Forms.Button
    Friend WithEvents txtInches As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
