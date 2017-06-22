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
        Me.txtTemp = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblBoil = New System.Windows.Forms.Label()
        Me.lblFreeze = New System.Windows.Forms.Label()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter a Temperature:"
        '
        'txtTemp
        '
        Me.txtTemp.Location = New System.Drawing.Point(138, 6)
        Me.txtTemp.Name = "txtTemp"
        Me.txtTemp.Size = New System.Drawing.Size(147, 20)
        Me.txtTemp.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(12, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 44)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Substances that freeze at that temperature:"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(12, 158)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 44)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Substances that boil at that temperature"
        '
        'lblBoil
        '
        Me.lblBoil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBoil.Location = New System.Drawing.Point(138, 153)
        Me.lblBoil.Name = "lblBoil"
        Me.lblBoil.Size = New System.Drawing.Size(147, 100)
        Me.lblBoil.TabIndex = 4
        '
        'lblFreeze
        '
        Me.lblFreeze.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFreeze.Location = New System.Drawing.Point(138, 52)
        Me.lblFreeze.Name = "lblFreeze"
        Me.lblFreeze.Size = New System.Drawing.Size(147, 100)
        Me.lblFreeze.TabIndex = 5
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(15, 279)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(75, 23)
        Me.btnDisplay.TabIndex = 6
        Me.btnDisplay.Text = "Display"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(206, 279)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(114, 279)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(310, 325)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.lblFreeze)
        Me.Controls.Add(Me.lblBoil)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtTemp)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Freezing  and Boiling Point"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtTemp As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblBoil As Label
    Friend WithEvents lblFreeze As Label
    Friend WithEvents btnDisplay As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
End Class
