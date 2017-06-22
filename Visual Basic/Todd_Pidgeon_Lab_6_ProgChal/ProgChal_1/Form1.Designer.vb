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
        Me.lblRetailPrice = New System.Windows.Forms.Label()
        Me.txtWholesale = New System.Windows.Forms.TextBox()
        Me.txtMarkup = New System.Windows.Forms.TextBox()
        Me.btnGetRetail = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Wholesale Cost of item"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(74, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Markup %"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(67, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Retail Price"
        '
        'lblRetailPrice
        '
        Me.lblRetailPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRetailPrice.Location = New System.Drawing.Point(134, 121)
        Me.lblRetailPrice.Name = "lblRetailPrice"
        Me.lblRetailPrice.Size = New System.Drawing.Size(100, 23)
        Me.lblRetailPrice.TabIndex = 3
        '
        'txtWholesale
        '
        Me.txtWholesale.Location = New System.Drawing.Point(134, 24)
        Me.txtWholesale.Name = "txtWholesale"
        Me.txtWholesale.Size = New System.Drawing.Size(100, 20)
        Me.txtWholesale.TabIndex = 4
        '
        'txtMarkup
        '
        Me.txtMarkup.Location = New System.Drawing.Point(134, 69)
        Me.txtMarkup.Name = "txtMarkup"
        Me.txtMarkup.Size = New System.Drawing.Size(100, 20)
        Me.txtMarkup.TabIndex = 5
        '
        'btnGetRetail
        '
        Me.btnGetRetail.Location = New System.Drawing.Point(27, 173)
        Me.btnGetRetail.Name = "btnGetRetail"
        Me.btnGetRetail.Size = New System.Drawing.Size(75, 23)
        Me.btnGetRetail.TabIndex = 6
        Me.btnGetRetail.Text = "Get Retail"
        Me.btnGetRetail.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(159, 173)
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
        Me.ClientSize = New System.Drawing.Size(266, 213)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnGetRetail)
        Me.Controls.Add(Me.txtMarkup)
        Me.Controls.Add(Me.txtWholesale)
        Me.Controls.Add(Me.lblRetailPrice)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Retail Price Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblRetailPrice As System.Windows.Forms.Label
    Friend WithEvents txtWholesale As System.Windows.Forms.TextBox
    Friend WithEvents txtMarkup As System.Windows.Forms.TextBox
    Friend WithEvents btnGetRetail As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
