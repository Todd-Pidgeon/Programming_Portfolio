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
        Me.cboStudent = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTest1 = New System.Windows.Forms.TextBox()
        Me.txtTest2 = New System.Windows.Forms.TextBox()
        Me.txtTest4 = New System.Windows.Forms.TextBox()
        Me.txtTest3 = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lstGrades = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select a Student:"
        '
        'cboStudent
        '
        Me.cboStudent.FormattingEnabled = True
        Me.cboStudent.Items.AddRange(New Object() {"Todd", "Jim", "Bob", "Brian", "Sam"})
        Me.cboStudent.Location = New System.Drawing.Point(107, 12)
        Me.cboStudent.Name = "cboStudent"
        Me.cboStudent.Size = New System.Drawing.Size(121, 21)
        Me.cboStudent.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(61, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Enter Test Scores"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(61, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Test 1:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(61, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Test 4:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(61, 134)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Test 3:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(61, 108)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Test 2:"
        '
        'txtTest1
        '
        Me.txtTest1.Location = New System.Drawing.Point(107, 79)
        Me.txtTest1.Name = "txtTest1"
        Me.txtTest1.Size = New System.Drawing.Size(100, 20)
        Me.txtTest1.TabIndex = 7
        '
        'txtTest2
        '
        Me.txtTest2.Location = New System.Drawing.Point(107, 105)
        Me.txtTest2.Name = "txtTest2"
        Me.txtTest2.Size = New System.Drawing.Size(100, 20)
        Me.txtTest2.TabIndex = 8
        '
        'txtTest4
        '
        Me.txtTest4.Location = New System.Drawing.Point(107, 157)
        Me.txtTest4.Name = "txtTest4"
        Me.txtTest4.Size = New System.Drawing.Size(100, 20)
        Me.txtTest4.TabIndex = 9
        '
        'txtTest3
        '
        Me.txtTest3.Location = New System.Drawing.Point(107, 131)
        Me.txtTest3.Name = "txtTest3"
        Me.txtTest3.Size = New System.Drawing.Size(100, 20)
        Me.txtTest3.TabIndex = 10
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(39, 365)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(114, 23)
        Me.btnCalculate.TabIndex = 11
        Me.btnCalculate.Text = "Calculate Grade"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(116, 194)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(76, 23)
        Me.btnSave.TabIndex = 12
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'lstGrades
        '
        Me.lstGrades.FormattingEnabled = True
        Me.lstGrades.Location = New System.Drawing.Point(19, 19)
        Me.lstGrades.Name = "lstGrades"
        Me.lstGrades.Size = New System.Drawing.Size(283, 95)
        Me.lstGrades.TabIndex = 13
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lstGrades)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 232)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(326, 127)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Student Grades"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(242, 365)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 15
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(364, 406)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtTest3)
        Me.Controls.Add(Me.txtTest4)
        Me.Controls.Add(Me.txtTest2)
        Me.Controls.Add(Me.txtTest1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboStudent)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboStudent As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtTest1 As System.Windows.Forms.TextBox
    Friend WithEvents txtTest2 As System.Windows.Forms.TextBox
    Friend WithEvents txtTest4 As System.Windows.Forms.TextBox
    Friend WithEvents txtTest3 As System.Windows.Forms.TextBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents lstGrades As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
