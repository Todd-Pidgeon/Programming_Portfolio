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
        Me.txtCookies = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblCalories = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Number of cookies you ate:"
        '
        'txtCookies
        '
        Me.txtCookies.Location = New System.Drawing.Point(166, 21)
        Me.txtCookies.Name = "txtCookies"
        Me.txtCookies.Size = New System.Drawing.Size(100, 20)
        Me.txtCookies.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Total calories consumed:"
        '
        'lblCalories
        '
        Me.lblCalories.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCalories.Location = New System.Drawing.Point(166, 81)
        Me.lblCalories.Name = "lblCalories"
        Me.lblCalories.Size = New System.Drawing.Size(100, 23)
        Me.lblCalories.TabIndex = 3
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(26, 165)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(191, 165)
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
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblCalories)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCookies)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "How Many Calories?"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtCookies As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblCalories As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnExit As Button
End Class
