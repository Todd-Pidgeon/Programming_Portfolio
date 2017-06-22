<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.lstDorms = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblDormitory = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblMealPlan = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnAddDorm = New System.Windows.Forms.Button()
        Me.btnMealPlan = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select A Domitory"
        '
        'lstDorms
        '
        Me.lstDorms.FormattingEnabled = True
        Me.lstDorms.Location = New System.Drawing.Point(38, 68)
        Me.lstDorms.Name = "lstDorms"
        Me.lstDorms.Size = New System.Drawing.Size(255, 95)
        Me.lstDorms.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(366, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Charges for the Semester"
        '
        'lblDormitory
        '
        Me.lblDormitory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDormitory.Location = New System.Drawing.Point(412, 68)
        Me.lblDormitory.Name = "lblDormitory"
        Me.lblDormitory.Size = New System.Drawing.Size(100, 23)
        Me.lblDormitory.TabIndex = 3
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Location = New System.Drawing.Point(412, 154)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(100, 23)
        Me.lblTotal.TabIndex = 5
        '
        'lblMealPlan
        '
        Me.lblMealPlan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMealPlan.Location = New System.Drawing.Point(412, 108)
        Me.lblMealPlan.Name = "lblMealPlan"
        Me.lblMealPlan.Size = New System.Drawing.Size(100, 23)
        Me.lblMealPlan.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(352, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Dormitory:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(372, 155)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Total:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(349, 109)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Meal Plan:"
        '
        'btnAddDorm
        '
        Me.btnAddDorm.Location = New System.Drawing.Point(12, 247)
        Me.btnAddDorm.Name = "btnAddDorm"
        Me.btnAddDorm.Size = New System.Drawing.Size(106, 49)
        Me.btnAddDorm.TabIndex = 10
        Me.btnAddDorm.Text = "Add Dormitory"
        Me.btnAddDorm.UseVisualStyleBackColor = True
        '
        'btnMealPlan
        '
        Me.btnMealPlan.Location = New System.Drawing.Point(142, 247)
        Me.btnMealPlan.Name = "btnMealPlan"
        Me.btnMealPlan.Size = New System.Drawing.Size(106, 49)
        Me.btnMealPlan.TabIndex = 11
        Me.btnMealPlan.Text = "View Meal Plans"
        Me.btnMealPlan.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(277, 247)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(106, 49)
        Me.btnClear.TabIndex = 12
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(412, 247)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(106, 49)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(536, 329)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnMealPlan)
        Me.Controls.Add(Me.btnAddDorm)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblMealPlan)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblDormitory)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lstDorms)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MainForm"
        Me.Text = "Dorm and Meal Plan Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lstDorms As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblDormitory As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lblMealPlan As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnAddDorm As System.Windows.Forms.Button
    Friend WithEvents btnMealPlan As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
