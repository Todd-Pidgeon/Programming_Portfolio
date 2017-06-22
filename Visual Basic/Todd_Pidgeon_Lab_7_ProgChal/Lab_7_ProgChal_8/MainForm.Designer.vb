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
        Me.lstPlanets = New System.Windows.Forms.ListBox()
        Me.btnInfo = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(91, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select a Planet"
        '
        'lstPlanets
        '
        Me.lstPlanets.FormattingEnabled = True
        Me.lstPlanets.Items.AddRange(New Object() {"Mercury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune", "Pluto"})
        Me.lstPlanets.Location = New System.Drawing.Point(79, 70)
        Me.lstPlanets.Name = "lstPlanets"
        Me.lstPlanets.Size = New System.Drawing.Size(106, 134)
        Me.lstPlanets.TabIndex = 1
        '
        'btnInfo
        '
        Me.btnInfo.Location = New System.Drawing.Point(24, 224)
        Me.btnInfo.Name = "btnInfo"
        Me.btnInfo.Size = New System.Drawing.Size(94, 58)
        Me.btnInfo.TabIndex = 2
        Me.btnInfo.Text = "View Info About Planet"
        Me.btnInfo.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(145, 224)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(94, 58)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(281, 294)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnInfo)
        Me.Controls.Add(Me.lstPlanets)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MainForm"
        Me.Text = "Planet Info"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lstPlanets As System.Windows.Forms.ListBox
    Friend WithEvents btnInfo As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
