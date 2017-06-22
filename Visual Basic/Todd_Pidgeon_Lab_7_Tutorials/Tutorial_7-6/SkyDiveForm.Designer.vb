<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SkyDiveForm
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
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnCalcTotal = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblDiscount = New System.Windows.Forms.Label()
        Me.txtNumberPeople = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(194, 142)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 40)
        Me.btnClose.TabIndex = 17
        Me.btnClose.Text = "C&lose"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(103, 142)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 40)
        Me.btnReset.TabIndex = 16
        Me.btnReset.Text = "&Reset Form"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnCalcTotal
        '
        Me.btnCalcTotal.Location = New System.Drawing.Point(12, 142)
        Me.btnCalcTotal.Name = "btnCalcTotal"
        Me.btnCalcTotal.Size = New System.Drawing.Size(75, 40)
        Me.btnCalcTotal.TabIndex = 15
        Me.btnCalcTotal.Text = "&Calculate Total"
        Me.btnCalcTotal.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Location = New System.Drawing.Point(169, 96)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(100, 23)
        Me.lblTotal.TabIndex = 14
        '
        'lblDiscount
        '
        Me.lblDiscount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDiscount.Location = New System.Drawing.Point(169, 56)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(100, 23)
        Me.lblDiscount.TabIndex = 13
        '
        'txtNumberPeople
        '
        Me.txtNumberPeople.Location = New System.Drawing.Point(169, 22)
        Me.txtNumberPeople.Name = "txtNumberPeople"
        Me.txtNumberPeople.Size = New System.Drawing.Size(100, 20)
        Me.txtNumberPeople.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(129, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Total:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Discount (for 5 or more):"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Number of People in the Party:"
        '
        'SkyDiveForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 204)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnCalcTotal)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblDiscount)
        Me.Controls.Add(Me.txtNumberPeople)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "SkyDiveForm"
        Me.Text = "Sky Diving Adventure"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnClose As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnCalcTotal As Button
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblDiscount As Label
    Friend WithEvents txtNumberPeople As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
