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
        Me.txtSpeed = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblFiveHours = New System.Windows.Forms.Label()
        Me.lblEightHours = New System.Windows.Forms.Label()
        Me.lblTwelveHours = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(71, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Car's Speed in MPH:"
        '
        'txtSpeed
        '
        Me.txtSpeed.Location = New System.Drawing.Point(182, 22)
        Me.txtSpeed.Name = "txtSpeed"
        Me.txtSpeed.Size = New System.Drawing.Size(100, 20)
        Me.txtSpeed.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(205, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "The Distance the car will travel in 5 hours:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 105)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(205, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "The Distance the car will travel in 8 hours:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 138)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(211, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "The Distance the car will travel in 12 hours:"
        '
        'lblFiveHours
        '
        Me.lblFiveHours.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFiveHours.Location = New System.Drawing.Point(229, 68)
        Me.lblFiveHours.Name = "lblFiveHours"
        Me.lblFiveHours.Size = New System.Drawing.Size(100, 23)
        Me.lblFiveHours.TabIndex = 7
        '
        'lblEightHours
        '
        Me.lblEightHours.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEightHours.Location = New System.Drawing.Point(229, 104)
        Me.lblEightHours.Name = "lblEightHours"
        Me.lblEightHours.Size = New System.Drawing.Size(100, 23)
        Me.lblEightHours.TabIndex = 8
        '
        'lblTwelveHours
        '
        Me.lblTwelveHours.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTwelveHours.Location = New System.Drawing.Point(229, 137)
        Me.lblTwelveHours.Name = "lblTwelveHours"
        Me.lblTwelveHours.Size = New System.Drawing.Size(100, 23)
        Me.lblTwelveHours.TabIndex = 9
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(42, 181)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 10
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(229, 181)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(353, 262)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblTwelveHours)
        Me.Controls.Add(Me.lblEightHours)
        Me.Controls.Add(Me.lblFiveHours)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSpeed)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Distance Traveled"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtSpeed As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblFiveHours As Label
    Friend WithEvents lblEightHours As Label
    Friend WithEvents lblTwelveHours As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnExit As Button
End Class
