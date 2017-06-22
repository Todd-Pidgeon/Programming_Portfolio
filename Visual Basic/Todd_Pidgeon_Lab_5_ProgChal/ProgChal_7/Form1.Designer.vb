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
        Me.radAdd = New System.Windows.Forms.RadioButton()
        Me.radSub = New System.Windows.Forms.RadioButton()
        Me.radMulti = New System.Windows.Forms.RadioButton()
        Me.radDiv = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblQuestion = New System.Windows.Forms.Label()
        Me.txtAnswer = New System.Windows.Forms.TextBox()
        Me.lblCheck = New System.Windows.Forms.Label()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.btnNextProblem = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'radAdd
        '
        Me.radAdd.AutoSize = True
        Me.radAdd.Checked = True
        Me.radAdd.Location = New System.Drawing.Point(27, 36)
        Me.radAdd.Name = "radAdd"
        Me.radAdd.Size = New System.Drawing.Size(63, 17)
        Me.radAdd.TabIndex = 1
        Me.radAdd.TabStop = True
        Me.radAdd.Text = "Addition"
        Me.radAdd.UseVisualStyleBackColor = True
        '
        'radSub
        '
        Me.radSub.AutoSize = True
        Me.radSub.Location = New System.Drawing.Point(137, 36)
        Me.radSub.Name = "radSub"
        Me.radSub.Size = New System.Drawing.Size(79, 17)
        Me.radSub.TabIndex = 2
        Me.radSub.Text = "Subtraction"
        Me.radSub.UseVisualStyleBackColor = True
        '
        'radMulti
        '
        Me.radMulti.AutoSize = True
        Me.radMulti.Location = New System.Drawing.Point(275, 36)
        Me.radMulti.Name = "radMulti"
        Me.radMulti.Size = New System.Drawing.Size(86, 17)
        Me.radMulti.TabIndex = 3
        Me.radMulti.Text = "Multiplication"
        Me.radMulti.UseVisualStyleBackColor = True
        '
        'radDiv
        '
        Me.radDiv.AutoSize = True
        Me.radDiv.Location = New System.Drawing.Point(424, 36)
        Me.radDiv.Name = "radDiv"
        Me.radDiv.Size = New System.Drawing.Size(62, 17)
        Me.radDiv.TabIndex = 4
        Me.radDiv.Text = "Division"
        Me.radDiv.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(379, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Please type in your answer to the following math problem. Integer answers only:"
        '
        'lblQuestion
        '
        Me.lblQuestion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestion.Location = New System.Drawing.Point(23, 137)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(134, 23)
        Me.lblQuestion.TabIndex = 6
        '
        'txtAnswer
        '
        Me.txtAnswer.Location = New System.Drawing.Point(192, 137)
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.Size = New System.Drawing.Size(100, 20)
        Me.txtAnswer.TabIndex = 7
        '
        'lblCheck
        '
        Me.lblCheck.Location = New System.Drawing.Point(40, 193)
        Me.lblCheck.Name = "lblCheck"
        Me.lblCheck.Size = New System.Drawing.Size(210, 23)
        Me.lblCheck.TabIndex = 8
        '
        'btnCheck
        '
        Me.btnCheck.Location = New System.Drawing.Point(346, 188)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(156, 23)
        Me.btnCheck.TabIndex = 9
        Me.btnCheck.Text = "Check Your Answer"
        Me.btnCheck.UseVisualStyleBackColor = True
        '
        'btnNextProblem
        '
        Me.btnNextProblem.Location = New System.Drawing.Point(346, 226)
        Me.btnNextProblem.Name = "btnNextProblem"
        Me.btnNextProblem.Size = New System.Drawing.Size(156, 23)
        Me.btnNextProblem.TabIndex = 10
        Me.btnNextProblem.Text = "Next Problem"
        Me.btnNextProblem.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radAdd)
        Me.GroupBox1.Controls.Add(Me.radSub)
        Me.GroupBox1.Controls.Add(Me.radMulti)
        Me.GroupBox1.Controls.Add(Me.radDiv)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(530, 79)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Choose An Integer Operation"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 261)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnNextProblem)
        Me.Controls.Add(Me.btnCheck)
        Me.Controls.Add(Me.lblCheck)
        Me.Controls.Add(Me.txtAnswer)
        Me.Controls.Add(Me.lblQuestion)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Form1"
        Me.Text = "Integer Math Tuter"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents radAdd As System.Windows.Forms.RadioButton
    Friend WithEvents radSub As System.Windows.Forms.RadioButton
    Friend WithEvents radMulti As System.Windows.Forms.RadioButton
    Friend WithEvents radDiv As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblQuestion As System.Windows.Forms.Label
    Friend WithEvents txtAnswer As System.Windows.Forms.TextBox
    Friend WithEvents lblCheck As System.Windows.Forms.Label
    Friend WithEvents btnCheck As System.Windows.Forms.Button
    Friend WithEvents btnNextProblem As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox

End Class
