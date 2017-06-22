<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MealsForm
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
        Me.lstMeals = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstMeals
        '
        Me.lstMeals.FormattingEnabled = True
        Me.lstMeals.Location = New System.Drawing.Point(38, 58)
        Me.lstMeals.Name = "lstMeals"
        Me.lstMeals.Size = New System.Drawing.Size(255, 95)
        Me.lstMeals.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Select A Weekly Meal Plan"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(356, 45)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(99, 46)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Add Meal Plan"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(356, 126)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(99, 46)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'MealsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(504, 217)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lstMeals)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MealsForm"
        Me.Text = "Meal Plans"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstMeals As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
End Class
