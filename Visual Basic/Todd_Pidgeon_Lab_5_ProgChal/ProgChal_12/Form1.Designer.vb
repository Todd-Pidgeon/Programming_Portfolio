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
        Me.cboSpeed = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstBurned = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cboSpeed
        '
        Me.cboSpeed.FormattingEnabled = True
        Me.cboSpeed.Items.AddRange(New Object() {"Low", "Medium", "High"})
        Me.cboSpeed.Location = New System.Drawing.Point(65, 32)
        Me.cboSpeed.Name = "cboSpeed"
        Me.cboSpeed.Size = New System.Drawing.Size(121, 21)
        Me.cboSpeed.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Speed:"
        '
        'lstBurned
        '
        Me.lstBurned.FormattingEnabled = True
        Me.lstBurned.Location = New System.Drawing.Point(24, 112)
        Me.lstBurned.Name = "lstBurned"
        Me.lstBurned.Size = New System.Drawing.Size(210, 95)
        Me.lstBurned.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(81, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Calories Burned"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lstBurned)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboSpeed)
        Me.Name = "Form1"
        Me.Text = "Burning Calories"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboSpeed As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lstBurned As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
