<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScubaForm
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
        Me.txtNumberPeople = New System.Windows.Forms.TextBox()
        Me.lblDiscount = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnCalcTotal = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Number of People in the Party:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Discount (for 5 or more):"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(129, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Total:"
        '
        'txtNumberPeople
        '
        Me.txtNumberPeople.Location = New System.Drawing.Point(169, 6)
        Me.txtNumberPeople.Name = "txtNumberPeople"
        Me.txtNumberPeople.Size = New System.Drawing.Size(100, 20)
        Me.txtNumberPeople.TabIndex = 3
        '
        'lblDiscount
        '
        Me.lblDiscount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDiscount.Location = New System.Drawing.Point(169, 40)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(100, 23)
        Me.lblDiscount.TabIndex = 4
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Location = New System.Drawing.Point(169, 80)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(100, 23)
        Me.lblTotal.TabIndex = 5
        '
        'btnCalcTotal
        '
        Me.btnCalcTotal.Location = New System.Drawing.Point(12, 126)
        Me.btnCalcTotal.Name = "btnCalcTotal"
        Me.btnCalcTotal.Size = New System.Drawing.Size(75, 40)
        Me.btnCalcTotal.TabIndex = 6
        Me.btnCalcTotal.Text = "&Calculate Total"
        Me.btnCalcTotal.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(103, 126)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 40)
        Me.btnReset.TabIndex = 7
        Me.btnReset.Text = "&Reset Form"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(194, 126)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 40)
        Me.btnClose.TabIndex = 8
        Me.btnClose.Text = "C&lose"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'ScubaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 181)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnCalcTotal)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblDiscount)
        Me.Controls.Add(Me.txtNumberPeople)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ScubaForm"
        Me.Text = "Scuba Diving Adventure"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNumberPeople As TextBox
    Friend WithEvents lblDiscount As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnCalcTotal As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnClose As Button
End Class
