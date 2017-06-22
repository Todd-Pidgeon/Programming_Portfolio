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
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtZip = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(168, 266)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 17
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(49, 266)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 16
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.Label7)
        Me.groupBox1.Controls.Add(Me.Label6)
        Me.groupBox1.Controls.Add(Me.txtZip)
        Me.groupBox1.Controls.Add(Me.txtPhone)
        Me.groupBox1.Controls.Add(Me.txtState)
        Me.groupBox1.Controls.Add(Me.txtCity)
        Me.groupBox1.Controls.Add(Me.txtAddress)
        Me.groupBox1.Controls.Add(Me.txtFirstName)
        Me.groupBox1.Controls.Add(Me.txtLastName)
        Me.groupBox1.Controls.Add(Me.label5)
        Me.groupBox1.Controls.Add(Me.label4)
        Me.groupBox1.Controls.Add(Me.label3)
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Location = New System.Drawing.Point(13, 13)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(259, 235)
        Me.groupBox1.TabIndex = 15
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Person Data"
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(117, 111)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(100, 20)
        Me.txtCity.TabIndex = 9
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(117, 81)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(100, 20)
        Me.txtAddress.TabIndex = 8
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
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(76, 145)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(35, 13)
        Me.label5.TabIndex = 4
        Me.label5.Text = "State:"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(84, 111)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(27, 13)
        Me.label4.TabIndex = 3
        Me.label4.Text = "City:"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(63, 84)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(48, 13)
        Me.label3.TabIndex = 2
        Me.label3.Text = "Address:"
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
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(117, 142)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(100, 20)
        Me.txtState.TabIndex = 10
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(117, 194)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(100, 20)
        Me.txtPhone.TabIndex = 11
        '
        'txtZip
        '
        Me.txtZip.Location = New System.Drawing.Point(117, 168)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(100, 20)
        Me.txtZip.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(76, 197)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Phone:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(86, 171)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(25, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Zip:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 312)
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
    Private WithEvents txtCity As TextBox
    Private WithEvents txtAddress As TextBox
    Private WithEvents txtFirstName As TextBox
    Private WithEvents txtLastName As TextBox
    Private WithEvents label5 As Label
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Private WithEvents Label7 As Label
    Private WithEvents Label6 As Label
    Private WithEvents txtZip As TextBox
    Private WithEvents txtPhone As TextBox
    Private WithEvents txtState As TextBox
End Class
