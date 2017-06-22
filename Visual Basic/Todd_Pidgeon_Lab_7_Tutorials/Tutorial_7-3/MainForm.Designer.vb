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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radBanana = New System.Windows.Forms.RadioButton()
        Me.radPopcorn = New System.Windows.Forms.RadioButton()
        Me.radMuffin = New System.Windows.Forms.RadioButton()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radMuffin)
        Me.GroupBox1.Controls.Add(Me.radPopcorn)
        Me.GroupBox1.Controls.Add(Me.radBanana)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(177, 103)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select A Food"
        '
        'radBanana
        '
        Me.radBanana.AutoSize = True
        Me.radBanana.Location = New System.Drawing.Point(7, 20)
        Me.radBanana.Name = "radBanana"
        Me.radBanana.Size = New System.Drawing.Size(70, 17)
        Me.radBanana.TabIndex = 0
        Me.radBanana.TabStop = True
        Me.radBanana.Text = "1 banana"
        Me.radBanana.UseVisualStyleBackColor = True
        '
        'radPopcorn
        '
        Me.radPopcorn.AutoSize = True
        Me.radPopcorn.Location = New System.Drawing.Point(6, 43)
        Me.radPopcorn.Name = "radPopcorn"
        Me.radPopcorn.Size = New System.Drawing.Size(159, 17)
        Me.radPopcorn.TabIndex = 1
        Me.radPopcorn.TabStop = True
        Me.radPopcorn.Text = "1 cup of air-popped popcorn"
        Me.radPopcorn.UseVisualStyleBackColor = True
        '
        'radMuffin
        '
        Me.radMuffin.AutoSize = True
        Me.radMuffin.Location = New System.Drawing.Point(6, 66)
        Me.radMuffin.Name = "radMuffin"
        Me.radMuffin.Size = New System.Drawing.Size(134, 17)
        Me.radMuffin.TabIndex = 2
        Me.radMuffin.TabStop = True
        Me.radMuffin.Text = "1 large blueberry muffin"
        Me.radMuffin.UseVisualStyleBackColor = True
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(12, 137)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(75, 41)
        Me.btnDisplay.TabIndex = 1
        Me.btnDisplay.Text = "&Display Food Facts"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(114, 137)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 41)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(210, 196)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "MainForm"
        Me.Text = "Food Facts"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radMuffin As RadioButton
    Friend WithEvents radPopcorn As RadioButton
    Friend WithEvents radBanana As RadioButton
    Friend WithEvents btnDisplay As Button
    Friend WithEvents btnExit As Button
End Class
