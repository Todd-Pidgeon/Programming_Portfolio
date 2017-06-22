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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtWeekOne = New System.Windows.Forms.TextBox()
        Me.txtWeekTwo = New System.Windows.Forms.TextBox()
        Me.txtWeekThree = New System.Windows.Forms.TextBox()
        Me.txtWeekFour = New System.Windows.Forms.TextBox()
        Me.txtWeekFive = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblAverage = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Week #1:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Week #2:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Week #3:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Week #4:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(32, 129)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Week #5:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(35, 160)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Average:"
        '
        'txtWeekOne
        '
        Me.txtWeekOne.Location = New System.Drawing.Point(91, 15)
        Me.txtWeekOne.Name = "txtWeekOne"
        Me.txtWeekOne.Size = New System.Drawing.Size(100, 20)
        Me.txtWeekOne.TabIndex = 6
        '
        'txtWeekTwo
        '
        Me.txtWeekTwo.Location = New System.Drawing.Point(91, 41)
        Me.txtWeekTwo.Name = "txtWeekTwo"
        Me.txtWeekTwo.Size = New System.Drawing.Size(100, 20)
        Me.txtWeekTwo.TabIndex = 7
        '
        'txtWeekThree
        '
        Me.txtWeekThree.Location = New System.Drawing.Point(91, 67)
        Me.txtWeekThree.Name = "txtWeekThree"
        Me.txtWeekThree.Size = New System.Drawing.Size(100, 20)
        Me.txtWeekThree.TabIndex = 8
        '
        'txtWeekFour
        '
        Me.txtWeekFour.Location = New System.Drawing.Point(91, 96)
        Me.txtWeekFour.Name = "txtWeekFour"
        Me.txtWeekFour.Size = New System.Drawing.Size(100, 20)
        Me.txtWeekFour.TabIndex = 9
        '
        'txtWeekFive
        '
        Me.txtWeekFive.Location = New System.Drawing.Point(91, 126)
        Me.txtWeekFive.Name = "txtWeekFive"
        Me.txtWeekFive.Size = New System.Drawing.Size(100, 20)
        Me.txtWeekFive.TabIndex = 10
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(12, 215)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 12
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(106, 215)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 13
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(204, 215)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 14
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblAverage
        '
        Me.lblAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAverage.Location = New System.Drawing.Point(91, 160)
        Me.lblAverage.Name = "lblAverage"
        Me.lblAverage.Size = New System.Drawing.Size(100, 23)
        Me.lblAverage.TabIndex = 15
        Me.lblAverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(311, 269)
        Me.Controls.Add(Me.lblAverage)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtWeekFive)
        Me.Controls.Add(Me.txtWeekFour)
        Me.Controls.Add(Me.txtWeekThree)
        Me.Controls.Add(Me.txtWeekTwo)
        Me.Controls.Add(Me.txtWeekOne)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Weekly Temperature Average"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtWeekOne As TextBox
    Friend WithEvents txtWeekTwo As TextBox
    Friend WithEvents txtWeekThree As TextBox
    Friend WithEvents txtWeekFour As TextBox
    Friend WithEvents txtWeekFive As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblAverage As Label
End Class
