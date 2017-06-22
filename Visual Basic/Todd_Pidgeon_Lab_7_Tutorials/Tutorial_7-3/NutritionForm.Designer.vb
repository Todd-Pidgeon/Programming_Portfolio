<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NutritionForm
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblFood = New System.Windows.Forms.Label()
        Me.lblCalories = New System.Windows.Forms.Label()
        Me.lblFat = New System.Windows.Forms.Label()
        Me.lblCarb = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(61, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Food"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(48, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Calories"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fat Grams"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Carb Grams"
        '
        'lblFood
        '
        Me.lblFood.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFood.Location = New System.Drawing.Point(98, 9)
        Me.lblFood.Name = "lblFood"
        Me.lblFood.Size = New System.Drawing.Size(174, 23)
        Me.lblFood.TabIndex = 4
        '
        'lblCalories
        '
        Me.lblCalories.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCalories.Location = New System.Drawing.Point(98, 44)
        Me.lblCalories.Name = "lblCalories"
        Me.lblCalories.Size = New System.Drawing.Size(174, 23)
        Me.lblCalories.TabIndex = 5
        '
        'lblFat
        '
        Me.lblFat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFat.Location = New System.Drawing.Point(98, 83)
        Me.lblFat.Name = "lblFat"
        Me.lblFat.Size = New System.Drawing.Size(174, 23)
        Me.lblFat.TabIndex = 6
        '
        'lblCarb
        '
        Me.lblCarb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCarb.Location = New System.Drawing.Point(98, 122)
        Me.lblCarb.Name = "lblCarb"
        Me.lblCarb.Size = New System.Drawing.Size(174, 23)
        Me.lblCarb.TabIndex = 7
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(98, 171)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 8
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'NutritionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 208)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblCarb)
        Me.Controls.Add(Me.lblFat)
        Me.Controls.Add(Me.lblCalories)
        Me.Controls.Add(Me.lblFood)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "NutritionForm"
        Me.Text = "Nutritional Info"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblFood As Label
    Friend WithEvents lblCalories As Label
    Friend WithEvents lblFat As Label
    Friend WithEvents lblCarb As Label
    Friend WithEvents btnClose As Button
End Class
