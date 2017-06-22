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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtMonths = New System.Windows.Forms.TextBox()
        Me.txtDownPayment = New System.Windows.Forms.TextBox()
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.radUsed = New System.Windows.Forms.RadioButton()
        Me.radNew = New System.Windows.Forms.RadioButton()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lstOutput = New System.Windows.Forms.ListBox()
        Me.lblAnnualRate = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtMonths)
        Me.GroupBox1.Controls.Add(Me.txtDownPayment)
        Me.GroupBox1.Controls.Add(Me.txtCost)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(266, 103)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Vehicle && Loan Calculator"
        '
        'txtMonths
        '
        Me.txtMonths.Location = New System.Drawing.Point(146, 69)
        Me.txtMonths.Name = "txtMonths"
        Me.txtMonths.Size = New System.Drawing.Size(100, 20)
        Me.txtMonths.TabIndex = 5
        '
        'txtDownPayment
        '
        Me.txtDownPayment.Location = New System.Drawing.Point(146, 43)
        Me.txtDownPayment.Name = "txtDownPayment"
        Me.txtDownPayment.Size = New System.Drawing.Size(100, 20)
        Me.txtDownPayment.TabIndex = 4
        '
        'txtCost
        '
        Me.txtCost.Location = New System.Drawing.Point(146, 17)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Size = New System.Drawing.Size(100, 20)
        Me.txtCost.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(43, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Number of Months:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Amount of Down Payment:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(59, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cost of Vehicle:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.radUsed)
        Me.GroupBox2.Controls.Add(Me.radNew)
        Me.GroupBox2.Location = New System.Drawing.Point(300, 13)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(99, 103)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "New or Used?"
        '
        'radUsed
        '
        Me.radUsed.AutoSize = True
        Me.radUsed.Location = New System.Drawing.Point(21, 68)
        Me.radUsed.Name = "radUsed"
        Me.radUsed.Size = New System.Drawing.Size(50, 17)
        Me.radUsed.TabIndex = 1
        Me.radUsed.TabStop = True
        Me.radUsed.Text = "&Used"
        Me.radUsed.UseVisualStyleBackColor = True
        '
        'radNew
        '
        Me.radNew.AutoSize = True
        Me.radNew.Location = New System.Drawing.Point(21, 30)
        Me.radNew.Name = "radNew"
        Me.radNew.Size = New System.Drawing.Size(47, 17)
        Me.radNew.TabIndex = 0
        Me.radNew.TabStop = True
        Me.radNew.Text = "&New"
        Me.radNew.UseVisualStyleBackColor = True
        '
        'lblMessage
        '
        Me.lblMessage.Location = New System.Drawing.Point(13, 123)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(386, 23)
        Me.lblMessage.TabIndex = 2
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lstOutput)
        Me.GroupBox3.Controls.Add(Me.lblAnnualRate)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Location = New System.Drawing.Point(13, 150)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(386, 342)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Interest and Principal Payments"
        '
        'lstOutput
        '
        Me.lstOutput.FormattingEnabled = True
        Me.lstOutput.Location = New System.Drawing.Point(26, 83)
        Me.lstOutput.Name = "lstOutput"
        Me.lstOutput.Size = New System.Drawing.Size(332, 238)
        Me.lstOutput.TabIndex = 2
        '
        'lblAnnualRate
        '
        Me.lblAnnualRate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAnnualRate.Location = New System.Drawing.Point(252, 34)
        Me.lblAnnualRate.Name = "lblAnnualRate"
        Me.lblAnnualRate.Size = New System.Drawing.Size(100, 23)
        Me.lblAnnualRate.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(139, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Annual Interest Rate:"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(78, 517)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(173, 517)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(265, 517)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 564)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Loan Calculator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtMonths As System.Windows.Forms.TextBox
    Friend WithEvents txtDownPayment As System.Windows.Forms.TextBox
    Friend WithEvents txtCost As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents radUsed As System.Windows.Forms.RadioButton
    Friend WithEvents radNew As System.Windows.Forms.RadioButton
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lstOutput As System.Windows.Forms.ListBox
    Friend WithEvents lblAnnualRate As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
