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
        Me.txtGallonsCanHold = New System.Windows.Forms.TextBox()
        Me.txtMilesCanDrive = New System.Windows.Forms.TextBox()
        Me.lblMilesPerGallon = New System.Windows.Forms.Label()
        Me.btnCalculateMPG = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(25, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Gallons of gas the can can hold:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(25, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 44)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Number of miles it can be driven on a full tank:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Miles per gallon:"
        '
        'txtGallonsCanHold
        '
        Me.txtGallonsCanHold.Location = New System.Drawing.Point(137, 27)
        Me.txtGallonsCanHold.Name = "txtGallonsCanHold"
        Me.txtGallonsCanHold.Size = New System.Drawing.Size(100, 20)
        Me.txtGallonsCanHold.TabIndex = 3
        '
        'txtMilesCanDrive
        '
        Me.txtMilesCanDrive.Location = New System.Drawing.Point(137, 77)
        Me.txtMilesCanDrive.Name = "txtMilesCanDrive"
        Me.txtMilesCanDrive.Size = New System.Drawing.Size(100, 20)
        Me.txtMilesCanDrive.TabIndex = 4
        '
        'lblMilesPerGallon
        '
        Me.lblMilesPerGallon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMilesPerGallon.Location = New System.Drawing.Point(137, 142)
        Me.lblMilesPerGallon.Name = "lblMilesPerGallon"
        Me.lblMilesPerGallon.Size = New System.Drawing.Size(100, 23)
        Me.lblMilesPerGallon.TabIndex = 5
        Me.lblMilesPerGallon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCalculateMPG
        '
        Me.btnCalculateMPG.Location = New System.Drawing.Point(23, 195)
        Me.btnCalculateMPG.Name = "btnCalculateMPG"
        Me.btnCalculateMPG.Size = New System.Drawing.Size(75, 39)
        Me.btnCalculateMPG.TabIndex = 6
        Me.btnCalculateMPG.Text = "Calculate MPG"
        Me.btnCalculateMPG.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(104, 195)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 39)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(185, 195)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 39)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculateMPG)
        Me.Controls.Add(Me.lblMilesPerGallon)
        Me.Controls.Add(Me.txtMilesCanDrive)
        Me.Controls.Add(Me.txtGallonsCanHold)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Miles per Gallon Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtGallonsCanHold As TextBox
    Friend WithEvents txtMilesCanDrive As TextBox
    Friend WithEvents lblMilesPerGallon As Label
    Friend WithEvents btnCalculateMPG As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
