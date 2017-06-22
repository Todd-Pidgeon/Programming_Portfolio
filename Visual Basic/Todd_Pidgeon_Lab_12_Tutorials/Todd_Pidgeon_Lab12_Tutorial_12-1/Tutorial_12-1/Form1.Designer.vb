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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtTestAverage = New System.Windows.Forms.TextBox()
        Me.txtIdNumber = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.lblGrade = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(155, 225)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 14
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(36, 225)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 13
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.txtTestAverage)
        Me.groupBox1.Controls.Add(Me.txtIdNumber)
        Me.groupBox1.Controls.Add(Me.txtFirstName)
        Me.groupBox1.Controls.Add(Me.txtLastName)
        Me.groupBox1.Controls.Add(Me.lblGrade)
        Me.groupBox1.Controls.Add(Me.label5)
        Me.groupBox1.Controls.Add(Me.label4)
        Me.groupBox1.Controls.Add(Me.label3)
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Location = New System.Drawing.Point(13, 12)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(259, 192)
        Me.groupBox1.TabIndex = 12
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Student Data"
        '
        'txtTestAverage
        '
        Me.txtTestAverage.Location = New System.Drawing.Point(117, 111)
        Me.txtTestAverage.Name = "txtTestAverage"
        Me.txtTestAverage.Size = New System.Drawing.Size(100, 20)
        Me.txtTestAverage.TabIndex = 9
        '
        'txtIdNumber
        '
        Me.txtIdNumber.Location = New System.Drawing.Point(117, 81)
        Me.txtIdNumber.Name = "txtIdNumber"
        Me.txtIdNumber.Size = New System.Drawing.Size(100, 20)
        Me.txtIdNumber.TabIndex = 8
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(117, 55)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(100, 20)
        Me.txtFirstName.TabIndex = 7
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(117, 30)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(100, 20)
        Me.txtLastName.TabIndex = 6
        '
        'lblGrade
        '
        Me.lblGrade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGrade.Location = New System.Drawing.Point(117, 144)
        Me.lblGrade.Name = "lblGrade"
        Me.lblGrade.Size = New System.Drawing.Size(100, 23)
        Me.lblGrade.TabIndex = 5
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(48, 145)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(63, 13)
        Me.label5.TabIndex = 4
        Me.label5.Text = "Test Grade:"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(37, 114)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(74, 13)
        Me.label4.TabIndex = 3
        Me.label4.Text = "Test Average:"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(50, 84)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(61, 13)
        Me.label3.TabIndex = 2
        Me.label3.Text = "ID Number:"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(51, 58)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(60, 13)
        Me.label2.TabIndex = 1
        Me.label2.Text = "First Name:"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(50, 33)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(61, 13)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Last Name:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.groupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents btnExit As Button
    Private WithEvents btnSave As Button
    Private WithEvents groupBox1 As GroupBox
    Private WithEvents txtTestAverage As TextBox
    Private WithEvents txtIdNumber As TextBox
    Private WithEvents txtFirstName As TextBox
    Private WithEvents txtLastName As TextBox
    Private WithEvents lblGrade As Label
    Private WithEvents label5 As Label
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
End Class
