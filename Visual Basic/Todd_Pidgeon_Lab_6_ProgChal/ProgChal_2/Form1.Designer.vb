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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtMedication = New System.Windows.Forms.TextBox()
        Me.txtPhysical = New System.Windows.Forms.TextBox()
        Me.txtLab = New System.Windows.Forms.TextBox()
        Me.txtSurgical = New System.Windows.Forms.TextBox()
        Me.txtStay = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Panel1.Controls.Add(Me.txtMedication)
        Me.Panel1.Controls.Add(Me.txtPhysical)
        Me.Panel1.Controls.Add(Me.txtLab)
        Me.Panel1.Controls.Add(Me.txtSurgical)
        Me.Panel1.Controls.Add(Me.txtStay)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(346, 168)
        Me.Panel1.TabIndex = 0
        '
        'txtMedication
        '
        Me.txtMedication.Location = New System.Drawing.Point(133, 43)
        Me.txtMedication.Name = "txtMedication"
        Me.txtMedication.Size = New System.Drawing.Size(137, 20)
        Me.txtMedication.TabIndex = 9
        '
        'txtPhysical
        '
        Me.txtPhysical.Location = New System.Drawing.Point(133, 141)
        Me.txtPhysical.Name = "txtPhysical"
        Me.txtPhysical.Size = New System.Drawing.Size(137, 20)
        Me.txtPhysical.TabIndex = 8
        '
        'txtLab
        '
        Me.txtLab.Location = New System.Drawing.Point(133, 109)
        Me.txtLab.Name = "txtLab"
        Me.txtLab.Size = New System.Drawing.Size(137, 20)
        Me.txtLab.TabIndex = 7
        '
        'txtSurgical
        '
        Me.txtSurgical.Location = New System.Drawing.Point(133, 76)
        Me.txtSurgical.Name = "txtSurgical"
        Me.txtSurgical.Size = New System.Drawing.Size(137, 20)
        Me.txtSurgical.TabIndex = 6
        '
        'txtStay
        '
        Me.txtStay.Location = New System.Drawing.Point(133, 13)
        Me.txtStay.Name = "txtStay"
        Me.txtStay.Size = New System.Drawing.Size(137, 20)
        Me.txtStay.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(46, 144)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Physical Rehab"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(76, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Lab Fees"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(40, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Surgical Charges"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(68, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Medication"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Length of Stay (Days)"
        '
        'lblMessage
        '
        Me.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMessage.Location = New System.Drawing.Point(12, 183)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(346, 23)
        Me.lblMessage.TabIndex = 1
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(12, 229)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(116, 23)
        Me.btnCalculate.TabIndex = 2
        Me.btnCalculate.Text = "Calculate Charges"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(134, 229)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(103, 23)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "Clear Form"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(242, 229)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(116, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(379, 271)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Hospital Charges"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtMedication As System.Windows.Forms.TextBox
    Friend WithEvents txtPhysical As System.Windows.Forms.TextBox
    Friend WithEvents txtLab As System.Windows.Forms.TextBox
    Friend WithEvents txtSurgical As System.Windows.Forms.TextBox
    Friend WithEvents txtStay As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
