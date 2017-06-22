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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lstCelsius = New System.Windows.Forms.ListBox()
        Me.lstFahrenheit = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(180, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fahrenheit"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(46, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Celsius"
        '
        'lstCelsius
        '
        Me.lstCelsius.FormattingEnabled = True
        Me.lstCelsius.Location = New System.Drawing.Point(12, 39)
        Me.lstCelsius.Name = "lstCelsius"
        Me.lstCelsius.Size = New System.Drawing.Size(120, 277)
        Me.lstCelsius.TabIndex = 2
        '
        'lstFahrenheit
        '
        Me.lstFahrenheit.FormattingEnabled = True
        Me.lstFahrenheit.Location = New System.Drawing.Point(152, 39)
        Me.lstFahrenheit.Name = "lstFahrenheit"
        Me.lstFahrenheit.Size = New System.Drawing.Size(120, 277)
        Me.lstFahrenheit.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 341)
        Me.Controls.Add(Me.lstFahrenheit)
        Me.Controls.Add(Me.lstCelsius)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Celsius To Fahrenheit"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lstCelsius As System.Windows.Forms.ListBox
    Friend WithEvents lstFahrenheit As System.Windows.Forms.ListBox

End Class
