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
        Me.radAir = New System.Windows.Forms.RadioButton()
        Me.radWater = New System.Windows.Forms.RadioButton()
        Me.radSteel = New System.Windows.Forms.RadioButton()
        Me.txtDistance = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblError = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'radAir
        '
        Me.radAir.AutoSize = True
        Me.radAir.Location = New System.Drawing.Point(22, 30)
        Me.radAir.Name = "radAir"
        Me.radAir.Size = New System.Drawing.Size(37, 17)
        Me.radAir.TabIndex = 0
        Me.radAir.TabStop = True
        Me.radAir.Text = "Air"
        Me.radAir.UseVisualStyleBackColor = True
        '
        'radWater
        '
        Me.radWater.AutoSize = True
        Me.radWater.Location = New System.Drawing.Point(22, 53)
        Me.radWater.Name = "radWater"
        Me.radWater.Size = New System.Drawing.Size(54, 17)
        Me.radWater.TabIndex = 1
        Me.radWater.TabStop = True
        Me.radWater.Text = "Water"
        Me.radWater.UseVisualStyleBackColor = True
        '
        'radSteel
        '
        Me.radSteel.AutoSize = True
        Me.radSteel.Location = New System.Drawing.Point(22, 76)
        Me.radSteel.Name = "radSteel"
        Me.radSteel.Size = New System.Drawing.Size(49, 17)
        Me.radSteel.TabIndex = 2
        Me.radSteel.TabStop = True
        Me.radSteel.Text = "Steel"
        Me.radSteel.UseVisualStyleBackColor = True
        '
        'txtDistance
        '
        Me.txtDistance.Location = New System.Drawing.Point(131, 109)
        Me.txtDistance.Name = "txtDistance"
        Me.txtDistance.Size = New System.Drawing.Size(100, 20)
        Me.txtDistance.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(19, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 32)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Distance sound must travel in feet:"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(22, 226)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 5
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 159)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Travel time of sound:"
        '
        'lblTime
        '
        Me.lblTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTime.Location = New System.Drawing.Point(131, 158)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(100, 23)
        Me.lblTime.TabIndex = 7
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(156, 226)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Select a medium:"
        '
        'lblError
        '
        Me.lblError.Location = New System.Drawing.Point(20, 196)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(211, 23)
        Me.lblError.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(254, 261)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDistance)
        Me.Controls.Add(Me.radSteel)
        Me.Controls.Add(Me.radWater)
        Me.Controls.Add(Me.radAir)
        Me.Name = "Form1"
        Me.Text = "Speed of Sound"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents radAir As System.Windows.Forms.RadioButton
    Friend WithEvents radWater As System.Windows.Forms.RadioButton
    Friend WithEvents radSteel As System.Windows.Forms.RadioButton
    Friend WithEvents txtDistance As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblError As System.Windows.Forms.Label

End Class
