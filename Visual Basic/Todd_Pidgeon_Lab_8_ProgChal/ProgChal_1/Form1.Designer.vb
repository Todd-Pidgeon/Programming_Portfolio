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
        Me.btnStepOne = New System.Windows.Forms.Button()
        Me.btnStepTwo = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.lstNumbers = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnStepOne
        '
        Me.btnStepOne.Location = New System.Drawing.Point(12, 12)
        Me.btnStepOne.Name = "btnStepOne"
        Me.btnStepOne.Size = New System.Drawing.Size(178, 23)
        Me.btnStepOne.TabIndex = 0
        Me.btnStepOne.Text = "Step 1: Input the integers"
        Me.btnStepOne.UseVisualStyleBackColor = True
        '
        'btnStepTwo
        '
        Me.btnStepTwo.Location = New System.Drawing.Point(12, 60)
        Me.btnStepTwo.Name = "btnStepTwo"
        Me.btnStepTwo.Size = New System.Drawing.Size(178, 23)
        Me.btnStepTwo.TabIndex = 1
        Me.btnStepTwo.Text = "Step 2: Display Min and Max"
        Me.btnStepTwo.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(12, 112)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblMessage
        '
        Me.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMessage.Location = New System.Drawing.Point(12, 163)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(317, 23)
        Me.lblMessage.TabIndex = 3
        '
        'lstNumbers
        '
        Me.lstNumbers.FormattingEnabled = True
        Me.lstNumbers.Location = New System.Drawing.Point(209, 12)
        Me.lstNumbers.Name = "lstNumbers"
        Me.lstNumbers.Size = New System.Drawing.Size(120, 134)
        Me.lstNumbers.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(352, 261)
        Me.Controls.Add(Me.lstNumbers)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnStepTwo)
        Me.Controls.Add(Me.btnStepOne)
        Me.Name = "Form1"
        Me.Text = "Largest / Smallest Values"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnStepOne As System.Windows.Forms.Button
    Friend WithEvents btnStepTwo As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents lstNumbers As System.Windows.Forms.ListBox

End Class
