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
        Me.txtA = New System.Windows.Forms.TextBox()
        Me.txtB = New System.Windows.Forms.TextBox()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.btnCompare = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(71, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter Two Integers"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(17, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "A:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(131, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(17, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "B:"
        '
        'txtA
        '
        Me.txtA.Location = New System.Drawing.Point(36, 36)
        Me.txtA.Name = "txtA"
        Me.txtA.Size = New System.Drawing.Size(72, 20)
        Me.txtA.TabIndex = 3
        '
        'txtB
        '
        Me.txtB.Location = New System.Drawing.Point(154, 36)
        Me.txtB.Name = "txtB"
        Me.txtB.Size = New System.Drawing.Size(72, 20)
        Me.txtB.TabIndex = 4
        '
        'lblAnswer
        '
        Me.lblAnswer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAnswer.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lblAnswer.Location = New System.Drawing.Point(16, 79)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(226, 23)
        Me.lblAnswer.TabIndex = 5
        Me.lblAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCompare
        '
        Me.btnCompare.Location = New System.Drawing.Point(33, 125)
        Me.btnCompare.Name = "btnCompare"
        Me.btnCompare.Size = New System.Drawing.Size(75, 23)
        Me.btnCompare.TabIndex = 6
        Me.btnCompare.Text = "Compare"
        Me.btnCompare.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(154, 125)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(273, 176)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCompare)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.txtB)
        Me.Controls.Add(Me.txtA)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Larger and Smaller"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtA As TextBox
    Friend WithEvents txtB As TextBox
    Friend WithEvents lblAnswer As Label
    Friend WithEvents btnCompare As Button
    Friend WithEvents btnExit As Button
End Class
